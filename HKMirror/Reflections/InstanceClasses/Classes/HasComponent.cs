namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of HasComponent allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class HasComponentR : InstanceClassWrapper<HasComponent>
{
    public HasComponentR(HasComponent _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmString component
    {
        get => orig.component;
        set => orig.component = value;
    }

    public FsmBool removeOnExit
    {
        get => orig.removeOnExit;
        set => orig.removeOnExit = value;
    }

    public FsmEvent trueEvent
    {
        get => orig.trueEvent;
        set => orig.trueEvent = value;
    }

    public FsmEvent falseEvent
    {
        get => orig.falseEvent;
        set => orig.falseEvent = value;
    }

    public FsmBool store
    {
        get => orig.store;
        set => orig.store = value;
    }

    public bool everyFrame
    {
        get => orig.everyFrame;
        set => orig.everyFrame = value;
    }

    public Component aComponent
    {
        get => GetField<Component>();
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

    public void OnUpdate()
    {
        orig.OnUpdate();
    }

    public void OnExit()
    {
        orig.OnExit();
    }

    public void DoHasComponent(GameObject go)
    {
        CallMethod(new object[] { go });
    }
}