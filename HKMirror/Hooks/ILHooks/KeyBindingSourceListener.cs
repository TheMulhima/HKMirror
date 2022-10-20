using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for KeyBindingSourceListener.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILKeyBindingSourceListener
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KeyBindingSourceListener), "Reset"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(KeyBindingSourceListener), "Reset"), value);
    }

    public static event ILContext.Manipulator Listen
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KeyBindingSourceListener), "Listen"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(KeyBindingSourceListener), "Listen"), value);
    }
}