using System.IO;
using System.Linq;
using HKMirror.Generator;

namespace HKMirror;

/// <summary>
/// The mod class to register the mod with the Modding API
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

        var Dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/Hooks";

        if (!Directory.Exists(Dir))
        {
            Directory.CreateDirectory(Dir);
        }

        //_ = new HookGenerator(typeof(GameManager), nameof(GameManager), Dir, false);
        foreach (var type in typeof(HeroController).Assembly.GetTypes().Where(t => t.IsClass && !t.IsAbstract))
        {
            try
            {
                _ = new HookGenerator(type, type.Name, Dir, false);
            }
            catch (Exception e)
            {
                LogError($"Did not generate for {type}");
                LogError(e);
            }
        }

    }
}