namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of RectTransformWorldToScreenPoint allowing you
///     to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RectTransformWorldToScreenPointR : InstanceClassWrapper<RectTransformWorldToScreenPoint>
{
    public RectTransformWorldToScreenPointR(RectTransformWorldToScreenPoint _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmOwnerDefault camera
    {
        get => orig.camera;
        set => orig.camera = value;
    }

    public FsmVector3 screenPoint
    {
        get => orig.screenPoint;
        set => orig.screenPoint = value;
    }

    public FsmFloat screenX
    {
        get => orig.screenX;
        set => orig.screenX = value;
    }

    public FsmFloat screenY
    {
        get => orig.screenY;
        set => orig.screenY = value;
    }

    public FsmBool normalize
    {
        get => orig.normalize;
        set => orig.normalize = value;
    }

    public RectTransform _rt
    {
        get => GetField<RectTransform>();
        set => SetField(value);
    }

    public Camera _cam
    {
        get => GetField<Camera>();
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

    public void DoWorldToScreenPoint()
    {
        CallMethod();
    }
}