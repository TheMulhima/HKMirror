using System.IO;
using System.Linq;
using System.Text;

namespace HKMirror.Generator;

/// <summary>
/// Here you can find the code used to generate the files for Instance Classes
/// </summary>
internal static class InstanceClassReflectedGenerator
{
    /// <summary>
    /// Create reflected output for an instance class
    /// </summary>
    /// <param name="TargetType">the target type</param>
    /// <param name="ClassName">the target class name</param>
    /// <param name="InModlog">decides where to output it to. if false, make sure to set output var in this class</param>
    public static void CreateForInstanceClass(Type TargetType, string ClassName, bool InModlog = true)
    {
        if (!TargetType.IsPublic) return;
        string fullName = TargetType.ToString().Replace("+", ".");
        RGUtils.Output("namespace HKMirror.Reflection.InstanceClasses", InModlog, output);
        RGUtils.Output("{", InModlog, output);
        RGUtils.Output("/// <summary>", InModlog, output);
        RGUtils.Output(
            $"///     A class that contains all (public and private) fields and methods of {ClassName} allowing you to", InModlog, output);
        RGUtils.Output("///     easily get/set fields and call methods without dealing with reflection.", InModlog, output);
        RGUtils.Output("/// </summary>", InModlog, output);
        RGUtils.Output($"public class {ClassName}R:InstanceClassWrapper<{fullName}>", InModlog, output);
        RGUtils.Output("{", InModlog, output);
        RGUtils.Output($"public {ClassName}R({fullName} _orig) : base(_orig) " + @"{}", InModlog, output);

        var fields =
            TargetType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance |
                                 BindingFlags.Static);
        foreach (var field in fields)
        {
            if (RGUtils.ignoreField(field.Name)) continue;
            if (!field.FieldType.IsPublic) continue;
            string fieldType = RGUtils.removeSystemType(field.FieldType.ToString());
            StringBuilder fieldString = new StringBuilder();
            fieldString.AppendLine($"public {fieldType} {field.Name}");
            fieldString.AppendLine("{");
            if (field.IsPublic)
            {
                if (!field.IsStatic)
                {
                    fieldString.AppendLine($"get => orig.{field.Name};");
                    if (!field.IsInitOnly)
                    {
                        fieldString.AppendLine($"set => orig.{field.Name} = value;");
                    }
                    else
                    {
                        fieldString.AppendLine($"set => SetField(value);");
                    }
                }
                else
                {
                    fieldString.AppendLine($"get => {fullName}.{field.Name};");
                    if (!field.IsInitOnly)
                    {
                        fieldString.AppendLine($"set => {fullName}.{field.Name} = value;");
                    }
                    else
                    {
                        fieldString.AppendLine($"set => SetField(value);");
                    }
                }
            }
            else
            {
                fieldString.AppendLine(
                    $"get => GetField" + (field.IsStatic ? "Static" : "") + $"<{fieldType}>();");
                fieldString.AppendLine($"set => SetField(value);");
            }

            fieldString.AppendLine("}");
            RGUtils.Output(fieldString, InModlog, output);
        }

