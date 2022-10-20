using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for UnknownDeviceBindingSourceListener.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILUnknownDeviceBindingSourceListener
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnknownDeviceBindingSourceListener), "Reset"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnknownDeviceBindingSourceListener), "Reset"), value);
    }

    public static event ILContext.Manipulator TakeSnapshotOnUnknownDevices
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnknownDeviceBindingSourceListener), "TakeSnapshotOnUnknownDevices"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnknownDeviceBindingSourceListener), "TakeSnapshotOnUnknownDevices"),
            value);
    }

    public static event ILContext.Manipulator Listen
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnknownDeviceBindingSourceListener), "Listen"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnknownDeviceBindingSourceListener), "Listen"), value);
    }

    public static event ILContext.Manipulator IsPressed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnknownDeviceBindingSourceListener), "IsPressed"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnknownDeviceBindingSourceListener), "IsPressed"), value);
    }

    public static event ILContext.Manipulator ListenForControl
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnknownDeviceBindingSourceListener), "ListenForControl"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnknownDeviceBindingSourceListener), "ListenForControl"), value);
    }
}