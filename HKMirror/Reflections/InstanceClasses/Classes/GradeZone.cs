namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of GradeZone allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GradeZoneR : InstanceClassWrapper<GradeZone>
{
    public GradeZoneR(GradeZone _orig) : base(_orig)
    {
    }


    public void Start()
    {
        CallMethod();
    }
}