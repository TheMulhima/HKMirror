namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of BreakableObject allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BreakableObjectR : InstanceClassWrapper<BreakableObject>
{
    public BreakableObjectR(BreakableObject _orig) : base(_orig)
    {
    }

    public GameObject[] flingDebris
    {
        get => orig.flingDebris;
        set => orig.flingDebris = value;
    }

    public float attackMagnitude
    {
        get => orig.attackMagnitude;
        set => orig.attackMagnitude = value;
    }

    public Probability.ProbabilityGameObject[] containingParticles
    {
        get => orig.containingParticles;
        set => orig.containingParticles = value;
    }

    public BreakableObject.FlingObject[] flingObjectRegister
    {
        get => orig.flingObjectRegister;
        set => orig.flingObjectRegister = value;
    }

    public GameObject objectNailEffectPrefab
    {
        get => orig.objectNailEffectPrefab;
        set => orig.objectNailEffectPrefab = value;
    }

    public GameObject midpointNailEffectPrefab
    {
        get => orig.midpointNailEffectPrefab;
        set => orig.midpointNailEffectPrefab = value;
    }

    public GameObject spellHitEffectPrefab
    {
        get => orig.spellHitEffectPrefab;
        set => orig.spellHitEffectPrefab = value;
    }

    public AudioClip[] cutSound
    {
        get => orig.cutSound;
        set => orig.cutSound = value;
    }

    public float pitchMin
    {
        get => orig.pitchMin;
        set => orig.pitchMin = value;
    }

    public float pitchMax
    {
        get => orig.pitchMax;
        set => orig.pitchMax = value;
    }

    public AudioSource source
    {
        get => GetField<AudioSource>();
        set => SetField(value);
    }

    public bool activated
    {
        get => GetField<bool>();
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

    public void OnTriggerEnter2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }
}