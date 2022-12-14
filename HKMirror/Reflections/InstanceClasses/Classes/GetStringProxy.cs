using Modding.Delegates;

namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of GetStringProxy allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetStringProxyR : InstanceClassWrapper<GetStringProxy>
{
    public GetStringProxyR(GetStringProxy _orig) : base(_orig)
    {
    }

    public bool HasSingleTarget => GetProperty<bool>();

    public MethodInfo Method => orig.Method;

    public object Target => orig.Target;

    public string Invoke(string name, string res)
    {
        return orig.Invoke(name, res);
    }

    public string EndInvoke(IAsyncResult result)
    {
        return orig.EndInvoke(result);
    }
}