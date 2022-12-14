namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of PlatformSpecificSprite allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlatformSpecificSpriteR : InstanceClassWrapper<PlatformSpecificSprite>
{
    public PlatformSpecificSpriteR(PlatformSpecificSprite _orig) : base(_orig)
    {
    }

    public SpriteRenderer spriteRenderer
    {
        get => GetField<SpriteRenderer>();
        set => SetField(value);
    }

    public PlatformSpecificSprite.PlatformSpriteMatch[] sprites
    {
        get => GetField<PlatformSpecificSprite.PlatformSpriteMatch[]>();
        set => SetField(value);
    }


    public void OnEnable()
    {
        CallMethod();
    }
}