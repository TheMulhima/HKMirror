using System.IO;

namespace HKMirror.Generator;

public static class ReflectedGeneratorUtils
{
    public static string removeSystemType(string type)
    {
        type = type.Replace("+", ".");
        type = type.Replace("&", "");
        type = type switch
        {
            "System.Int32" => "int",
            "System.Boolean" => "bool",
            "System.Single" => "float",
            "System.String" => "string",
            "System.Void" => "void",
            _ => type
        };

        if (type.Contains("System.Nullable`1["))
        {
            type = type.Replace("System.Nullable`1[", "").Replace("]", "?");
        }
        else if (type.Contains("List`1["))
        {
            type = type.Replace("List`1[", "List<").Replace("]", ">");
        }
        else if (type.Contains("HashSet`1["))
        {
            type = type.Replace("HashSet`1[", "List<").Replace("]", ">");
        }
        else if (type.Contains("Tuple`1["))
        {
            type = type.Replace("Tuple`1[", "List<").Replace("]", ">");
        }
        else if (type.Contains("Tuple`2["))
        {
            type = type.Replace("Tuple`2[", "List<").Replace("]", ">");
        }
        else if (type.Contains("Dictionary<"))
        {
            type = type.Replace("Dictionary<", "Dictionary<").Replace("]", ">");
        }
        else if (type.Contains("Action`1["))
        {
            type = type.Replace("Action`1[", "Action<").Replace("]", ">");
            ;
        }
        else if (type.Contains("Action`2["))
        {
            type = type.Replace("Action`2[", "Action<").Replace("]", ">");
            ;
        }
        else if (type.Contains("Action`3["))
        {
            type = type.Replace("Action`3[", "Action<").Replace("]", ">");
            ;
        }
        else if (type.Contains("Action`4["))
        {
            type = type.Replace("Action`4[", "Action<").Replace("]", ">");
            ;
        }
        else if (type.Contains("Action`5["))
        {
            type = type.Replace("Action`5[", "Action<").Replace("]", ">");
            ;
        }
        else if (type.Contains("Func`1["))
        {
            type = type.Replace("Func`1[", "Func<").Replace("]", ">");
            ;
        }
        else if (type.Contains("Func`2["))
        {
            type = type.Replace("Func`2[", "Func<").Replace("]", ">");
            ;
        }
        else if (type.Contains("Func`3["))
        {
            type = type.Replace("Func`3[", "Func<").Replace("]", ">");
            ;
        }
        else if (type.Contains("Func`4["))
        {
            type = type.Replace("Func`4[", "Func<").Replace("]", ">");
            ;
        }
        else if (type.Contains("Func`5["))
        {
            type = type.Replace("Func`5[", "Func<").Replace("]", ">");
            ;
        }
        else if (type.Contains("ReadOnlyCollection`1["))
        {
            type = type.Replace("ReadOnlyCollection`1[", "ReadOnlyCollection<").Replace("]", ">");
            ;
        }
        else if (type.Contains("TMP_XmlTagStack`1["))
        {
            type = type.Replace("TMP_XmlTagStack`1[", "TMP_XmlTagStack<").Replace("]", ">");
            ;
        }

        return type;
    }

    public static bool ignoreMethod(string name)
    {
        List<string> toIgnore = new List<string> { "add_", "remove_", "get_", "set_" };
        foreach (var ignore in toIgnore)
        {
            if (name.StartsWith(ignore)) return true;
        }

        if (name.StartsWith("<")) return true;

        if (name.Contains("BeginInvoke")) return true;

        return false;
    }

    public static bool ignoreField(string name)
    {
        if (name.Contains("k__BackingField")) return true;
        return false;
    }

    public static string replaceDefaultParams(string param)
    {
        return param switch
        {
            "True" => "true",
            "False" => "false",
            _ => param,
        };
    }

    public static void Output(object line, bool InModlog = true, StreamWriter output = null)
    {
        if (InModlog)
        {
            Modding.Logger.Log(line);
        }
        else
        {
            output.WriteLine(line);
        }
    }
}