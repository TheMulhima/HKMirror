using TMPro;

namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of Compute_DT_EventArgs allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class Compute_DT_EventArgsR : InstanceClassWrapper<Compute_DT_EventArgs>
{
    public Compute_DT_EventArgsR(Compute_DT_EventArgs _orig) : base(_orig)
    {
    }

    public Compute_DistanceTransform_EventTypes EventType
    {
        get => orig.EventType;
        set => orig.EventType = value;
    }

    public float ProgressPercentage
    {
        get => orig.ProgressPercentage;
        set => orig.ProgressPercentage = value;
    }

    public Color[] Colors
    {
        get => orig.Colors;
        set => orig.Colors = value;
    }
}