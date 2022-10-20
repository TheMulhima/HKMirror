using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for UnityInputDeviceManager.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILUnityInputDeviceManager
{
    public static event ILContext.Manipulator Update
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "Update"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "Update"), value);
    }

    public static event ILContext.Manipulator QueryJoystickInfo
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "QueryJoystickInfo"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "QueryJoystickInfo"), value);
    }

    public static event ILContext.Manipulator get_JoystickInfoHasChanged
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "get_JoystickInfoHasChanged"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "get_JoystickInfoHasChanged"), value);
    }

    public static event ILContext.Manipulator AttachDevices
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "AttachDevices"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "AttachDevices"), value);
    }

    public static event ILContext.Manipulator DetachDevices
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "DetachDevices"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "DetachDevices"), value);
    }

    public static event ILContext.Manipulator ReloadDevices
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "ReloadDevices"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "ReloadDevices"), value);
    }

    public static event ILContext.Manipulator AttachDevice
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "AttachDevice"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "AttachDevice"), value);
    }

    public static event ILContext.Manipulator HasAttachedDeviceWithJoystickId
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "HasAttachedDeviceWithJoystickId"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "HasAttachedDeviceWithJoystickId"), value);
    }

    public static event ILContext.Manipulator DetectJoystickDevice
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "DetectJoystickDevice"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "DetectJoystickDevice"), value);
    }

    public static event ILContext.Manipulator DetectDevice
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "DetectDevice"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "DetectDevice"), value);
    }

    public static event ILContext.Manipulator AddSystemDeviceProfile
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "AddSystemDeviceProfile"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "AddSystemDeviceProfile"), value);
    }

    public static event ILContext.Manipulator AddSystemDeviceProfiles
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "AddSystemDeviceProfiles"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDeviceManager), "AddSystemDeviceProfiles"), value);
    }
}