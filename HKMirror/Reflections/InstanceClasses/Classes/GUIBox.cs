namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of GUIBox allowing you to easily get/set fields
///     and call methods without dealing with reflection.
/// </summary>
public class GUIBoxR : InstanceClassWrapper<GUIBox>
{
    public GUIBoxR(GUIBox _orig) : base(_orig)
    {
    }

    public FsmTexture image
    {
        get => orig.image;
        set => orig.image = value;
    }

    public FsmString text
    {
        get => orig.text;
        set => orig.text = value;
    }

    public FsmString tooltip
    {
        get => orig.tooltip;
        set => orig.tooltip = value;
    }

    public FsmString style
    {
        get => orig.style;
        set => orig.style = value;
    }

    public GUIContent content
    {
        get => GetField<GUIContent>();
        set => SetField(value);
    }

    public FsmRect screenRect
    {
        get => orig.screenRect;
        set => orig.screenRect = value;
    }

    public FsmFloat left
    {
        get => orig.left;
        set => orig.left = value;
    }

    public FsmFloat top
    {
        get => orig.top;
        set => orig.top = value;
    }

    public FsmFloat width
    {
        get => orig.width;
        set => orig.width = value;
    }

    public FsmFloat height
    {
        get => orig.height;
        set => orig.height = value;
    }

    public FsmBool normalized
    {
        get => orig.normalized;
        set => orig.normalized = value;
    }

    public Rect rect
    {
        get => GetField<Rect>();
        set => SetField(value);
    }

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

    public void OnGUI()
    {
        orig.OnGUI();
    }
}