using Modding.Delegates;

namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of LanguageGetProxy allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LanguageGetProxyR : InstanceClassWrapper<LanguageGetProxy>
{
    public LanguageGetProxyR(LanguageGetProxy _orig) : base(_orig)
    {
    }

    public bool HasSingleTarget => GetProperty<bool>();

    public MethodInfo Method => orig.Method;

    public object Target => orig.Target;

    public string EndInvoke(IAsyncResult result)
    {
        return orig.EndInvoke(result);
    }
}