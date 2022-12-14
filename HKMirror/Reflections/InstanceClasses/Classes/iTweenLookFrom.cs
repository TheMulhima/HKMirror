namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of iTweenLookFrom allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class iTweenLookFromR : InstanceClassWrapper<iTweenLookFrom>
{
    public iTweenLookFromR(iTweenLookFrom _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmString id
    {
        get => orig.id;
        set => orig.id = value;
    }

    public FsmGameObject transformTarget
    {
        get => orig.transformTarget;
        set => orig.transformTarget = value;
    }

    public FsmVector3 vectorTarget
    {
        get => orig.vectorTarget;
        set => orig.vectorTarget = value;
    }

    public FsmFloat time
    {
        get => orig.time;
        set => orig.time = value;
    }

    public FsmFloat delay
    {
        get => orig.delay;
        set => orig.delay = value;
    }

    public FsmFloat speed
    {
        get => orig.speed;
        set => orig.speed = value;
    }

    public FsmEvent startEvent
    {
        get => orig.startEvent;
        set => orig.startEvent = value;
    }

    public FsmEvent finishEvent
    {
        get => orig.finishEvent;
        set => orig.finishEvent = value;
    }

    public FsmBool realTime
    {
        get => orig.realTime;
        set => orig.realTime = value;
    }

    public FsmBool stopOnExit
    {
        get => orig.stopOnExit;
        set => orig.stopOnExit = value;
    }

    public FsmBool loopDontFinish
    {
        get => orig.loopDontFinish;
        set => orig.loopDontFinish = value;
    }

    public iTweenFSMEvents itweenEvents
    {
        get => GetField<iTweenFSMEvents>();
        set => SetField(value);
    }

    public string itweenType
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public int itweenID
    {
        get => GetField<int>();
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

    public void Reset()
    {
        orig.Reset();
    }

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public void OnExit()
    {
        orig.OnExit();
    }

    public void DoiTween()
    {
        CallMethod();
    }
}