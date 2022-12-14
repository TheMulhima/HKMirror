using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TimeUtility,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTimeUtility
{
    public static event ILContext.Manipulator Wait
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TimeUtility), "Wait", false).GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TimeUtility), "Wait", false).GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator WaitForRealSeconds
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TimeUtility), "WaitForRealSeconds", false).GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TimeUtility), "WaitForRealSeconds", false).GetStateMachineTarget(),
            value);
    }
}