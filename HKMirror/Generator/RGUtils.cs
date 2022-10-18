using System.IO;
using System.Linq;

namespace HKMirror.Generator;

internal static class RGUtils
{
    public static string removeSystemType(Type type) => removeSystemType(type.ToString()); 
    public static string removeSystemType(string type)
    {
        type = type.Replace("+", ".");
        type = type.Replace("&", "");
        type = type.Replace("System.Int32", "int");
        type = type.Replace("System.Boolean", "bool");
        type = type.Replace("System.Single", "float");
        type = type.Replace("System.String", "string");
        type = type.Replace("System.Void", "void");

        type = type.CheckReplaceAndRemoveRb("System.Nullable`1[", "", '?');
        type = type.CheckReplaceAndRemoveRb("List`1[", "List<");
        type = type.CheckReplaceAndRemoveRb("HashSet`1[", "HashSet<");
        type = type.CheckReplaceAndRemoveRb("Tuple`1[", "Tuple<");
        type = type.CheckReplaceAndRemoveRb("Tuple`2[", "Tuple<");
        type = type.CheckReplaceAndRemoveRb("ICollection`1[", "ICollection<");
        type = type.CheckReplaceAndRemoveRb("Dictionary`2[", "Dictionary<");
        type = type.CheckReplaceAndRemoveRb("ReadOnlyCollection`1[", "ReadOnlyCollection<");
        type = type.CheckReplaceAndRemoveRb("TMP_XmlTagStack`1[", "TMP_XmlTagStack<");
        type = type.CheckReplaceAndRemoveRb("IEnumerable`1[", "IEnumerable<");
        type = type.CheckReplaceAndRemoveRb("Action`1[", "Action<");
        type = type.CheckReplaceAndRemoveRb("Action`2[", "Action<");
        type = type.CheckReplaceAndRemoveRb("Action`3[", "Action<");
        type = type.CheckReplaceAndRemoveRb("Action`4[", "Action<");
        type = type.CheckReplaceAndRemoveRb("Action`5[", "Action<");
        type = type.CheckReplaceAndRemoveRb("Func`1[", "Func<");
        type = type.CheckReplaceAndRemoveRb("Func`2[", "Func<");
        type = type.CheckReplaceAndRemoveRb("Func`3[", "Func<");
        type = type.CheckReplaceAndRemoveRb("Func`4[", "Func<");
        type = type.CheckReplaceAndRemoveRb("Func`5[", "Func<");

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

        if (type.Contains("[]"))
        {
            type = "Array";
        }
        else if (type.Contains("List`"))
        {
            type = "List";
        }
        else if (type.Contains("HashSet`"))
        {
            type = "HashSet";
        }
        else if (type.Contains("Tuple`"))
        {
            type = "Tuple";
        }
        else if (type.Contains("Dictionary`"))
        {
            type = "Dictionary";
        }
        else if (type.Contains("Action`"))
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
        else if (type.Contains("Func`"))
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
        else if (type.Contains("ReadOnlyCollection`"))
        {
            type = "ReadOnlyCollection";
        }
        else if (type.Contains("TMP_XmlTagStack`"))
        {
            type = "TMP_XmlTagStack";
        }

        return type;
    }

    public static bool ignoreMethod(string name)
    {
        List<string> toIgnore = new List<string> { "add_", "remove_", "get_", "set_", "GetHashCode", "ToString"};
        foreach (var ignore in toIgnore)
        {
            if (name.StartsWith(ignore)) return true;
        }

        if (name.StartsWith("<")) return true;

        if (name.Contains("BeginInvoke")) return true;

        return false;
    }
    
    public static bool ignoreMethodHook(string name)
    {
        List<string> toIgnore = new List<string> { "add_", "remove_"};
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

    public static string fixBoolName(Type param) => fixBoolName(param.ToString());
    public static string fixBoolName(bool param) => fixBoolName(param.ToString());
    public static string fixBoolName(string param)
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
        var overloads = methods.Where(x => x.Name == methodName);

        int count = overloads.Count();
        if (count == 1) return false;

        foreach (var m in overloads)
        {
            if (ignoreMethodHook(m.Name) || !m.ReturnType.IsPublic || m.IsGenericMethod)
            {
                count--;
            }
        }

        return count > 1;
    }

    public static string RemoveUnecessaryInName(string name)
    {
        name = name.Replace("Platform.IDisengageHandler.", ""); 
        name = name.Replace("IExternalDebris.", ""); 
        name = name.Replace("VibrationManager.IVibrationMixerProvider.", ""); 
        name = name.Replace("IExtraDamageable.RecieveExtraDamage", "RecieveExtraDamage"); 
        return name;
    }

    public static string CheckReplaceAndRemoveRb(this string str, string bad, string good, char replaceRbWith = '>')
    {
        if (!str.Contains(bad))
        {
            return str;
        }
        
        if (bad[bad.Length - 1] != '[')
        {
            throw new ArgumentException();
        }

        int startIndex = str.IndexOf(bad) + bad.Length;
        int lbCount = 1;
        
        for (int i = startIndex; i < str.Length; i++)
        {
            if (str[i] == '[')
            {
                lbCount++;
            }
            else if (str[i] == ']')
            {
                lbCount--;
                if (lbCount == 0)
                {
                    var array = str.ToCharArray();
                    array[i] = replaceRbWith;
                    str = new string(array).Replace(bad, good);
                }
            }
        }

        return str;
    }
    
}