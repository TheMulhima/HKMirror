using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for NativeInputDeviceManager.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILNativeInputDeviceManager
{
    public static event ILContext.Manipulator Destroy
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "Destroy"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "Destroy"), value);
    }

    public static event ILContext.Manipulator Update
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "Update"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "Update"), value);
    }

    public static event ILContext.Manipulator DetectDevice
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "DetectDevice"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "DetectDevice"), value);
    }

    public static event ILContext.Manipulator AttachDevice
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "AttachDevice"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "AttachDevice"), value);
    }

    public static event ILContext.Manipulator DetachDevice
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "DetachDevice"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "DetachDevice"), value);
    }

    public static event ILContext.Manipulator FindAttachedDevice
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "FindAttachedDevice"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "FindAttachedDevice"), value);
    }

    public static event ILContext.Manipulator FindDetachedDevice
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "FindDetachedDevice"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "FindDetachedDevice"), value);
    }

    public static event ILContext.Manipulator SystemFindDetachedDevice
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "SystemFindDetachedDevice", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "SystemFindDetachedDevice", false), value);
    }

    public static event ILContext.Manipulator AddSystemDeviceProfile
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "AddSystemDeviceProfile"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "AddSystemDeviceProfile"), value);
    }

    public static event ILContext.Manipulator AddSystemDeviceProfiles
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "AddSystemDeviceProfiles"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "AddSystemDeviceProfiles"), value);
    }

    public static event ILContext.Manipulator CheckPlatformSupport
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "CheckPlatformSupport", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "CheckPlatformSupport", false), value);
    }

    public static event ILContext.Manipulator Enable
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "Enable", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDeviceManager), "Enable", false), value);
    }
}