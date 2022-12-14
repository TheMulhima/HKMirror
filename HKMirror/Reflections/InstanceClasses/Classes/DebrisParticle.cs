namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of DebrisParticle allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DebrisParticleR : InstanceClassWrapper<DebrisParticle>
{
    public DebrisParticleR(DebrisParticle _orig) : base(_orig)
    {
    }

    public Rigidbody2D body
    {
        get => GetField<Rigidbody2D>();
        set => SetField(value);
    }

    public tk2dSprite sprite
    {
        get => GetField<tk2dSprite>();
        set => SetField(value);
    }

    public string[] randomSpriteIds
    {
        get => GetField<string[]>();
        set => SetField(value);
    }

    public float startZ
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float scaleMin
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float scaleMax
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float blackChance
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool didSpin
    {
        get => GetField<bool>();
        set => SetField(value);
    }


    public void Reset()
    {
        CallMethod();
    }

    public void Awake()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }
}