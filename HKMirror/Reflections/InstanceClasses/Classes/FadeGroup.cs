using TMPro;

namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of FadeGroup allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FadeGroupR : InstanceClassWrapper<FadeGroup>
{
    public FadeGroupR(FadeGroup _orig) : base(_orig)
    {
    }

    public SpriteRenderer[] spriteRenderers
    {
        get => orig.spriteRenderers;
        set => orig.spriteRenderers = value;
    }

    public TextMeshPro[] texts
    {
        get => orig.texts;
        set => orig.texts = value;
    }

    public InvAnimateUpAndDown[] animators
    {
        get => orig.animators;
        set => orig.animators = value;
    }

    public float fadeInTime
    {
        get => orig.fadeInTime;
        set => orig.fadeInTime = value;
    }

    public float fadeOutTime
    {
        get => orig.fadeOutTime;
        set => orig.fadeOutTime = value;
    }

    public float fadeOutTimeFast
    {
        get => orig.fadeOutTimeFast;
        set => orig.fadeOutTimeFast = value;
    }

    public float fullAlpha
    {
        get => orig.fullAlpha;
        set => orig.fullAlpha = value;
    }

    public float downAlpha
    {
        get => orig.downAlpha;
        set => orig.downAlpha = value;
    }

    public bool activateTexts
    {
        get => orig.activateTexts;
        set => orig.activateTexts = value;
    }

    public int state
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public float timer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public Color currentColour
    {
        get => GetField<Color>();
        set => SetField(value);
    }

    public Color fadeOutColour
    {
        get => GetField<Color>();
        set => SetField(value);
    }

    public Color fadeInColour
    {
        get => GetField<Color>();
        set => SetField(value);
    }

    public float currentAlpha
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool disableRenderersOnEnable
    {
        get => orig.disableRenderersOnEnable;
        set => orig.disableRenderersOnEnable = value;
    }


    public void OnEnable()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }

    public void FadeUp()
    {
        orig.FadeUp();
    }

    public void FadeDown()
    {
        orig.FadeDown();
    }

    public void FadeDownFast()
    {
        orig.FadeDownFast();
    }

    public void DisableRenderers()
    {
        CallMethod();
    }
}