namespace HKMirror.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of SetAnimatorLookAt allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetAnimatorLookAtR : InstanceClassWrapper<SetAnimatorLookAt>
{
    public SetAnimatorLookAtR(SetAnimatorLookAt _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmGameObject target
    {
        get => orig.target;
        set => orig.target = value;
    }

    public FsmVector3 targetPosition
    {
        get => orig.targetPosition;
        set => orig.targetPosition = value;
    }

    public FsmFloat weight
    {
        get => orig.weight;
        set => orig.weight = value;
    }

    public FsmFloat bodyWeight
    {
        get => orig.bodyWeight;
        set => orig.bodyWeight = value;
    }

    public FsmFloat headWeight
    {
        get => orig.headWeight;
        set => orig.headWeight = value;
    }

    public FsmFloat eyesWeight
    {
        get => orig.eyesWeight;
        set => orig.eyesWeight = value;
    }

    public FsmFloat clampWeight
    {
        get => orig.clampWeight;
        set => orig.clampWeight = value;
    }

    public bool everyFrame
    {
        get => orig.everyFrame;
        set => orig.everyFrame = value;
    }

    public Animator _animator
    {
        get => GetField<Animator>();
        set => SetField(value);
    }

    public Transform _transform
    {
        get => GetField<Transform>();
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

    public void OnPreprocess()
    {
        orig.OnPreprocess();
    }

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public void DoAnimatorIK(int layerIndex)
    {
        orig.DoAnimatorIK(layerIndex);
    }

    public void DoSetLookAt()
    {
        CallMethod();
    }
}