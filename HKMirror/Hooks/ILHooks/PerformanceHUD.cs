using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PerformanceHUD,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPerformanceHUD
{
    public static event ILContext.Manipulator get_Shared
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PerformanceHUD), "get_Shared", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PerformanceHUD), "get_Shared", false), value);
    }

    public static event ILContext.Manipulator Init
    {
        add => IL.PerformanceHUD.Init += value;
        remove => IL.PerformanceHUD.Init -= value;
    }

    public static event ILContext.Manipulator get_FpsFrames
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PerformanceHUD), "get_FpsFrames"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PerformanceHUD), "get_FpsFrames"),
            value);
    }

    public static event ILContext.Manipulator set_FpsFrames
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PerformanceHUD), "set_FpsFrames"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PerformanceHUD), "set_FpsFrames"),
            value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.PerformanceHUD.Awake += value;
        remove => IL.PerformanceHUD.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.PerformanceHUD.OnEnable += value;
        remove => IL.PerformanceHUD.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.PerformanceHUD.OnDisable += value;
        remove => IL.PerformanceHUD.OnDisable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.PerformanceHUD.Update += value;
        remove => IL.PerformanceHUD.Update -= value;
    }

    public static event ILContext.Manipulator GameManager_SceneTransitionBegan
    {
        add => IL.PerformanceHUD.GameManager_SceneTransitionBegan += value;
        remove => IL.PerformanceHUD.GameManager_SceneTransitionBegan -= value;
    }

    public static event ILContext.Manipulator UpdateSceneLoadRecordContent
    {
        add => IL.PerformanceHUD.UpdateSceneLoadRecordContent += value;
        remove => IL.PerformanceHUD.UpdateSceneLoadRecordContent -= value;
    }

    public static event ILContext.Manipulator ReportUpload
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PerformanceHUD), "ReportUpload").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PerformanceHUD), "ReportUpload").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator GetTimeStr
    {
        add => IL.PerformanceHUD.GetTimeStr += value;
        remove => IL.PerformanceHUD.GetTimeStr -= value;
    }

    public static event ILContext.Manipulator UpdateMemory
    {
        add => IL.PerformanceHUD.UpdateMemory += value;
        remove => IL.PerformanceHUD.UpdateMemory -= value;
    }

    public static event ILContext.Manipulator OnGUI
    {
        add => IL.PerformanceHUD.OnGUI += value;
        remove => IL.PerformanceHUD.OnGUI -= value;
    }

    public static event ILContext.Manipulator LabelWithShadow
    {
        add => IL.PerformanceHUD.LabelWithShadow += value;
        remove => IL.PerformanceHUD.LabelWithShadow -= value;
    }
}