namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of BreakableObject_FlingObject allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BreakableObject_FlingObjectR : InstanceClassWrapper<BreakableObject.FlingObject>
{
    public BreakableObject_FlingObjectR(BreakableObject.FlingObject _orig) : base(_orig)
    {
    }

    public GameObject referenceObject
    {
        get => orig.referenceObject;
        set => orig.referenceObject = value;
    }

    public int spawnMin
    {
        get => orig.spawnMin;
        set => orig.spawnMin = value;
    }

    public int spawnMax
    {
        get => orig.spawnMax;
        set => orig.spawnMax = value;
    }

    public float speedMin
    {
        get => orig.speedMin;
        set => orig.speedMin = value;
    }

    public float speedMax
    {
        get => orig.speedMax;
        set => orig.speedMax = value;
    }

    public float angleMin
    {
        get => orig.angleMin;
        set => orig.angleMin = value;
    }

    public float angleMax
    {
        get => orig.angleMax;
        set => orig.angleMax = value;
    }

    public Vector2 originVariation
    {
        get => orig.originVariation;
        set => orig.originVariation = value;
    }

    public void Fling(Vector3 origin)
    {
        orig.Fling(origin);
    }
}