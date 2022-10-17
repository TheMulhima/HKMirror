using System.IO;
using System.Linq;

namespace HKMirror.Generator;

public static class RGUtils
{
    public static string removeSystemType(string type)
    {
        type = type.Replace("+", ".");
        type = type.Replace("&", "");
        type = type.Replace("System.Int32", "int");
        type = type.Replace("System.Boolean", "bool");
        type = type.Replace("System.Single", "float");
        type = type.Replace("System.String", "string");
        type = type.Replace("System.Void", "void");

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
            type = type.Replace("HashSet`1[", "HashSet<").Replace("]", ">");
        }
        else if (type.Contains("Tuple`1["))
        {
            type = type.Replace("Tuple`1[", "Tuple<").Replace("]", ">");
        }
        else if (type.Contains("Tuple`2["))
        {
            type = type.Replace("Tuple`2[", "Tuple<").Replace("]", ">");
        }
        else if (type.Contains("Dictionary<"))
        {
            type = type.Replace("Dictionary<", "Dictionary<").Replace("]", ">");
        }
        else if (type.Contains("Action`1["))
        {
            type = type.Replace("Action`1[", "Action<").Replace("]", ">");
        }
        else if (type.Contains("Action`2["))
        {
            type = type.Replace("Action`2[", "Action<").Replace("]", ">");
        }
        else if (type.Contains("Action`3["))
        {
            type = type.Replace("Action`3[", "Action<").Replace("]", ">");
        }
        else if (type.Contains("Action`4["))
        {
            type = type.Replace("Action`4[", "Action<").Replace("]", ">");
        }
        else if (type.Contains("Action`5["))
        {
            type = type.Replace("Action`5[", "Action<").Replace("]", ">");
        }
        else if (type.Contains("Func`1["))
        {
            type = type.Replace("Func`1[", "Func<").Replace("]", ">");
        }
        else if (type.Contains("Func`2["))
        {
            type = type.Replace("Func`2[", "Func<").Replace("]", ">");
        }
        else if (type.Contains("Func`3["))
        {
            type = type.Replace("Func`3[", "Func<").Replace("]", ">");
        }
        else if (type.Contains("Func`4["))
        {
            type = type.Replace("Func`4[", "Func<").Replace("]", ">");
        }
        else if (type.Contains("Func`5["))
        {
            type = type.Replace("Func`5[", "Func<").Replace("]", ">");
        }
        else if (type.Contains("ReadOnlyCollection`1["))
        {
            type = type.Replace("ReadOnlyCollection`1[", "ReadOnlyCollection<").Replace("]", ">");
        }
        else if (type.Contains("TMP_XmlTagStack`1["))
        {
            type = type.Replace("TMP_XmlTagStack`1[", "TMP_XmlTagStack<").Replace("]", ">");
        }

        return type;
    }

    public static string GetParameterTypeName(Type parameterType)
    {
        string type = parameterType.ToString();

        type = type.Replace("+", ".");
        type = type.Replace("&", "");
        type = type.Replace("System.Int32", "int");
        type = type.Replace("System.Boolean", "bool");
        type = type.Replace("System.Single", "float");
        type = type.Replace("System.String", "string");
        type = type.Replace("System.Void", "void");
        
        //remove any namespace stuff
        var subs = type.Split('.');
        type = subs[subs.Length - 1];

        if (type.Contains("System.Nullable`1["))
        {
            type = type.Replace("System.Nullable`1[", "").Replace("]", "?");
        }
        else if (type.Contains("List`1["))
        {
            type = "List";
        }
        else if (type.Contains("HashSet"))
        {
            type = "HashSet";
        }
        else if (type.Contains("Tuple"))
        {
            type = "Tuple";
        }
        else if (type.Contains("Dictionary"))
        {
            type = "Dictionary";
        }
        else if (type.Contains("Action"))
        {
            type = type switch
            {
                "Action`1" => "Action1",
                "Action`2" => "Action2",
                "Action`3" => "Action3",
                "Action`4" => "Action4",
                "Action`5" => "Action5",
                "Action`6" => "Action6",
                _ => "Action"
            };
        }
        else if (type.Contains("Func"))
        {
            type = type switch
            {
                "Func`1" => "Func1",
                "Func`2" => "Func2",
                "Func`3" => "Func3",
                "Func`4" => "Func4",
                "Func`5" => "Func5",
                "Func`6" => "Func6",
                _ => "Func",
            };
        }
        else if (type.Contains("ReadOnlyCollection"))
        {
            type = "ReadOnlyCollection";
        }
        else if (type.Contains("TMP_XmlTagStack"))
        {
            type = "TMP_XmlTagStack";
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

    public static bool isOverloaded(MethodInfo[] methods, string methodName)
    {
        return methods.Count(x => x.Name == methodName) > 1;
    }
}