namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of RectTransformGetLocalPosition allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RectTransformGetLocalPositionR : InstanceClassWrapper<RectTransformGetLocalPosition>
{
    public RectTransformGetLocalPositionR(RectTransformGetLocalPosition _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmVector3 position
    {
        get => orig.position;
        set => orig.position = value;
    }

    public FsmVector2 position2d
    {
        get => orig.position2d;
        set => orig.position2d = value;
    }

    public FsmFloat x
    {
        get => orig.x;
        set => orig.x = value;
    }

    public FsmFloat y
    {
        get => orig.y;
        set => orig.y = value;
    }

    public FsmFloat z
    {
        get => orig.z;
        set => orig.z = value;
    }

    public RectTransform _rt
    {
        get => GetField<RectTransform>();
        set => SetField(value);
    }

    public bool everyFrame
    {
        get => orig.everyFrame;
        set => orig.everyFrame = value;
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

    public void Reset()
    {
        orig.Reset();
    }

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public void OnActionUpdate()
    {
        orig.OnActionUpdate();
    }

    public void DoGetValues()
    {
        CallMethod();
    }
}