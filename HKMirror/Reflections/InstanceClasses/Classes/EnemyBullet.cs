namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of EnemyBullet allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class EnemyBulletR : InstanceClassWrapper<EnemyBullet>
{
    public EnemyBulletR(EnemyBullet _orig) : base(_orig)
    {
    }

    public float scaleMin
    {
        get => orig.scaleMin;
        set => orig.scaleMin = value;
    }

    public float scaleMax
    {
        get => orig.scaleMax;
        set => orig.scaleMax = value;
    }

    public float scale
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float stretchFactor
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

    public AudioSource audioSourcePrefab
    {
        get => orig.audioSourcePrefab;
        set => orig.audioSourcePrefab = value;
    }

    public AudioEvent impactSound
    {
        get => orig.impactSound;
        set => orig.impactSound = value;
    }

    public bool active
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Rigidbody2D body
    {
        get => GetField<Rigidbody2D>();
        set => SetField(value);
    }

    public tk2dSpriteAnimator anim
    {
        get => GetField<tk2dSpriteAnimator>();
        set => SetField(value);
    }

    public Collider2D col
    {
        get => GetField<Collider2D>();
        set => SetField(value);
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

    public void OnCollisionEnter2D(Collision2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public void OrbitShieldHit(Transform shield)
    {
        orig.OrbitShieldHit(shield);
    }

    public IEnumerator Collision(Vector2 normal, bool doRotation)
    {
        return CallMethod<IEnumerator>(new object[] { normal, doRotation });
    }
}