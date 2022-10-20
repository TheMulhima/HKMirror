using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MouseBindingSourceListener.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMouseBindingSourceListener
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MouseBindingSourceListener), "Reset"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MouseBindingSourceListener), "Reset"), value);
    }

    public static event ILContext.Manipulator Listen
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MouseBindingSourceListener), "Listen"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MouseBindingSourceListener), "Listen"), value);
    }

    public static event ILContext.Manipulator IsPressed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MouseBindingSourceListener), "IsPressed"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MouseBindingSourceListener), "IsPressed"), value);
    }

    public static event ILContext.Manipulator ListenForControl
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MouseBindingSourceListener), "ListenForControl"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MouseBindingSourceListener), "ListenForControl"), value);
    }
}