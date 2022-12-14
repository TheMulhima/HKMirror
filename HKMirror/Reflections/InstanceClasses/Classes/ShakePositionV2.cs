namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of ShakePositionV2 allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ShakePositionV2R : InstanceClassWrapper<ShakePositionV2>
{
    public ShakePositionV2R(ShakePositionV2 _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault Target
    {
        get => orig.Target;
        set => orig.Target = value;
    }

    public FsmVector3 Extents
    {
        get => orig.Extents;
        set => orig.Extents = value;
    }

    public FsmFloat Duration
    {
        get => orig.Duration;
        set => orig.Duration = value;
    }

    public FsmBool IsLooping
    {
        get => orig.IsLooping;
        set => orig.IsLooping = value;
    }

    public FsmEvent StopEvent
    {
        get => orig.StopEvent;
        set => orig.StopEvent = value;
    }

    public FsmFloat FpsLimit
    {
        get => orig.FpsLimit;
        set => orig.FpsLimit = value;
    }

    public FsmBool IsCameraShake
    {
        get => orig.IsCameraShake;
        set => orig.IsCameraShake = value;
    }

    public float timer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float nextUpdateTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public Transform target
    {
        get => GetField<Transform>();
        set => SetField(value);
    }

    public Vector3 startingWorldPosition
    {
        get => GetField<Vector3>();
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

    public void UpdateShaking()
    {
        CallMethod();
    }

    public void StopAndReset()
    {
        CallMethod();
    }
}