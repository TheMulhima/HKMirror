using TMPro;

namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of TMPro.TMP_Dropdown_OptionDataList allowing you
///     to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMPro_TMP_Dropdown_OptionDataListR : InstanceClassWrapper<TMP_Dropdown.OptionDataList>
{
    public TMPro_TMP_Dropdown_OptionDataListR(TMP_Dropdown.OptionDataList _orig) : base(_orig)
    {
    }

    public List<TMP_Dropdown.OptionData> m_Options
    {
        get => GetField<List<TMP_Dropdown.OptionData>>();
        set => SetField(value);
    }

    public List<TMP_Dropdown.OptionData> options
    {
        get => orig.options;
        set => orig.options = value;
    }
}