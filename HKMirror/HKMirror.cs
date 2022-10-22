namespace HKMirror;

/// <summary>
///     The mod class for the Modding API.
/// </summary>
public sealed class HKMirrorMod : Mod
{
    internal static HKMirrorMod Instance;

    public override string GetVersion()
    {
        return "v2.1.0.0";
    }

    public override void Initialize()
    {
        Instance = this;
        Log("Loading HKMirror Mod");
    }

    public static void DoLogError(object log)
    {
        Instance.LogError(log);
    }
}