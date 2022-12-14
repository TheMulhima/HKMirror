namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of OnScreenDebugInfo allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class OnScreenDebugInfoR : InstanceClassWrapper<OnScreenDebugInfo>
{
    public OnScreenDebugInfoR(OnScreenDebugInfo _orig) : base(_orig)
    {
    }

    public GameManager gm
    {
        get => GetField<GameManager>();
        set => SetField(value);
    }

    public InputHandler ih
    {
        get => GetField<InputHandler>();
        set => SetField(value);
    }

    public float unloadTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float loadTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float frameRate
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public string fps
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public string infoString
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public string versionNumber
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public float textWidth
    {
        get => GetFieldStatic<float>();
        set => SetField(value);
    }

    public Rect loadProfilerRect
    {
        get => GetField<Rect>();
        set => SetField(value);
    }

    public Rect fpsRect
    {
        get => GetField<Rect>();
        set => SetField(value);
    }

    public Rect infoRect
    {
        get => GetField<Rect>();
        set => SetField(value);
    }

    public Rect inputRect
    {
        get => GetField<Rect>();
        set => SetField(value);
    }

    public Rect tfrRect
    {
        get => GetField<Rect>();
        set => SetField(value);
    }

    public bool showFPS
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool showInfo
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool showInput
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool showLoadingTime
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool showTFR
    {
        get => GetField<bool>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public IEnumerator Start()
    {
        return CallMethod<IEnumerator>();
    }

    public void LevelActivated(Scene sceneFrom, Scene sceneTo)
    {
        CallMethod(new object[] { sceneFrom, sceneTo });
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public void OnGUI()
    {
        CallMethod();
    }

    public void ShowFPS()
    {
        orig.ShowFPS();
    }

    public void ShowGameInfo()
    {
        orig.ShowGameInfo();
    }

    public void ShowInput()
    {
        orig.ShowInput();
    }

    public void ShowLoadingTime()
    {
        orig.ShowLoadingTime();
    }

    public void ShowTargetFrameRate()
    {
        orig.ShowTargetFrameRate();
    }

    public void OnLevelUnload()
    {
        CallMethod();
    }

    public void RetrieveInfo()
    {
        CallMethod();
    }

    public string ReadInput()
    {
        return CallMethod<string>();
    }

    public void orig_Awake()
    {
        CallMethod();
    }
}