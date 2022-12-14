namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of GUILayoutBeginScrollView allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GUILayoutBeginScrollViewR : InstanceClassWrapper<GUILayoutBeginScrollView>
{
    public GUILayoutBeginScrollViewR(GUILayoutBeginScrollView _orig) : base(_orig)
    {
    }

    public FsmVector2 scrollPosition
    {
        get => orig.scrollPosition;
        set => orig.scrollPosition = value;
    }

    public FsmBool horizontalScrollbar
    {
        get => orig.horizontalScrollbar;
        set => orig.horizontalScrollbar = value;
    }

    public FsmBool verticalScrollbar
    {
        get => orig.verticalScrollbar;
        set => orig.verticalScrollbar = value;
    }

    public FsmBool useCustomStyle
    {
        get => orig.useCustomStyle;
        set => orig.useCustomStyle = value;
    }

    public FsmString horizontalStyle
    {
        get => orig.horizontalStyle;
        set => orig.horizontalStyle = value;
    }

    public FsmString verticalStyle
    {
        get => orig.verticalStyle;
        set => orig.verticalStyle = value;
    }

    public FsmString backgroundStyle
    {
        get => orig.backgroundStyle;
        set => orig.backgroundStyle = value;
    }

    public LayoutOption[] layoutOptions
    {
        get => orig.layoutOptions;
        set => orig.layoutOptions = value;
    }

    public GUILayoutOption[] LayoutOptions => orig.LayoutOptions;

    public string Name
    {
        get => orig.Name;
        set => orig.Name = value;
    }

    public string DisplayName
    {
        get => orig.DisplayName;
        set => orig.DisplayName = value;
    }

    public Fsm Fsm
    {
        get => orig.Fsm;
        set => orig.Fsm = value;
    }

    public GameObject Owner
    {
        get => orig.Owner;
        set => orig.Owner = value;
    }

    public FsmState State
    {
        get => orig.State;
        set => orig.State = value;
    }

    public bool Enabled
    {
        get => orig.Enabled;
        set => orig.Enabled = value;
    }

    public bool IsOpen
    {
        get => orig.IsOpen;
        set => orig.IsOpen = value;
    }

    public bool IsAutoNamed
    {
        get => orig.IsAutoNamed;
        set => orig.IsAutoNamed = value;
    }

    public bool Entered
    {
        get => orig.Entered;
        set => orig.Entered = value;
    }

    public bool Finished
    {
        get => orig.Finished;
        set => orig.Finished = value;
    }

    public bool Active
    {
        get => orig.Active;
        set => orig.Active = value;
    }

    public void Reset()
    {
        orig.Reset();
    }

    public void OnGUI()
    {
        orig.OnGUI();
    }
}