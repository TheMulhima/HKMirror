namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of ObjectPool_StartupPool allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ObjectPool_StartupPoolR : InstanceClassWrapper<ObjectPool.StartupPool>
{
    public ObjectPool_StartupPoolR(ObjectPool.StartupPool _orig) : base(_orig)
    {
    }

    public int size
    {
        get => orig.size;
        set => orig.size = value;
    }

    public GameObject prefab
    {
        get => orig.prefab;
        set => orig.prefab = value;
    }
}