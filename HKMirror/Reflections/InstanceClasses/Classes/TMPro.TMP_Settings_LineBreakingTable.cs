using TMPro;

namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of TMPro.TMP_Settings_LineBreakingTable allowing
///     you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TMPro_TMP_Settings_LineBreakingTableR : InstanceClassWrapper<TMP_Settings.LineBreakingTable>
{
    public TMPro_TMP_Settings_LineBreakingTableR(TMP_Settings.LineBreakingTable _orig) : base(_orig)
    {
    }

    public Dictionary<int, char> leadingCharacters
    {
        get => orig.leadingCharacters;
        set => orig.leadingCharacters = value;
    }

    public Dictionary<int, char> followingCharacters
    {
        get => orig.followingCharacters;
        set => orig.followingCharacters = value;
    }
}