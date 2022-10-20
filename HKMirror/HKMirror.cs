namespace HKMirror;

/// <summary>
/// The mod class for the Modding API.
/// </summary>
public sealed class HKMirrorMod : Mod
{
    public override string GetVersion()
    {
        return "v1.0.0.0";
    }

    public override void Initialize()
    {
        Log("Loading HKMirror Mod");
    }
}