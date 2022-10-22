namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of MenuStyles_MenuStyle_CameraCurves allowing you
///     to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuStyles_MenuStyle_CameraCurvesR : InstanceClassWrapper<MenuStyles.MenuStyle.CameraCurves>
{
    public MenuStyles_MenuStyle_CameraCurvesR(MenuStyles.MenuStyle.CameraCurves _orig) : base(_orig)
    {
    }

    public float saturation
    {
        get => orig.saturation;
        set => orig.saturation = value;
    }

    public AnimationCurve redChannel
    {
        get => orig.redChannel;
        set => orig.redChannel = value;
    }

    public AnimationCurve greenChannel
    {
        get => orig.greenChannel;
        set => orig.greenChannel = value;
    }

    public AnimationCurve blueChannel
    {
        get => orig.blueChannel;
        set => orig.blueChannel = value;
    }
}