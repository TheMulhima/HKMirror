namespace HKMirror.Reflection.InstanceClasses
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TMPro.TMP_Dropdown_OptionDataList allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMPro_TMP_Dropdown_OptionDataListR:InstanceClassWrapper<TMPro.TMP_Dropdown.OptionDataList>
{
public TMPro_TMP_Dropdown_OptionDataListR(TMPro.TMP_Dropdown.OptionDataList _orig) : base(_orig) {}
public System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> m_Options
{
get => GetField<System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData>>();
set => SetField(value);
}

public System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> options
{
get => orig.options;
set => orig.options = value;
}

}
}
