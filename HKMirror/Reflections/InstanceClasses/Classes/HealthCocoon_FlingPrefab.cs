namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of HealthCocoon_FlingPrefab allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class HealthCocoon_FlingPrefabR : InstanceClassWrapper<HealthCocoon.FlingPrefab>
{
    public HealthCocoon_FlingPrefabR(HealthCocoon.FlingPrefab _orig) : base(_orig)
    {
    }

    public GameObject prefab
    {
        get => orig.prefab;
        set => orig.prefab = value;
    }

    public List<GameObject> pool
    {
        get => GetField<List<GameObject>>();
        set => SetField(value);
    }

    public int minAmount
    {
        get => orig.minAmount;
        set => orig.minAmount = value;
    }

    public int maxAmount
    {
        get => orig.maxAmount;
        set => orig.maxAmount = value;
    }

    public Vector2 originVariation
    {
        get => orig.originVariation;
        set => orig.originVariation = value;
    }

    public float minSpeed
    {
        get => orig.minSpeed;
        set => orig.minSpeed = value;
    }

    public float maxSpeed
    {
        get => orig.maxSpeed;
        set => orig.maxSpeed = value;
    }

    public float minAngle
    {
        get => orig.minAngle;
        set => orig.minAngle = value;
    }

    public float maxAngle
    {
        get => orig.maxAngle;
        set => orig.maxAngle = value;
    }

    public void SetupPool(Transform parent)
    {
        orig.SetupPool(parent);
    }

    public GameObject Spawn()
    {
        return orig.Spawn();
    }
}