namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of CorpseZomHive allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CorpseZomHiveR : InstanceClassWrapper<CorpseZomHive>
{
    public CorpseZomHiveR(CorpseZomHive _orig) : base(_orig)
    {
    }

    public GameObject effects
    {
        get => orig.effects;
        set => orig.effects = value;
    }

    public GameObject chunks
    {
        get => orig.chunks;
        set => orig.chunks = value;
    }

    public MeshRenderer meshRenderer
    {
        get => GetField<MeshRenderer>();
        set => SetField(value);
    }

    public tk2dSprite sprite
    {
        get => GetField<tk2dSprite>();
        set => SetField(value);
    }

    public tk2dSpriteAnimator spriteAnimator
    {
        get => GetField<tk2dSpriteAnimator>();
        set => SetField(value);
    }

    public SpriteFlash spriteFlash
    {
        get => GetField<SpriteFlash>();
        set => SetField(value);
    }

    public Rigidbody2D body
    {
        get => GetField<Rigidbody2D>();
        set => SetField(value);
    }

    public Collider2D bodyCollider
    {
        get => GetField<Collider2D>();
        set => SetField(value);
    }

    public ParticleSystem corpseFlame
    {
        get => GetField<ParticleSystem>();
        set => SetField(value);
    }

    public ParticleSystem corpseSteam
    {
        get => GetField<ParticleSystem>();
        set => SetField(value);
    }

    public GameObject landEffects
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public AudioSource audioPlayerPrefab
    {
        get => GetField<AudioSource>();
        set => SetField(value);
    }

    public GameObject deathWaveInfectedPrefab
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public GameObject spatterOrangePrefab
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public RandomAudioClipTable splatAudioClipTable
    {
        get => GetField<RandomAudioClipTable>();
        set => SetField(value);
    }

    public bool spellBurn
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool hitAcid
    {
        get => GetField<bool>();
        set => SetField(value);
    }


    public void LandEffects()
    {
        CallMethod();
    }
}