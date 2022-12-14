namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of AreaBackground allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AreaBackgroundR : InstanceClassWrapper<AreaBackground>
{
    public AreaBackgroundR(AreaBackground _orig) : base(_orig)
    {
    }

    public MapZone areaName
    {
        get => orig.areaName;
        set => orig.areaName = value;
    }

    public Sprite backgroundImage
    {
        get => orig.backgroundImage;
        set => orig.backgroundImage = value;
    }
}