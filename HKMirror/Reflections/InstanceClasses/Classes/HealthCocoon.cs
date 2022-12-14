namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of HealthCocoon allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class HealthCocoonR : InstanceClassWrapper<HealthCocoon>
{
    public HealthCocoonR(HealthCocoon _orig) : base(_orig)
    {
    }

    public GameObject[] slashEffects
    {
        get => orig.slashEffects;
        set => orig.slashEffects = value;
    }

    public GameObject[] spellEffects
    {
        get => orig.spellEffects;
        set => orig.spellEffects = value;
    }

    public Vector3 effectOrigin
    {
        get => orig.effectOrigin;
        set => orig.effectOrigin = value;
    }

    public HealthCocoon.FlingPrefab[] flingPrefabs
    {
        get => orig.flingPrefabs;
        set => orig.flingPrefabs = value;
    }

    public GameObject[] enableChildren
    {
        get => orig.enableChildren;
        set => orig.enableChildren = value;
    }

    public GameObject[] disableChildren
    {
        get => orig.disableChildren;
        set => orig.disableChildren = value;
    }

    public Collider2D[] disableColliders
    {
        get => orig.disableColliders;
        set => orig.disableColliders = value;
    }

    public Rigidbody2D cap
    {
        get => orig.cap;
        set => orig.cap = value;
    }

    public float capHitForce
    {
        get => orig.capHitForce;
        set => orig.capHitForce = value;
    }

    public AudioClip deathSound
    {
        get => orig.deathSound;
        set => orig.deathSound = value;
    }

    public bool activated
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public string idleAnimation
    {
        get => orig.idleAnimation;
        set => orig.idleAnimation = value;
    }

    public string sweatAnimation
    {
        get => orig.sweatAnimation;
        set => orig.sweatAnimation = value;
    }

    public AudioClip moveSound
    {
        get => orig.moveSound;
        set => orig.moveSound = value;
    }

    public float waitMin
    {
        get => orig.waitMin;
        set => orig.waitMin = value;
    }

    public float waitMax
    {
        get => orig.waitMax;
        set => orig.waitMax = value;
    }

    public Coroutine animRoutine
    {
        get => GetField<Coroutine>();
        set => SetField(value);
    }

    public AudioSource source
    {
        get => GetField<AudioSource>();
        set => SetField(value);
    }

    public tk2dSpriteAnimator animator
    {
        get => GetField<tk2dSpriteAnimator>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void PlaySound(AudioClip clip)
    {
        CallMethod(new object[] { clip });
    }

    public IEnumerator Animate()
    {
        return CallMethod<IEnumerator>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public void SetBroken()
    {
        CallMethod();
    }

    public void FlingObjects(HealthCocoon.FlingPrefab fling)
    {
        CallMethod(new object[] { fling });
    }

    public void SetScuttlerAmount(int amount)
    {
        orig.SetScuttlerAmount(amount);
    }
}