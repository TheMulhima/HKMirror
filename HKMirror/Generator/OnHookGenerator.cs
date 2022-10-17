using System.IO;
using System.Linq;
using System.Text;

namespace HKMirror.Generator;

/// <summary>
/// Here you can find the code used to generate the files for Instance Classes
/// </summary>
public static class OnHookGenerator
{
    /// <summary>
    /// Create reflected output for an instance class
    /// </summary>
    /// <param name="TargetType">the target type</param>
    /// <param name="ClassName">the target class name</param>
    /// <param name="InModlog">decides where to output it to. if false, make sure to set output var in this class</param>
    public static void CreateForInstanceClass(Type TargetType, string ClassName, Type OnType, bool InModlog = true)
    {
        if (!TargetType.IsPublic) return;
        string ClassFullName = TargetType.ToString().Replace("+", ".");
        DoOutput("using MonoMod.RuntimeDetour;");
        DoOutput("namespace HKMirror.OnHooks;");
        DoOutput($"public static class On{ClassName}");
        DoOutput("{");
        DoOutput("private static List<string> HookedList = new List<string>();");


        var OnEvents = OnType.GetEvents().Select(x => x.Name);

        var AllAvailableMethods = TargetType.GetMethods(Flags);
        foreach (var method in AllAvailableMethods)
        {
            if (RGUtils.ignoreMethod(method.Name)) continue;
            if (!method.ReturnType.IsPublic) continue;
            if (method.IsGenericMethod) continue;

            bool noreturn = method.ReturnType.ToString() == "System.Void";
            bool isIEnumarator = method.ReturnType == typeof(IEnumerator);
            bool isOverload = RGUtils.isOverloaded(AllAvailableMethods, method.Name);
            string name = method.Name;
            
            StringBuilder argsListWithType = new ();
            StringBuilder argsList = new();
            StringBuilder NonGeneratedOrig = new();

            if (!noreturn)
            {
                NonGeneratedOrig.Append("Func<");
            }
            else
            {
                NonGeneratedOrig.Append("Action<");
            }

            var param = method.GetParameters();

            if (isOverload)
            {
                foreach (var p in param)
                {
                    name += $"_{RGUtils.GetParameterTypeName(p.ParameterType)}";
                }
            }
            
            bool isGeneratedByMonomod = OnEvents.Contains(name);
            
            
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
            for(int i = 0; i < param.Length; i++)
            {
                if (param[i].ParameterType.IsByRef)
                {
                    argsListWithType.Append("ref ");
                    argsList.Append("ref ");
                }
                argsListWithType.Append($" {RGUtils.removeSystemType(param[i].ParameterType.ToString())} {param[i].Name}");
                argsList.Append($"{param[i].Name}");
                NonGeneratedOrig.Append($" {RGUtils.removeSystemType(param[i].ParameterType.ToString())}");
                if (i != param.Length - 1)
                {
                    argsListWithType.Append(", ");
                    argsList.Append(", ");
                    NonGeneratedOrig.Append(", ");
                }
            }

            if (!noreturn)
            {
                NonGeneratedOrig.Append($", {RGUtils.removeSystemType(method.ReturnType.ToString())}>");
            }
            else
            {
                NonGeneratedOrig.Append(">");
            }
            
            DoOutput($"public delegate void {name}_args({argsListWithType});");
            DoOutput($"private static event {name}_args _before{name};");
            if (!isIEnumarator) DoOutput($"private static event {name}_args _after{name};");

            DoOutput($"private static void Hook{name}()");
            DoOutput("{\n");
            DoOutput($"if (!HookedList.Contains(\"{name}\"))");
            DoOutput("{\n");
            DoOutput($"HookedList.Add(\"{name}\");");
            if (isGeneratedByMonomod)
            {
                DoOutput($"On.{ClassName}.{name} += {name};");
            }
            else
            {
               DoOutput($"new Hook(ReflectionHelper.GetMethodInfo(typeof({ClassFullName}), \"{method.Name}\", {RGUtils.replaceDefaultParams((!method.IsStatic).ToString())}), {method.Name});"); 
            }
            DoOutput("\n}\n}");

            if (isGeneratedByMonomod)
            {
                DoOutput($"private static {RGUtils.removeSystemType(method.ReturnType.ToString())} {name}(On.{ClassName}.orig_{name} orig,{argsListWithType})");
            }
            else
            {
                DoOutput($"private static {RGUtils.removeSystemType(method.ReturnType.ToString())} {method.Name}({NonGeneratedOrig} orig, {argsListWithType})");
            }
            DoOutput("{");
            DoOutput($"_before{name}?.Invoke({argsList});");
            if (isIEnumarator)
            {
                DoOutput($"return orig({argsList});");
            }
            else 
            {
                if (noreturn)
                {
                    DoOutput($"orig({argsList});");
                }
                else
                {
                    DoOutput($"var retVal = orig({argsList});");
                }

                DoOutput($"_after{name}?.Invoke({argsList});");
                if (!noreturn)
                {
                    DoOutput("return retVal;");
                }
            }

            DoOutput("}");

            DoOutput($"public static event {name}_args Before_{name}");
            DoOutput("{\nadd\n{\n");
            DoOutput($"_before{name} += value;");
            DoOutput($"Hook{name}();");
            DoOutput("}");
            DoOutput($"remove => _before{name} -= value;");
            DoOutput("}");

            if (!isIEnumarator)
            {
                DoOutput($"public static event {name}_args After_{name}");
                DoOutput("{\nadd\n{\n");
                DoOutput($"_after{name} += value;");
                DoOutput($"Hook{name}();");
                DoOutput("}");
                DoOutput($"remove => _after{name} -= value;");
                DoOutput("}");
            }
        }

        RGUtils.Output("}", InModlog, output);

        void DoOutput(object str)
        {
            RGUtils.Output(str, InModlog, output);
        }
    }
    
    /// <summary>
    /// create files for all classes in assembly c-sharp
    /// </summary>
    /// <param name="Dir">The place where to output the file</param>
    /*public static void CreateReflectedFilesForAssembly(string Dir)
    {
        Directory.CreateDirectory(Dir);

        foreach (var type in typeof(HeroController).Assembly.GetTypes().Where(t => t.IsClass && !t.IsAbstract))
        {
            try
            {
                output = new StreamWriter(Path.Combine(Dir, $"{type.Name}.txt"));
                CreateForInstanceClass(type, type.Name, true);
                output.Close();
            }
            catch { }

        }
    }*/

    public static StreamWriter output = null;

    public static BindingFlags Flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance |
                                       BindingFlags.Static | BindingFlags.DeclaredOnly;
    
    /*
     * private static void Hookorig_Update()
    {
        if (!HookedList.Contains("orig_Update"))
        {
            HookedList.Add("orig_Update");
            new Hook(ReflectionHelper.GetMethodInfo(typeof(HeroController), "orig_Update", true), orig_Update);
        }
    }

    private static void orig_Update(Action<HeroController> orig, HeroController self)
    {
        _beforeAwake?.Invoke(self);
        orig(self);
        _afterAwake?.Invoke(self);
    }
     */

}