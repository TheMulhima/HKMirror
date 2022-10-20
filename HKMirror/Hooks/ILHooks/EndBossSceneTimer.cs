using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for EndBossSceneTimer.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILEndBossSceneTimer
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.EndBossSceneTimer.OnEnable += value;
        remove => IL.EndBossSceneTimer.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.EndBossSceneTimer.OnDisable += value;
        remove => IL.EndBossSceneTimer.OnDisable -= value;
    }

    public static event ILContext.Manipulator Delayed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(EndBossSceneTimer), "Delayed").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(EndBossSceneTimer), "Delayed").GetStateMachineTarget(), value);
    }
}