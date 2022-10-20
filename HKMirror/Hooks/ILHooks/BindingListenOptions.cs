using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BindingListenOptions.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBindingListenOptions
{
    public static event ILContext.Manipulator CallOnBindingFound
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BindingListenOptions), "CallOnBindingFound"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BindingListenOptions), "CallOnBindingFound"), value);
    }

    public static event ILContext.Manipulator CallOnBindingAdded
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BindingListenOptions), "CallOnBindingAdded"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BindingListenOptions), "CallOnBindingAdded"), value);
    }

    public static event ILContext.Manipulator CallOnBindingRejected
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BindingListenOptions), "CallOnBindingRejected"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BindingListenOptions), "CallOnBindingRejected"), value);
    }

    public static event ILContext.Manipulator CallOnBindingEnded
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BindingListenOptions), "CallOnBindingEnded"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BindingListenOptions), "CallOnBindingEnded"), value);
    }
}