﻿using System.IO;
using System.Linq;
using System.Text;
using HKMirror.Hooks.OnHooks;

namespace HKMirror.Generator;

internal class HookGenerator
{
    private bool noreturn, isIEnumarator, isOverload, isGeneratedByMonomod_On, isGeneratedByMonomod_IL;
    private string ClassName, ClassFullName, name;
    private ParameterInfo[] param;
    
    private StringBuilder HookHandler = new(), Delegates = new(), BeforeOrig = new(), AfterOrig = new(), WithOrig = new();
    private StringBuilder argsList, argsListWithType, NonGeneratedOrig;
    private StringBuilder ILHooks = new();

    private List<string> FinishedFunctions = new List<string>();
    private List<string> ParamsList = new List<string>();

    public HookGenerator(Type TargetType, string _className, string Dir, bool inModlog = true)
    {
        ClassName = _className;
        if (!TargetType.IsPublic) return;
        if (TargetType.IsGenericType) return;
        StringBuilder OnHooks = new();

        OnHooks.AppendLine("using MonoMod.RuntimeDetour;");
        OnHooks.AppendLine("using MonoMod.RuntimeDetour.HookGen;");
        OnHooks.AppendLine("namespace HKMirror.Hooks.OnHooks;");
        OnHooks.AppendLine($"/// <summary>\n/// Contains different types of On Hooks for {ClassName} class\n/// Contains hooks that aren't generated by monomod, and before and after orig hooks for easier hooking.\n/// </summary>");
        OnHooks.AppendLine($"public static class On{ClassName}\n{{");

        HookHandler.AppendLine("internal static class HookHandler\n{");
        HookHandler.AppendLine("private static List<string> HookedList = new List<string>();");
        
        Delegates.AppendLine("/// <summary>\n/// Contains necessary information to create Hooks. Does not contain any hooks\n/// </summary>");
        Delegates.AppendLine("public static class Delegates\n{");
        
        BeforeOrig.AppendLine("/// <summary>\n/// Contains Hooks to that run code before orig(self) is called\n/// </summary>");
        BeforeOrig.AppendLine("public static class BeforeOrig\n{");
        
        AfterOrig.AppendLine("/// <summary>\n/// Contains Hooks to that run code after orig(self) is called\n/// </summary>");
        AfterOrig.AppendLine("public static class AfterOrig\n{");
        
        WithOrig.AppendLine("/// <summary>\n/// Contains all On Hooks, even those that aren't in the On namespace such as API generated functions and property getters/setters\n/// </summary>");
        WithOrig.AppendLine("public static class WithOrig\n{");
        
        ILHooks.AppendLine("using MonoMod.RuntimeDetour.HookGen;");
        ILHooks.AppendLine("namespace HKMirror.Hooks.ILHooks;");
        ILHooks.AppendLine($"/// <summary>\n/// Contains all correct IL Hooks for {ClassName},\n/// Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />\n/// Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.\n/// </summary>");
        ILHooks.AppendLine($"public static class IL{ClassName}\n{{");

        var ontype = Type.GetType($"On.{ClassName}, MMHOOK_Assembly-CSharp");
        var iltype = Type.GetType($"IL.{ClassName}, MMHOOK_Assembly-CSharp");
        string[] OnMonoModEvents = Array.Empty<string>(), ILMonoModEvents = Array.Empty<string>();
        if (ontype != null)
        {
            OnMonoModEvents = ontype.GetEvents().Select(x => x.Name).ToArray();
        }
        if (iltype != null)
        {
            ILMonoModEvents = iltype.GetEvents().Select(x => x.Name).ToArray();
        }

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


            bool ToSkip = false;
            string reason = String.Empty;

            foreach (var p in param)
            {
                if (!p.ParameterType.IsPublic)
                {
                    ToSkip = true;
                    reason = $"{p.ParameterType} {p.Name} isnt public";
                    break;
                }
                if (p.ParameterType.IsConstructedGenericType)
                {
                    foreach (var subType in p.ParameterType.GetGenericArguments())
                    {
                        if (!subType.IsPublic)
                        {
                            ToSkip = true;
                            reason = $"{p.ParameterType} {p.Name} has a generic non public type";
                            break;
                        }
                    }
                }

                if (isOverload)
                {
                    name += $"_{RGUtils.GetParameterTypeName(p.ParameterType)}";
                }
            }

            if (ToSkip)
            {
                Modding.Logger.LogError($"{ClassName}.{name} params didnt make the cut cuz {reason}");
                continue;
            }
            

            name = RGUtils.RemoveUnecessaryInName(name);
            
            //remove any namespace/interface stuff
            var subs = name.Split('.');
            name = subs[subs.Length - 1];
            
            if (name.Contains("]")) 
            {
                Modding.Logger.LogWarn($"{ClassName}.{name} contains ]");
                name = name.Replace("]", "");
            }
            
            if (FinishedFunctions.Contains(name)) continue;

            FinishedFunctions.Add(name);


            isGeneratedByMonomod_On = ontype != null && OnMonoModEvents.Contains(name);
            isGeneratedByMonomod_IL = iltype != null && ILMonoModEvents.Contains(name);

            GenerateArgsLists(method: method);


            ParamsList = new List<string>();
            if (!(method.IsStatic && param.Length == 0))
            {
                Delegates.AppendLine($"public sealed class Params_{name}\n{{");
                if (!method.IsStatic)
                {
                    ParamsList.Add("self");
                    Delegates.AppendLine($"public {ClassFullName} self;");
                }

                foreach (var p in param)
                {
                    var ParamName = p.Name;
                    if (ParamName == "orig")
                    {
                        ParamName = "orig_";
                    }

                    ParamsList.Add(ParamName);
                    Delegates.AppendLine($"public {RGUtils.removeSystemType(p.ParameterType)} {ParamName};");
                }

                Delegates.AppendLine("}");
                Delegates.AppendLine($"public delegate void {name}_BeforeArgs(Params_{name} args);");
                Delegates.AppendLine($"public delegate {RGUtils.removeSystemType(method.ReturnType)} {name}_AfterArgs(Params_{name} args" +
                                     (noreturn ? "" : $", {RGUtils.removeSystemType(method.ReturnType)} ret")
                                     +");");
                Delegates.AppendLine($"public delegate {RGUtils.removeSystemType(method.ReturnType)} {name}_WithArgs ({NonGeneratedOrig} orig, {argsListWithType});");
                
            }
            else
            {
                Delegates.AppendLine($"public delegate void {name}_BeforeArgs();");
                Delegates.AppendLine($"public delegate {RGUtils.removeSystemType(method.ReturnType)} {name}_AfterArgs(" +
                                     (noreturn ? "" : $"{RGUtils.removeSystemType(method.ReturnType)} ret")
                                     +");");
                Delegates.AppendLine($"public delegate {RGUtils.removeSystemType(method.ReturnType)} {name}_WithArgs ({NonGeneratedOrig} orig);");

            }

            PopulateHookHandler(method: method);
            
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

        if (inModlog)
        {
            Modding.Logger.LogError("Starting On Hooks");
            Modding.Logger.Log(OnHooks);

            Modding.Logger.LogError("Starting IL Hooks");
            Modding.Logger.Log(ILHooks);
        }
        else
        {
            var onhookDir = Dir + "/OnHooks";
            if (!Directory.Exists(onhookDir))
            {
                Directory.CreateDirectory(onhookDir);
            }
            using(var output = new StreamWriter(Path.Combine(onhookDir, $"{ClassName}.cs")))
            {
                output.Write(OnHooks);
            }
            
            var ilHook = Dir + "/ILHooks";
            if (!Directory.Exists(ilHook))
            {
                Directory.CreateDirectory(ilHook);
            }
            using(var output = new StreamWriter(Path.Combine(ilHook, $"{ClassName}.cs")))
            {
                output.Write(ILHooks);
            }
        }
    }

