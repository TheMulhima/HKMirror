namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of ScenePreloader_SceneLoadOp allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ScenePreloader_SceneLoadOpR : InstanceClassWrapper<ScenePreloader.SceneLoadOp>
{
    public ScenePreloader_SceneLoadOpR(ScenePreloader.SceneLoadOp _orig) : base(_orig)
    {
    }

    public AsyncOperation operation
    {
        get => orig.operation;
        set => orig.operation = value;
    }

    public string sceneName
    {
        get => orig.sceneName;
        set => orig.sceneName = value;
    }
}