using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TimeScaleIndependentUpdate.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTimeScaleIndependentUpdate
{
    public static event ILContext.Manipulator get_deltaTime
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TimeScaleIndependentUpdate), "get_deltaTime"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TimeScaleIndependentUpdate), "get_deltaTime"), value);
    }

    public static event ILContext.Manipulator set_deltaTime
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TimeScaleIndependentUpdate), "set_deltaTime"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TimeScaleIndependentUpdate), "set_deltaTime"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.TimeScaleIndependentUpdate.Awake += value;
        remove => IL.TimeScaleIndependentUpdate.Awake -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.TimeScaleIndependentUpdate.Update += value;
        remove => IL.TimeScaleIndependentUpdate.Update -= value;
    }

    public static event ILContext.Manipulator TimeScaleIndependentWaitForSeconds
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TimeScaleIndependentUpdate), "TimeScaleIndependentWaitForSeconds")
                .GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TimeScaleIndependentUpdate), "TimeScaleIndependentWaitForSeconds")
                .GetStateMachineTarget(), value);
    }
}