namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of GetAtan2FromVector3 allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GetAtan2FromVector3R : InstanceClassWrapper<GetAtan2FromVector3>
{
    public GetAtan2FromVector3R(GetAtan2FromVector3 _orig) : base(_orig)
    {
    }

    public FsmVector3 vector3
    {
        get => orig.vector3;
        set => orig.vector3 = value;
    }

    public FsmFloat angle
    {
        get => orig.angle;
        set => orig.angle = value;
    }

    public FsmBool RadToDeg
    {
        get => orig.RadToDeg;
        set => orig.RadToDeg = value;
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

    public void OnUpdate()
    {
        orig.OnUpdate();
    }

    public void DoATan()
    {
        CallMethod();
    }
}