using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BreakableObject_FlingObject,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBreakableObject_FlingObject
{
    public static event ILContext.Manipulator Fling
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BreakableObject.FlingObject), "Fling"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BreakableObject.FlingObject), "Fling"), value);
    }
}