using HKMirror.Hooks.OnHooks;

namespace HKMirror;

/// <summary>
/// The mod class for the Modding API.
/// </summary>
public sealed class HKMirrorMod : Mod
{
    internal static HKMirrorMod Instance;
    
    public override string GetVersion()
    {
        return "v2.0.0.0";
    }

    public override void Initialize()
    {
        Instance = this;
        Log("Loading HKMirror Mod");
        var Dir = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/Hooks";

        if (!System.IO.Directory.Exists(Dir))
        {
            System.IO.Directory.CreateDirectory(Dir);
        }

        _ = new Generator.HookGenerator(typeof(GameManager), nameof(GameManager), Dir, false);
    }

    public static void DoLogError(object log)
    { 
        Instance.LogError(log);
    }
}