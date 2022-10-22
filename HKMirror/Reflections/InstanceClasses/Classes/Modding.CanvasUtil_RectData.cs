namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of Modding.CanvasUtil_RectData allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class Modding_CanvasUtil_RectDataR : InstanceClassWrapper<CanvasUtil.RectData>
{
    public Modding_CanvasUtil_RectDataR(CanvasUtil.RectData _orig) : base(_orig)
    {
    }

    public Vector2 AnchorMax
    {
        get => orig.AnchorMax;
        set => orig.AnchorMax = value;
    }

    public Vector2 AnchorMin
    {
        get => orig.AnchorMin;
        set => orig.AnchorMin = value;
    }

    public Vector2 AnchorPivot
    {
        get => orig.AnchorPivot;
        set => orig.AnchorPivot = value;
    }

    public Vector2 AnchorPosition
    {
        get => orig.AnchorPosition;
        set => orig.AnchorPosition = value;
    }

    public Vector2 RectSizeDelta
    {
        get => orig.RectSizeDelta;
        set => orig.RectSizeDelta = value;
    }
}