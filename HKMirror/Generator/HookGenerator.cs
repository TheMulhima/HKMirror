using System.Linq;
using System.Text;

namespace HKMirror.Generator;

internal class HookGenerator
{
    private bool noreturn, isIEnumarator, isOverload, isGeneratedByMonomod_On, isGeneratedByMonomod_IL;
    private string ClassName, ClassFullName, name;
    private ParameterInfo[] param;
    
    private StringBuilder HookHandler = new(), Delegates = new(), BeforeOrig = new(), AfterOrig = new(), WithOrig = new();
    private StringBuilder argsList, argsListWithType, NonGeneratedOrig;
    private StringBuilder ILHooks = new();

    public HookGenerator(Type TargetType, string _className)
    {
        ClassName = _className;
        if (!TargetType.IsPublic) return;
        StringBuilder OnHooks = new();

        OnHooks.AppendLine("using MonoMod.RuntimeDetour;");
        OnHooks.AppendLine("using MonoMod.RuntimeDetour.HookGen;");
        OnHooks.AppendLine("namespace HKMirror.OnHooks;");
        OnHooks.AppendLine($"public static class On{ClassName}\n{{");

        HookHandler.AppendLine("internal static class HookHandler\n{");
        HookHandler.AppendLine("private static List<string> HookedList = new List<string>();");
        
        Delegates.AppendLine("/// <summary>\n/// Contains necessary information to create Hooks. Does not contain any hooks\n/// </summary>");
        Delegates.AppendLine("public static class Delegates\n{");
        
        BeforeOrig.AppendLine("/// <summary>\n/// Conatins Hooks to that run code before orig(self) is called\n/// </summary>");
        BeforeOrig.AppendLine("public static class BeforeOrig\n{");
        
        AfterOrig.AppendLine("/// <summary>\n/// Contains Hooks to that run code after orig(self) is called\n/// </summary>");
        AfterOrig.AppendLine("public static class AfterOrig\n{");
        
        WithOrig.AppendLine("/// <summary>\n/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters\n/// </summary>");
        WithOrig.AppendLine("public static class WithOrig\n{");
        
        ILHooks.AppendLine("using MonoMod.RuntimeDetour.HookGen;");
        ILHooks.AppendLine("namespace HKMirror.ILHooks;");
        ILHooks.AppendLine("/// <summary>\n/// Contains all correct IL Hooks,\nGives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return\nIncludes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters\n/// </summary>");
        ILHooks.AppendLine($"public static class IL{ClassName}\n{{");

        var OnMonoModEvents = Type.GetType($"On.{ClassName}, MMHOOK_Assembly-CSharp").GetEvents().Select(x => x.Name);
        var ILMonoModEvents = Type.GetType($"IL.{ClassName}, MMHOOK_Assembly-CSharp").GetEvents().Select(x => x.Name);

        var AllAvailableMethods = TargetType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic |
                                                        BindingFlags.Instance |
                                                        BindingFlags.Static | BindingFlags.DeclaredOnly);
        foreach (var method in AllAvailableMethods)
        {
            if (RGUtils.ignoreMethodHook(method.Name)) continue;
            if (!method.ReturnType.IsPublic) continue;
            if (method.IsGenericMethod) continue;

            noreturn = method.ReturnType == typeof(void);
            isIEnumarator = method.ReturnType == typeof(IEnumerator);
            isOverload = RGUtils.isOverloaded(AllAvailableMethods, method.Name);
            ClassFullName = TargetType.ToString().Replace("+", ".");
            name = method.Name;
            param = method.GetParameters();

            if (isOverload)
            {
                foreach (var p in param)
                {
                    name += $"_{RGUtils.GetParameterTypeName(p.ParameterType)}";
                }
            }

            isGeneratedByMonomod_On = OnMonoModEvents.Contains(name);
            isGeneratedByMonomod_IL = ILMonoModEvents.Contains(name);

            (argsList, argsListWithType, NonGeneratedOrig) = GenerateArgsLists(method: method);

            PopulateHookHandler(method: method);

            Delegates.AppendLine($"public delegate void {name}_args({argsListWithType});");

            PopulateBeforeOrig();
            
            PopulateAfterOrig();
            
            PopulateWithOrig(method: method);

            PopulateILHooks(method:method);
        }

