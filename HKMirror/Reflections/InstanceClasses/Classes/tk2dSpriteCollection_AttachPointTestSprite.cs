namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dSpriteCollection_AttachPointTestSprite
///     allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class
    tk2dSpriteCollection_AttachPointTestSpriteR : InstanceClassWrapper<tk2dSpriteCollection.AttachPointTestSprite>
{
    public tk2dSpriteCollection_AttachPointTestSpriteR(tk2dSpriteCollection.AttachPointTestSprite _orig) : base(_orig)
    {
    }

    public string attachPointName
    {
        get => orig.attachPointName;
        set => orig.attachPointName = value;
    }

    public tk2dSpriteCollectionData spriteCollection
    {
        get => orig.spriteCollection;
        set => orig.spriteCollection = value;
    }

    public int spriteId
    {
        get => orig.spriteId;
        set => orig.spriteId = value;
    }

    public bool CompareTo(tk2dSpriteCollection.AttachPointTestSprite src)
    {
        return orig.CompareTo(src);
    }

    public void CopyFrom(tk2dSpriteCollection.AttachPointTestSprite src)
    {
        orig.CopyFrom(src);
    }
}