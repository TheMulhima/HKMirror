namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dSpriteCollectionDefinition_ColliderData
///     allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class
    tk2dSpriteCollectionDefinition_ColliderDataR : InstanceClassWrapper<tk2dSpriteCollectionDefinition.ColliderData>
{
    public tk2dSpriteCollectionDefinition_ColliderDataR(tk2dSpriteCollectionDefinition.ColliderData _orig) : base(_orig)
    {
    }

    public string name
    {
        get => orig.name;
        set => orig.name = value;
    }

    public Vector2 origin
    {
        get => orig.origin;
        set => orig.origin = value;
    }

    public Vector2 size
    {
        get => orig.size;
        set => orig.size = value;
    }

    public float angle
    {
        get => orig.angle;
        set => orig.angle = value;
    }

    public void CopyFrom(tk2dSpriteCollectionDefinition.ColliderData src)
    {
        orig.CopyFrom(src);
    }

    public bool CompareTo(tk2dSpriteCollectionDefinition.ColliderData src)
    {
        return orig.CompareTo(src);
    }
}