namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of GameManager_SceneLoadInfo allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GameManager_SceneLoadInfoR : InstanceClassWrapper<GameManager.SceneLoadInfo>
{
    public GameManager_SceneLoadInfoR(GameManager.SceneLoadInfo _orig) : base(_orig)
    {
    }

    public bool IsFirstLevelForPlayer
    {
        get => orig.IsFirstLevelForPlayer;
        set => orig.IsFirstLevelForPlayer = value;
    }

    public string SceneName
    {
        get => orig.SceneName;
        set => orig.SceneName = value;
    }

    public GatePosition? HeroLeaveDirection
    {
        get => orig.HeroLeaveDirection;
        set => orig.HeroLeaveDirection = value;
    }

    public string EntryGateName
    {
        get => orig.EntryGateName;
        set => orig.EntryGateName = value;
    }

    public float EntryDelay
    {
        get => orig.EntryDelay;
        set => orig.EntryDelay = value;
    }

    public bool PreventCameraFadeOut
    {
        get => orig.PreventCameraFadeOut;
        set => orig.PreventCameraFadeOut = value;
    }

    public bool WaitForSceneTransitionCameraFade
    {
        get => orig.WaitForSceneTransitionCameraFade;
        set => orig.WaitForSceneTransitionCameraFade = value;
    }

    public bool AlwaysUnloadUnusedAssets
    {
        get => orig.AlwaysUnloadUnusedAssets;
        set => orig.AlwaysUnloadUnusedAssets = value;
    }

    public bool forceWaitFetch
    {
        get => orig.forceWaitFetch;
        set => orig.forceWaitFetch = value;
    }

    public void NotifyFetchComplete()
    {
        orig.NotifyFetchComplete();
    }

    public bool IsReadyToActivate()
    {
        return orig.IsReadyToActivate();
    }

    public void NotifyFinished()
    {
        orig.NotifyFinished();
    }
}