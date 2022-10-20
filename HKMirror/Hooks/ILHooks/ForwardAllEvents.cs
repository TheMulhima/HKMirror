using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ForwardAllEvents.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILForwardAllEvents
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ForwardAllEvents), "Reset"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ForwardAllEvents), "Reset"), value);
    }

    public static event ILContext.Manipulator Event
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ForwardAllEvents), "Event"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ForwardAllEvents), "Event"), value);
    }
}