using Modding.Delegates;

namespace HKMirror.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of SetIntProxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetIntProxyR : InstanceClassWrapper<SetIntProxy>
{
    public SetIntProxyR(SetIntProxy _orig) : base(_orig)
    {
    }

    public bool HasSingleTarget => GetProperty<bool>();

    public MethodInfo Method => orig.Method;

    public object Target => orig.Target;

    public int EndInvoke(IAsyncResult result)
    {
        return orig.EndInvoke(result);
    }
}