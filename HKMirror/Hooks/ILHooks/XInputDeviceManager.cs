using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for XInputDeviceManager.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILXInputDeviceManager
{
    public static event ILContext.Manipulator StartWorker
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "StartWorker"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "StartWorker"), value);
    }

    public static event ILContext.Manipulator StopWorker
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "StopWorker"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "StopWorker"), value);
    }

    public static event ILContext.Manipulator Worker
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "Worker"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "Worker"),
            value);
    }

    public static event ILContext.Manipulator GetState
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "GetState"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "GetState"),
            value);
    }

    public static event ILContext.Manipulator Update
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "Update"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "Update"),
            value);
    }

    public static event ILContext.Manipulator Destroy
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "Destroy"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "Destroy"),
            value);
    }

    public static event ILContext.Manipulator CheckPlatformSupport
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "CheckPlatformSupport", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "CheckPlatformSupport", false), value);
    }

    public static event ILContext.Manipulator Enable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "Enable", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(XInputDeviceManager), "Enable", false), value);
    }
}