using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SwitchSimpleInputDeviceManager.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSwitchSimpleInputDeviceManager
{
    public static event ILContext.Manipulator get_Device
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SwitchSimpleInputDeviceManager), "get_Device"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SwitchSimpleInputDeviceManager), "get_Device"), value);
    }

    public static event ILContext.Manipulator Update
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SwitchSimpleInputDeviceManager), "Update"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SwitchSimpleInputDeviceManager), "Update"), value);
    }

    public static event ILContext.Manipulator CheckPlatformSupport
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SwitchSimpleInputDeviceManager), "CheckPlatformSupport", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SwitchSimpleInputDeviceManager), "CheckPlatformSupport", false),
            value);
    }

    public static event ILContext.Manipulator Enable
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SwitchSimpleInputDeviceManager), "Enable", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SwitchSimpleInputDeviceManager), "Enable", false), value);
    }
}