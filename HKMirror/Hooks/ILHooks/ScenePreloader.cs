using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ScenePreloader.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILScenePreloader
{
    public static event ILContext.Manipulator Start
    {
        add => IL.ScenePreloader.Start += value;
        remove => IL.ScenePreloader.Start -= value;
    }

    public static event ILContext.Manipulator OnGUI
    {
        add => IL.ScenePreloader.OnGUI += value;
        remove => IL.ScenePreloader.OnGUI -= value;
    }

    public static event ILContext.Manipulator LoadRoutine
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ScenePreloader), "LoadRoutine").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ScenePreloader), "LoadRoutine").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator FinishPendingOperations
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ScenePreloader), "FinishPendingOperations", false)
                .GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ScenePreloader), "FinishPendingOperations", false)
                .GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Cleanup
    {
        add => IL.ScenePreloader.Cleanup += value;
        remove => IL.ScenePreloader.Cleanup -= value;
    }
}