    void PopulateBeforeOrig()
    {
        BeforeOrig.AppendLine($"public static event Delegates.{name}_BeforeArgs {name}");
        BeforeOrig.AppendLine("{\nadd\n{\n");
        BeforeOrig.AppendLine($"HookHandler._before{name} += value;");
        BeforeOrig.AppendLine($"HookHandler.Hook{name}();\n}}");
        BeforeOrig.AppendLine($"remove => HookHandler._before{name} -= value;\n}}");
    }
    void PopulateAfterOrig()
    {
        if (!isIEnumarator)
        {
            AfterOrig.AppendLine($"public static event Delegates.{name}_AfterArgs {name}");
            AfterOrig.AppendLine("{\nadd\n{\n");
            AfterOrig.AppendLine($"HookHandler._after{name} += value;");
            AfterOrig.AppendLine($"HookHandler.Hook{name}();\n}}");
            AfterOrig.AppendLine($"remove => HookHandler._after{name} -= value;\n}}");
        }
    }
    void PopulateWithOrig(MethodInfo method)
    {
        
        if (!isGeneratedByMonomod_On)
        {
            WithOrig.AppendLine($"public static event Delegates.{name}_WithArgs {name}\n{{");
           
            WithOrig.AppendLine($"add => HookEndpointManager.Add<Delegates.{name}_WithArgs>(ReflectionHelper.GetMethodInfo(typeof({ClassFullName}), \"{method.Name}\", {RGUtils.fixBoolName(!method.IsStatic)}), value);");
            WithOrig.AppendLine($"remove => HookEndpointManager.Remove<Delegates.{name}_WithArgs>(ReflectionHelper.GetMethodInfo(typeof({ClassFullName}), \"{method.Name}\", {RGUtils.fixBoolName(!method.IsStatic)}), value);\n}}");
        }
        else
        {
            WithOrig.AppendLine($"public static event On.{ClassName}.hook_{name} {name}\n{{");
            WithOrig.AppendLine($"add => On.{ClassName}.{name} += value;");
            WithOrig.AppendLine($"remove => On.{ClassName}.{name} -= value;\n}}");
        }
    }
    void PopulateILHooks(MethodInfo method)
    {
        ILHooks.AppendLine($"public static event ILContext.Manipulator {name}\n{{");
        if (isIEnumarator)
        {
            ILHooks.AppendLine($"add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof({ClassFullName}), \"{method.Name}\", {RGUtils.fixBoolName(!method.IsStatic)}).GetStateMachineTarget(), value);");
            ILHooks.AppendLine($"remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof({ClassFullName}), \"{method.Name}\", {RGUtils.fixBoolName(!method.IsStatic)}).GetStateMachineTarget(), value);\n}}");
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
                ILHooks.AppendLine($"add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof({ClassFullName}), \"{method.Name}\", {RGUtils.fixBoolName(!method.IsStatic)}), value);");
                ILHooks.AppendLine($"remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof({ClassFullName}), \"{method.Name}\", {RGUtils.fixBoolName(!method.IsStatic)}), value);\n}}");
            }
        }
    }

    private void GenerateArgsLists(MethodInfo method)
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
            if (param[i].IsOut && isGeneratedByMonomod_On)
            {
                argsListWithType.Append("out ");
                argsList.Append("out ");
            }
            else if (param[i].ParameterType.IsByRef && isGeneratedByMonomod_On)
            {
                argsListWithType.Append("ref ");
                argsList.Append("ref ");
            }

            var ParamName = param[i].Name;
            if (ParamName == "orig")
            {
                ParamName = "orig_";
            }
            
            argsListWithType.Append($" {RGUtils.removeSystemType(param[i].ParameterType)} {ParamName}");
            argsList.Append($"{ParamName}");
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

        if (NonGeneratedOrig.ToString() == "Action<>")
        {
            NonGeneratedOrig = new StringBuilder("Action");
        }
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
            HookHandler.AppendLine(
                $"new Hook(ReflectionHelper.GetMethodInfo(typeof({ClassFullName}), \"{name}\", {RGUtils.fixBoolName(!method.IsStatic)}), {name});");
        }

        HookHandler.AppendLine("\n}\n}");

        HookHandler.AppendLine($"internal static event Delegates.{name}_BeforeArgs _before{name};");
        if (!isIEnumarator) HookHandler.AppendLine($"internal static event Delegates.{name}_AfterArgs _after{name};");

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

        if (ParamsList.Count > 0)
        {
            HookHandler.AppendLine($"Delegates.Params_{name} @params = new() \n{{");
            for(int i = 0; i < ParamsList.Count; i++)
            {
                HookHandler.AppendLine($"{ParamsList[i]} = {ParamsList[i]}");
                if (i != ParamsList.Count - 1)
                {
                    HookHandler.Append(", ");
                }
            }
            HookHandler.AppendLine("};");
        }
        HookHandler.AppendLine($"if (_before{name} != null)\n{{");
        HookHandler.AppendLine($"foreach (Delegates.{name}_BeforeArgs toInvoke in _before{name}.GetInvocationList())\n{{");
        HookHandler.AppendLine("try\n{");
        HookHandler.AppendLine($"_before{name}?.Invoke(" 
                               + (ParamsList.Count == 0 ? "" : "@params") +
                               ");\n}");
        HookHandler.AppendLine("catch (Exception e) \n{ HKMirrorMod.DoLogError(e);\n}\n}\n}");
        
        foreach (var parameters in ParamsList)
        {
            HookHandler.AppendLine($"{parameters} = @params.{parameters};");
        }
        
        if (isIEnumarator)
        {
            HookHandler.AppendLine($"return orig({argsList});");
        }
        else 
        {
            HookHandler.AppendLine((noreturn ? "" : "var retVal = ") +  $"orig({argsList});");

            HookHandler.AppendLine($"if (_after{name} != null)\n{{");
            HookHandler.AppendLine($"foreach (Delegates.{name}_AfterArgs toInvoke in _after{name}.GetInvocationList())\n{{");
            HookHandler.AppendLine("try\n{");
            HookHandler.AppendLine((noreturn ? "" : "retVal = ") + 
                                   $"_after{name}.Invoke(" + 
                                   (ParamsList.Count == 0 ? "" : "@params") + 
                                   (noreturn ? "" : ", retVal") + 
                                   ");\n}");
            HookHandler.AppendLine("catch (Exception e) \n{ HKMirrorMod.DoLogError(e);\n}\n}\n}");
            if (!noreturn)
            {
                HookHandler.AppendLine("return retVal;");
            }
        }
        
        HookHandler.AppendLine("}");
    }
    
    private static void GenerateAllHookFiles()
    {
        var Dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/Hooks";

        if (!Directory.Exists(Dir))
        {
            Directory.CreateDirectory(Dir);
        }
        foreach (var type in typeof(HeroController).Assembly.GetTypes().Where(t => t.IsClass && !t.IsAbstract))
        {
            try
            {
                _ = new HookGenerator(type, type.Name, Dir, false);
            }
            catch (Exception e)
            {
                Modding.Logger.LogError($"Did not generate for {type} \n{e}");
            }
        }
    }
}