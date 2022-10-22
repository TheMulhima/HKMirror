namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of ContentPackDetailsUI_ContentPackDetails
///     allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ContentPackDetailsUI_ContentPackDetailsR : InstanceClassWrapper<ContentPackDetailsUI.ContentPackDetails>
{
    public ContentPackDetailsUI_ContentPackDetailsR(ContentPackDetailsUI.ContentPackDetails _orig) : base(_orig)
    {
    }

    public Sprite posterSprite
    {
        get => orig.posterSprite;
        set => orig.posterSprite = value;
    }

    public string titleText
    {
        get => orig.titleText;
        set => orig.titleText = value;
    }

    public string descriptionText
    {
        get => orig.descriptionText;
        set => orig.descriptionText = value;
    }

    public int menuStyleIndex
    {
        get => orig.menuStyleIndex;
        set => orig.menuStyleIndex = value;
    }
}