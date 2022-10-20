using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PS4SimpleInputDeviceManager.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPS4SimpleInputDeviceManager
{
    public static event ILContext.Manipulator get_Device
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDeviceManager), "get_Device"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDeviceManager), "get_Device"), value);
    }

    public static event ILContext.Manipulator Update
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDeviceManager), "Update"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDeviceManager), "Update"), value);
    }

    public static event ILContext.Manipulator CheckPlatformSupport
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDeviceManager), "CheckPlatformSupport", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDeviceManager), "CheckPlatformSupport", false), value);
    }

    public static event ILContext.Manipulator Enable
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDeviceManager), "Enable", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDeviceManager), "Enable", false), value);
    }
}