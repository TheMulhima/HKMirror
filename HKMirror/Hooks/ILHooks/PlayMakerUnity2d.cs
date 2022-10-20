namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PlayMakerUnity2d.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPlayMakerUnity2d
{
    public static event ILContext.Manipulator RecordLastRaycastHitInfo
    {
        add => IL.PlayMakerUnity2d.RecordLastRaycastHitInfo += value;
        remove => IL.PlayMakerUnity2d.RecordLastRaycastHitInfo -= value;
    }

    public static event ILContext.Manipulator GetLastRaycastHitInfo
    {
        add => IL.PlayMakerUnity2d.GetLastRaycastHitInfo += value;
        remove => IL.PlayMakerUnity2d.GetLastRaycastHitInfo -= value;
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.PlayMakerUnity2d.Awake += value;
        remove => IL.PlayMakerUnity2d.Awake -= value;
    }

    public static event ILContext.Manipulator OnLevelWasLoaded
    {
        add => IL.PlayMakerUnity2d.OnLevelWasLoaded += value;
        remove => IL.PlayMakerUnity2d.OnLevelWasLoaded -= value;
    }

    public static event ILContext.Manipulator isAvailable
    {
        add => IL.PlayMakerUnity2d.isAvailable += value;
        remove => IL.PlayMakerUnity2d.isAvailable -= value;
    }

    public static event ILContext.Manipulator ForwardEventToGameObject
    {
        add => IL.PlayMakerUnity2d.ForwardEventToGameObject += value;
        remove => IL.PlayMakerUnity2d.ForwardEventToGameObject -= value;
    }
}