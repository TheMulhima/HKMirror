using TMPro;

namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of TMPro.TMP_Dropdown_OptionData allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMPro_TMP_Dropdown_OptionDataR : InstanceClassWrapper<TMP_Dropdown.OptionData>
{
    public TMPro_TMP_Dropdown_OptionDataR(TMP_Dropdown.OptionData _orig) : base(_orig)
    {
    }

    public string m_Text
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public Sprite m_Image
    {
        get => GetField<Sprite>();
        set => SetField(value);
    }

    public string text
    {
        get => orig.text;
        set => orig.text = value;
    }

    public Sprite image
    {
        get => orig.image;
        set => orig.image = value;
    }
}