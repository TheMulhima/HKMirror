using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for DeviceBindingSourceListener.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDeviceBindingSourceListener
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSourceListener), "Reset"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSourceListener), "Reset"), value);
    }

    public static event ILContext.Manipulator Listen
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSourceListener), "Listen"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSourceListener), "Listen"), value);
    }

    public static event ILContext.Manipulator IsPressed_InputControl
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSourceListener), "IsPressed"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSourceListener), "IsPressed"), value);
    }

    public static event ILContext.Manipulator IsPressed_InputControlType_InputDevice
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSourceListener), "IsPressed"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSourceListener), "IsPressed"), value);
    }

    public static event ILContext.Manipulator ListenForControl
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSourceListener), "ListenForControl"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSourceListener), "ListenForControl"), value);
    }
}