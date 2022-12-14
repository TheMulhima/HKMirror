namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of ProgressSaveMessagePanel allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ProgressSaveMessagePanelR : InstanceClassWrapper<ProgressSaveMessagePanel>
{
    public ProgressSaveMessagePanelR(ProgressSaveMessagePanel _orig) : base(_orig)
    {
    }

    public CanvasGroup canvasGroup
    {
        get => GetField<CanvasGroup>();
        set => SetField(value);
    }


    public void OnEnable()
    {
        CallMethod();
    }
}