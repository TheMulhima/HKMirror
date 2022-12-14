namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of EnemySpawner allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class EnemySpawnerR : InstanceClassWrapper<EnemySpawner>
{
    public EnemySpawnerR(EnemySpawner _orig) : base(_orig)
    {
    }

    public Action<GameObject> OnEnemySpawned
    {
        get => GetField<Action<GameObject>>();
        set => SetField(value);
    }

    public GameObject enemyPrefab
    {
        get => orig.enemyPrefab;
        set => orig.enemyPrefab = value;
    }

    public GameObject spawnedEnemy
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public float spawnChance
    {
        get => orig.spawnChance;
        set => orig.spawnChance = value;
    }

    public Vector3 moveBy
    {
        get => orig.moveBy;
        set => orig.moveBy = value;
    }

    public float easeTime
    {
        get => orig.easeTime;
        set => orig.easeTime = value;
    }

    public float elapsed
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool isComplete
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Color startColor
    {
        get => orig.startColor;
        set => orig.startColor = value;
    }

    public Color endColor
    {
        get => orig.endColor;
        set => orig.endColor = value;
    }

    public EventRegister killEvent
    {
        get => orig.killEvent;
        set => orig.killEvent = value;
    }

    public tk2dSprite sprite
    {
        get => GetField<tk2dSprite>();
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

    public void Update()
    {
        CallMethod();
    }
}