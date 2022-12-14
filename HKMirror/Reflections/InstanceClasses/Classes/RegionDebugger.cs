namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of RegionDebugger allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RegionDebuggerR : InstanceClassWrapper<RegionDebugger>
{
    public RegionDebuggerR(RegionDebugger _orig) : base(_orig)
    {
    }


    public void Start()
    {
        CallMethod();
    }
}