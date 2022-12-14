namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of WorldInfo allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class WorldInfoR : InstanceClassWrapper<WorldInfo>
{
    public WorldInfoR(WorldInfo _orig) : base(_orig)
    {
    }

    public WorldInfo.SceneInfo[] Scenes
    {
        get => orig.Scenes;
        set => orig.Scenes = value;
    }

    public string[] NonGameplaySceneName
    {
        get => GetFieldStatic<string[]>();
        set => SetField(value);
    }

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

    public bool NameLooksLikeGameplayScene(string sceneName)
    {
        return WorldInfo.NameLooksLikeGameplayScene(sceneName);
    }
}