using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for OnScreenDebugInfo.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILOnScreenDebugInfo
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.OnScreenDebugInfo.Awake += value;
        remove => IL.OnScreenDebugInfo.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OnScreenDebugInfo), "Start").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OnScreenDebugInfo), "Start").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator LevelActivated
    {
        add => IL.OnScreenDebugInfo.LevelActivated += value;
        remove => IL.OnScreenDebugInfo.LevelActivated -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.OnScreenDebugInfo.OnEnable += value;
        remove => IL.OnScreenDebugInfo.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.OnScreenDebugInfo.OnDisable += value;
        remove => IL.OnScreenDebugInfo.OnDisable -= value;
    }

    public static event ILContext.Manipulator OnGUI
    {
        add => IL.OnScreenDebugInfo.OnGUI += value;
        remove => IL.OnScreenDebugInfo.OnGUI -= value;
    }

    public static event ILContext.Manipulator ShowFPS
    {
        add => IL.OnScreenDebugInfo.ShowFPS += value;
        remove => IL.OnScreenDebugInfo.ShowFPS -= value;
    }

    public static event ILContext.Manipulator ShowGameInfo
    {
        add => IL.OnScreenDebugInfo.ShowGameInfo += value;
        remove => IL.OnScreenDebugInfo.ShowGameInfo -= value;
    }

    public static event ILContext.Manipulator ShowInput
    {
        add => IL.OnScreenDebugInfo.ShowInput += value;
        remove => IL.OnScreenDebugInfo.ShowInput -= value;
    }

    public static event ILContext.Manipulator ShowLoadingTime
    {
        add => IL.OnScreenDebugInfo.ShowLoadingTime += value;
        remove => IL.OnScreenDebugInfo.ShowLoadingTime -= value;
    }

    public static event ILContext.Manipulator ShowTargetFrameRate
    {
        add => IL.OnScreenDebugInfo.ShowTargetFrameRate += value;
        remove => IL.OnScreenDebugInfo.ShowTargetFrameRate -= value;
    }

    public static event ILContext.Manipulator OnLevelUnload
    {
        add => IL.OnScreenDebugInfo.OnLevelUnload += value;
        remove => IL.OnScreenDebugInfo.OnLevelUnload -= value;
    }

    public static event ILContext.Manipulator RetrieveInfo
    {
        add => IL.OnScreenDebugInfo.RetrieveInfo += value;
        remove => IL.OnScreenDebugInfo.RetrieveInfo -= value;
    }

    public static event ILContext.Manipulator ReadInput
    {
        add => IL.OnScreenDebugInfo.ReadInput += value;
        remove => IL.OnScreenDebugInfo.ReadInput -= value;
    }

    public static event ILContext.Manipulator orig_Awake
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(OnScreenDebugInfo), "orig_Awake"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(OnScreenDebugInfo), "orig_Awake"),
            value);
    }
}