        HookHandler.AppendLine("}");
        Delegates.AppendLine("}");
        BeforeOrig.AppendLine("}");
        AfterOrig.AppendLine("}");
        WithOrig.AppendLine("}");

        OnHooks.AppendLine(HookHandler.ToString());
        OnHooks.AppendLine(Delegates.ToString());
        OnHooks.AppendLine(BeforeOrig.ToString());
        OnHooks.AppendLine(AfterOrig.ToString());
        OnHooks.AppendLine(WithOrig.ToString());
        OnHooks.AppendLine("}");
        
        ILHooks.AppendLine("}");
        
        Modding.Logger.LogError("Starting On Hooks");
        Modding.Logger.Log(OnHooks);
        
        Modding.Logger.LogError("Starting IL Hooks");
        Modding.Logger.Log(ILHooks);
    }

    void PopulateBeforeOrig()
    {
        BeforeOrig.AppendLine($"public static event Delegates.{name}_args {name}");
        BeforeOrig.AppendLine("{\nadd\n{\n");
        BeforeOrig.AppendLine($"HookHandler._before{name} += value;");
        BeforeOrig.AppendLine($"HookHandler.Hook{name}();\n}}");
        BeforeOrig.AppendLine($"remove => HookHandler._before{name} -= value;\n}}");
    }
    void PopulateAfterOrig()
    {
        if (!isIEnumarator)
        {
            AfterOrig.AppendLine($"public static event Delegates.{name}_args {name}");
            AfterOrig.AppendLine("{\nadd\n{\n");
            AfterOrig.AppendLine($"HookHandler._after{name} += value;");
            AfterOrig.AppendLine($"HookHandler.Hook{name}();\n}}");
            AfterOrig.AppendLine($"remove => HookHandler._after{name} -= value;\n}}");
        }
    }
    void PopulateWithOrig(MethodInfo method)
    {
        WithOrig.AppendLine($"public static event Delegates.{name}_args {name}\n{{");
        if (!isGeneratedByMonomod_On)
        {
            WithOrig.AppendLine($"add => HookEndpointManager.Add<Delegates.{name}>(ReflectionHelper.GetMethodInfo(typeof({ClassFullName}), \"{name}\", {RGUtils.fixBoolName(!method.IsStatic)}), value);");
            WithOrig.AppendLine($"remove => HookEndpointManager.Remove<Delegates.{name}>(ReflectionHelper.GetMethodInfo(typeof({ClassFullName}), \"{name}\", {RGUtils.fixBoolName(!method.IsStatic)}), value);\n}}");
        }
        else
        {
            WithOrig.AppendLine($"add => On.{ClassName}.{name} += value;");
            WithOrig.AppendLine($"remove => On.{ClassName}.{name} -= value;\n}}");
        }
    }
    void PopulateILHooks(MethodInfo method)
    {
        ILHooks.AppendLine($"public static event ILContext.Manipulator {name}\n{{");
        if (isIEnumarator)
        {
            ILHooks.AppendLine($"add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof({ClassFullName}), \"{name}\", {RGUtils.fixBoolName(!method.IsStatic)}).GetStateMachineTarget(), value);");
            ILHooks.AppendLine($"remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof({ClassFullName}), \"{name}\", {RGUtils.fixBoolName(!method.IsStatic)}).GetStateMachineTarget(), value);\n}}");
        }
        else
        {
            if (isGeneratedByMonomod_IL)
            {
                ILHooks.AppendLine($"add => IL.{ClassName}.{name} += value;");
                ILHooks.AppendLine($"remove => IL.{ClassName}.{name} -= value;\n}}");
            }
            else
            {
                ILHooks.AppendLine($"add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof({ClassFullName}), \"{name}\", {RGUtils.fixBoolName(!method.IsStatic)}), value);");
                ILHooks.AppendLine($"remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof({ClassFullName}), \"{name}\", {RGUtils.fixBoolName(!method.IsStatic)}), value);\n}}");
            }
        }
    }

    private (StringBuilder, StringBuilder, StringBuilder) GenerateArgsLists(MethodInfo method)
    {
        argsListWithType = new();
        argsList = new();
        NonGeneratedOrig = new();

        if (!noreturn)
        {
            NonGeneratedOrig.Append("Func<");
        }
        else
        {
            NonGeneratedOrig.Append("Action<");
        }

        if (!method.IsStatic)
        {
            argsListWithType.Append($"{ClassFullName} self");
            argsList.Append($"self");
            NonGeneratedOrig.Append(ClassFullName);
            if (param.Length > 0)
            {
                argsListWithType.Append(", ");
                argsList.Append(", ");
                NonGeneratedOrig.Append(", ");
            }
        }

        for (int i = 0; i < param.Length; i++)
        {
            if (param[i].ParameterType.IsByRef)
            {
                argsListWithType.Append("ref ");
                argsList.Append("ref ");
            }

            argsListWithType.Append($" {RGUtils.removeSystemType(param[i].ParameterType)} {param[i].Name}");
            argsList.Append($"{param[i].Name}");
            NonGeneratedOrig.Append($" {RGUtils.removeSystemType(param[i].ParameterType)}");
            if (i != param.Length - 1)
            {
                argsListWithType.Append(", ");
                argsList.Append(", ");
                NonGeneratedOrig.Append(", ");
            }
        }

        if (!noreturn)
        {
            if (!(method.IsStatic && param.Length == 0))
            {
                NonGeneratedOrig.Append(", ");
            }
            NonGeneratedOrig.Append($"{RGUtils.removeSystemType(method.ReturnType)}>");
        }
        else
        {
            NonGeneratedOrig.Append(">");
        }

        return (argsList, argsListWithType, NonGeneratedOrig);
    }
    private void PopulateHookHandler(MethodInfo method)
    {
        HookHandler.AppendLine($"internal static void Hook{name}()\n{{");
        HookHandler.AppendLine($"if (!HookedList.Contains(\"{name}\"))\n{{");
        HookHandler.AppendLine($"HookedList.Add(\"{name}\");");
        if (isGeneratedByMonomod_On)
        {
            HookHandler.AppendLine($"On.{ClassName}.{name} += {name};");
        }
        else
        {
            HookHandler.AppendLine($"new Hook(ReflectionHelper.GetMethodInfo(typeof({ClassFullName}), \"{name}\", {RGUtils.fixBoolName(!method.IsStatic)}), {name});"); 
        }
        HookHandler.AppendLine("\n}\n}");
        
        HookHandler.AppendLine($"internal static event Delegates.{name}_args _before{name};");
        if (!isIEnumarator) HookHandler.AppendLine($"internal static event Delegates.{name}_args _after{name};");

        if (method.IsStatic && param.Length == 0)
        {
            if (isGeneratedByMonomod_On)
            {
                HookHandler.AppendLine(
                    $"private static {RGUtils.removeSystemType(method.ReturnType)} {name}(On.{ClassName}.orig_{name} orig)\n{{");
            }
            else
            {
                HookHandler.AppendLine(
                    $"private static {RGUtils.removeSystemType(method.ReturnType)} {name}({NonGeneratedOrig} orig)\n{{");
            }
        }
        else
        {
            if (isGeneratedByMonomod_On)
            {
                HookHandler.AppendLine(
                    $"private static {RGUtils.removeSystemType(method.ReturnType)} {name}(On.{ClassName}.orig_{name} orig,{argsListWithType})\n{{");
            }
            else
            {
                HookHandler.AppendLine(
                    $"private static {RGUtils.removeSystemType(method.ReturnType)} {name}({NonGeneratedOrig} orig, {argsListWithType})\n{{");
            }
        }

        HookHandler.AppendLine($"_before{name}?.Invoke({argsList});");
        if (isIEnumarator)
        {
            HookHandler.AppendLine($"return orig({argsList});");
        }
        else 
        {
            if (noreturn)
            {
                HookHandler.AppendLine($"orig({argsList});");
            }
            else
            {
                HookHandler.AppendLine($"var retVal = orig({argsList});");
            }

            HookHandler.AppendLine($"_after{name}?.Invoke({argsList});");
            if (!noreturn)
            {
                HookHandler.AppendLine("return retVal;");
            }
        }
        
        HookHandler.AppendLine("}");
    }

}