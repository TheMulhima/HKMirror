using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for StagTravel.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILStagTravel
{
    public static event ILContext.Manipulator Start
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(StagTravel), "Start").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(StagTravel), "Start").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator FadeInRoutine
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(StagTravel), "FadeInRoutine").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(StagTravel), "FadeInRoutine").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.StagTravel.Update += value;
        remove => IL.StagTravel.Update -= value;
    }

    public static event ILContext.Manipulator NotifyFetchComplete
    {
        add => IL.StagTravel.NotifyFetchComplete += value;
        remove => IL.StagTravel.NotifyFetchComplete -= value;
    }

    public static event ILContext.Manipulator get_IsReadyToActivate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(StagTravel), "get_IsReadyToActivate"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(StagTravel), "get_IsReadyToActivate"), value);
    }

    public static event ILContext.Manipulator Skip
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(StagTravel), "Skip").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(StagTravel), "Skip").GetStateMachineTarget(), value);
    }
}