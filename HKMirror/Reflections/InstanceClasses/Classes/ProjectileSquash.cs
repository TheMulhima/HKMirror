namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of ProjectileSquash allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ProjectileSquashR : InstanceClassWrapper<ProjectileSquash>
{
    public ProjectileSquashR(ProjectileSquash _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmFloat stretchFactor
    {
        get => orig.stretchFactor;
        set => orig.stretchFactor = value;
    }

    public float stretchMinX
    {
        get => orig.stretchMinX;
        set => orig.stretchMinX = value;
    }

    public float stretchMaxY
    {
        get => orig.stretchMaxY;
        set => orig.stretchMaxY = value;
    }

    public FsmFloat scaleModifier
    {
        get => orig.scaleModifier;
        set => orig.scaleModifier = value;
    }

    public bool everyFrame
    {
        get => orig.everyFrame;
        set => orig.everyFrame = value;
    }

    public FsmGameObject target
    {
        get => GetField<FsmGameObject>();
        set => SetField(value);
    }

    public float stretchX
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float stretchY
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public Rigidbody2D rb2d
    {
        get => GetField<Rigidbody2D>();
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

    public void OnFixedUpdate()
    {
        orig.OnFixedUpdate();
    }

    public void DoStretch()
    {
        CallMethod();
    }
}