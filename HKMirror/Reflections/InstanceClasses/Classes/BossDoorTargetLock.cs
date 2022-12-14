namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of BossDoorTargetLock allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossDoorTargetLockR : InstanceClassWrapper<BossDoorTargetLock>
{
    public BossDoorTargetLockR(BossDoorTargetLock _orig) : base(_orig)
    {
    }

    public BossDoorTargetLock.BossDoorTarget[] targets
    {
        get => orig.targets;
        set => orig.targets = value;
    }

    public string playerData
    {
        get => orig.playerData;
        set => orig.playerData = value;
    }

    public TriggerEnterEvent unlockTrigger
    {
        get => orig.unlockTrigger;
        set => orig.unlockTrigger = value;
    }

    public string unlockAnimation
    {
        get => orig.unlockAnimation;
        set => orig.unlockAnimation = value;
    }

    public string unlockedAnimation
    {
        get => orig.unlockedAnimation;
        set => orig.unlockedAnimation = value;
    }

    public Animator animator
    {
        get => GetField<Animator>();
        set => SetField(value);
    }

    public bool IsUnlocked
    {
        get => GetProperty<bool>();
        set => SetProperty(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public IEnumerator UnlockSequence()
    {
        return CallMethod<IEnumerator>();
    }

    public void StartRoarLock()
    {
        CallMethod();
    }

    public void StopRoarLock()
    {
        CallMethod();
    }
}