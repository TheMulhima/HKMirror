namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of InvNailArtBackboard allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InvNailArtBackboardR : InstanceClassWrapper<InvNailArtBackboard>
{
    public InvNailArtBackboardR(InvNailArtBackboard _orig) : base(_orig)
    {
    }

    public Sprite activeSprite
    {
        get => orig.activeSprite;
        set => orig.activeSprite = value;
    }

    public Sprite inactiveSprite
    {
        get => orig.inactiveSprite;
        set => orig.inactiveSprite = value;
    }

    public PlayerData playerData
    {
        get => GetField<PlayerData>();
        set => SetField(value);
    }

    public SpriteRenderer spriteRenderer
    {
        get => GetField<SpriteRenderer>();
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
}