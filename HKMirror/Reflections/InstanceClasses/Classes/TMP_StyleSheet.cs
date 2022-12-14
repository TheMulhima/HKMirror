using TMPro;

namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of TMP_StyleSheet allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMP_StyleSheetR : InstanceClassWrapper<TMP_StyleSheet>
{
    public TMP_StyleSheetR(TMP_StyleSheet _orig) : base(_orig)
    {
    }

    public TMP_StyleSheet s_Instance
    {
        get => GetFieldStatic<TMP_StyleSheet>();
        set => SetField(value);
    }

    public List<TMP_Style> m_StyleList
    {
        get => GetField<List<TMP_Style>>();
        set => SetField(value);
    }

    public Dictionary<int, TMP_Style> m_StyleDictionary
    {
        get => GetField<Dictionary<int, TMP_Style>>();
        set => SetField(value);
    }

    public TMP_StyleSheet instance => TMP_StyleSheet.instance;

    public string name
    {
        get => orig.name;
        set => orig.name = value;
    }

    public HideFlags hideFlags
    {
        get => orig.hideFlags;
        set => orig.hideFlags = value;
    }

    public TMP_StyleSheet LoadDefaultStyleSheet()
    {
        return TMP_StyleSheet.LoadDefaultStyleSheet();
    }

    public TMP_Style GetStyle(int hashCode)
    {
        return TMP_StyleSheet.GetStyle(hashCode);
    }

    public TMP_Style GetStyleInternal(int hashCode)
    {
        return CallMethod<TMP_Style>(new object[] { hashCode });
    }

    public void UpdateStyleDictionaryKey(int old_key, int new_key)
    {
        orig.UpdateStyleDictionaryKey(old_key, new_key);
    }

    public void RefreshStyles()
    {
        TMP_StyleSheet.RefreshStyles();
    }

    public void LoadStyleDictionaryInternal()
    {
        CallMethod();
    }
}