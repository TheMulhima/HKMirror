namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of SpriteTweenColorNeutral allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SpriteTweenColorNeutralR : InstanceClassWrapper<SpriteTweenColorNeutral>
{
    public SpriteTweenColorNeutralR(SpriteTweenColorNeutral _orig) : base(_orig)
    {
    }

    public Color Color
    {
        get => GetField<Color>();
        set => SetField(value);
    }

    public float Duration
    {
        get => GetField<float>();
        set => SetField(value);
    }


    public void ColorReturnNeutral()
    {
        CallMethod();
    }

    public void updateSpriteColor(Color color)
    {
        CallMethod(new object[] { color });
    }

    public void onEnable()
    {
        CallMethod();
    }
}