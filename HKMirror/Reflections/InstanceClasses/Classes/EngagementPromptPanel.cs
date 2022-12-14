namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of EngagementPromptPanel allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class EngagementPromptPanelR : InstanceClassWrapper<EngagementPromptPanel>
{
    public EngagementPromptPanelR(EngagementPromptPanel _orig) : base(_orig)
    {
    }

    public CanvasGroup canvasGroup
    {
        get => GetField<CanvasGroup>();
        set => SetField(value);
    }

    public Animator flashAnimator
    {
        get => GetField<Animator>();
        set => SetField(value);
    }

    public float fadeRate
    {
        get => GetField<float>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }

    public void UpdateContent()
    {
        CallMethod();
    }
}