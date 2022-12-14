using TMPro;

namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of MenuButtonIcon allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuButtonIconR : InstanceClassWrapper<MenuButtonIcon>
{
    public MenuButtonIconR(MenuButtonIcon _orig) : base(_orig)
    {
    }

    public bool liveUpdate
    {
        get => orig.liveUpdate;
        set => orig.liveUpdate = value;
    }

    public TextMeshPro label
    {
        get => orig.label;
        set => orig.label = value;
    }

    public TextContainer textContainer
    {
        get => orig.textContainer;
        set => orig.textContainer = value;
    }

    public SpriteRenderer sr
    {
        get => GetField<SpriteRenderer>();
        set => SetField(value);
    }

    public HeroActionButton Action => orig.Action;
}