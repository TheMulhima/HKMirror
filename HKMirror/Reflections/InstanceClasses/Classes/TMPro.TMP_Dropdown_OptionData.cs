namespace HKMirror.Reflection.InstanceClasses
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TMPro.TMP_Dropdown_OptionData allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMPro_TMP_Dropdown_OptionDataR:InstanceClassWrapper<TMPro.TMP_Dropdown.OptionData>
{
public TMPro_TMP_Dropdown_OptionDataR(TMPro.TMP_Dropdown.OptionData _orig) : base(_orig) {}
public string m_Text
{
get => GetField<string>();
set => SetField(value);
}

public UnityEngine.Sprite m_Image
{
get => GetField<UnityEngine.Sprite>();
set => SetField(value);
}

public string text
{
get => orig.text;
set => orig.text = value;
}

public UnityEngine.Sprite image
{
get => orig.image;
set => orig.image = value;
}

}
}