        var properties =
            TargetType.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance |
                                     BindingFlags.Static);
        foreach (var property in properties)
        {
            if (!property.GetMethod.ReturnType.IsPublic) continue;
            string propertyType = RGUtils.removeSystemType(property.PropertyType.ToString());
            StringBuilder propertyString = new StringBuilder();
            propertyString.AppendLine($"public {propertyType} {property.Name}");
            propertyString.AppendLine("{");
            if (property.CanRead)
            {
                if (property.GetMethod.IsPublic)
                {
                    if (!property.GetMethod.IsStatic)
                    {
                        propertyString.AppendLine($"get => orig.{property.Name};");
                    }
                    else
                    {
                        propertyString.AppendLine($"get => {fullName}.{property.Name};");
                    }
                }
                else
                {
                    propertyString.AppendLine(
                        $"get => GetProperty" + (property.GetMethod.IsStatic ? "Static" : "") +
                        $"<{propertyType}>();");
                }
            }

            if (property.CanWrite)
            {
                if (property.SetMethod.IsPublic)
                {
                    if (!property.SetMethod.IsStatic)
                    {
                        propertyString.AppendLine($"set => orig.{property.Name} = value;");
                    }
                    else
                    {
                        propertyString.AppendLine($"set => {fullName}.{property.Name} = value;");
                    }
                }
                else
                {
                    propertyString.AppendLine(
                        $"set => SetProperty" + (property.SetMethod.IsStatic ? "Static" : "") + "(value);");
                }
            }

            propertyString.AppendLine("}");
            RGUtils.Output(propertyString, InModlog, output);
        }

        var methods =
            TargetType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance |
                                  BindingFlags.Static |
                                  BindingFlags.DeclaredOnly);
        foreach (var method in methods)
        {
            if (RGUtils.ignoreMethod(method.Name)) continue;
            if (!method.ReturnType.IsPublic) continue;
            bool ToSkip = false;
            string reason = String.Empty;

            foreach (var p in method.GetParameters())
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
            }

            if (ToSkip)
            {
                Modding.Logger.LogError($"{ClassName}.{method.Name} params didnt make the cut cuz {reason}");
                continue;
            }

            bool noreturn = false;
            
            string name =  RGUtils.RemoveUnecessaryInName(method.Name);

            var parameters = method.GetParameters();
            StringBuilder paramsInputString = new StringBuilder();
            StringBuilder paramsOutputString = new StringBuilder();
            if (parameters.Length == 0)
            {
                paramsInputString.Append("()");
                paramsOutputString.Append("");
            }
            else
            {
                paramsInputString.Append("(");
                if (!method.IsPublic) paramsOutputString.Append("new object[] {");
                foreach (var param in parameters)
                {
                    paramsOutputString.Append($"{param.Name}");

                    paramsInputString.Append($"{RGUtils.removeSystemType(param.ParameterType.ToString())} {param.Name}");
                    if (param.HasDefaultValue)
                    {
                        paramsInputString.Append(param.DefaultValue == null
                            ? " = null"
                            : $" = {RGUtils.fixBoolName(Convert.ChangeType(param.DefaultValue, param.ParameterType).ToString())}");
                    }

                    if (parameters.ToList().IndexOf(param) != parameters.Length - 1)
                    {
                        paramsInputString.Append(", ");
                        paramsOutputString.Append(", ");
                    }
                }

                paramsInputString.Append(")");
                if (!method.IsPublic) paramsOutputString.Append("}");
            }

            if (method.ReturnType.ToString() == "System.Void") noreturn = true;

            StringBuilder methodString = new StringBuilder();
            methodString.AppendLine(
                $"public {RGUtils.removeSystemType(method.ReturnType.ToString())} {name} {paramsInputString} =>");

            if (method.IsPublic)
            {
                if (!method.IsStatic)
                {
                    if (!method.IsGenericMethod)
                    {
                        methodString.AppendLine($"orig.{name}({paramsOutputString});");
                    }
                    else
                    {
                        methodString.AppendLine($"orig.{name}<T>({paramsOutputString});");
                    }
                }
                else
                {
                    if (!method.IsGenericMethod)
                    {
                        methodString.AppendLine($"{fullName}.{name}({paramsOutputString});");
                    }
                    else
                    {
                        methodString.AppendLine($"{fullName}.{name}<T>({paramsOutputString});");
                    }
                }
            }
            else
            {
                methodString.AppendLine(noreturn
                    ? $"CallMethod" + (method.IsStatic ? "Static" : "") + $"({paramsOutputString});"
                    : $"CallMethod" + (method.IsStatic ? "Static" : "") +
                      $"<{RGUtils.removeSystemType(method.ReturnType.ToString())}>({paramsOutputString});");
            }

            RGUtils.Output(methodString, InModlog, output);
        }

        RGUtils.Output("}\n}", InModlog, output);
    }
    
    /// <summary>
    /// create files for all classes in assembly c-sharp
    /// </summary>
    /// <param name="Dir">The place where to output the file</param>
    public static void CreateReflectedFilesForAssembly(string Dir)
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
    }

    public static StreamWriter output = null;
}