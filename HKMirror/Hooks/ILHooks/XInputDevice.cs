using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for XInputDevice.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILXInputDevice
{
    public static event ILContext.Manipulator get_DeviceIndex
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XInputDevice), "get_DeviceIndex"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(XInputDevice), "get_DeviceIndex"),
            value);
    }

    public static event ILContext.Manipulator set_DeviceIndex
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XInputDevice), "set_DeviceIndex"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(XInputDevice), "set_DeviceIndex"),
            value);
    }

    public static event ILContext.Manipulator Update
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XInputDevice), "Update"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(XInputDevice), "Update"), value);
    }

    public static event ILContext.Manipulator Vibrate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XInputDevice), "Vibrate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(XInputDevice), "Vibrate"), value);
    }

    public static event ILContext.Manipulator GetState
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XInputDevice), "GetState"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(XInputDevice), "GetState"), value);
    }

    public static event ILContext.Manipulator get_IsConnected
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XInputDevice), "get_IsConnected"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(XInputDevice), "get_IsConnected"),
            value);
    }
}