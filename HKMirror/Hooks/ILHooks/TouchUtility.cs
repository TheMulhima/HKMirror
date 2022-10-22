using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TouchUtility,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTouchUtility
{
    public static event ILContext.Manipulator AnchorToViewPoint
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchUtility), "AnchorToViewPoint", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchUtility), "AnchorToViewPoint", false), value);
    }

    public static event ILContext.Manipulator RoundVector
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchUtility), "RoundVector", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchUtility), "RoundVector", false), value);
    }
}