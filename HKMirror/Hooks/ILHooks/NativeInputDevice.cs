using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for NativeInputDevice.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILNativeInputDevice
{
    public static event ILContext.Manipulator get_Handle
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "get_Handle"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "get_Handle"),
            value);
    }

    public static event ILContext.Manipulator set_Handle
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "set_Handle"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "set_Handle"),
            value);
    }

    public static event ILContext.Manipulator get_Info
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "get_Info"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "get_Info"),
            value);
    }

    public static event ILContext.Manipulator set_Info
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "set_Info"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "set_Info"),
            value);
    }

    public static event ILContext.Manipulator Initialize_UInt32_InputDeviceInfo_InputDeviceProfile
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "Initialize"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "Initialize"),
            value);
    }

    public static event ILContext.Manipulator Initialize_UInt32_InputDeviceInfo
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "Initialize"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "Initialize"),
            value);
    }

    public static event ILContext.Manipulator Update
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "Update"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "Update"),
            value);
    }

    public static event ILContext.Manipulator ReadRawButtonState
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "ReadRawButtonState"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "ReadRawButtonState"), value);
    }

    public static event ILContext.Manipulator ReadRawAnalogValue
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "ReadRawAnalogValue"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "ReadRawAnalogValue"), value);
    }

    public static event ILContext.Manipulator FloatToByte
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "FloatToByte", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "FloatToByte", false), value);
    }

    public static event ILContext.Manipulator Vibrate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "Vibrate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "Vibrate"),
            value);
    }

    public static event ILContext.Manipulator SetLightColor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "SetLightColor"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "SetLightColor"), value);
    }

    public static event ILContext.Manipulator SetLightFlash
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "SetLightFlash"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "SetLightFlash"), value);
    }

    public static event ILContext.Manipulator GetAppleGlyphNameForControl
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "GetAppleGlyphNameForControl"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "GetAppleGlyphNameForControl"), value);
    }

    public static event ILContext.Manipulator HasSameVendorID
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "HasSameVendorID"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "HasSameVendorID"), value);
    }

    public static event ILContext.Manipulator HasSameProductID
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "HasSameProductID"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "HasSameProductID"), value);
    }

    public static event ILContext.Manipulator HasSameVersionNumber
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "HasSameVersionNumber"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "HasSameVersionNumber"), value);
    }

    public static event ILContext.Manipulator HasSameLocation
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "HasSameLocation"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "HasSameLocation"), value);
    }

    public static event ILContext.Manipulator HasSameSerialNumber
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "HasSameSerialNumber"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "HasSameSerialNumber"), value);
    }

    public static event ILContext.Manipulator get_IsSupportedOnThisPlatform
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "get_IsSupportedOnThisPlatform"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "get_IsSupportedOnThisPlatform"), value);
    }

    public static event ILContext.Manipulator get_IsKnown
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "get_IsKnown"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "get_IsKnown"),
            value);
    }

    public static event ILContext.Manipulator get_NumUnknownButtons
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "get_NumUnknownButtons"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "get_NumUnknownButtons"), value);
    }

    public static event ILContext.Manipulator get_NumUnknownAnalogs
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "get_NumUnknownAnalogs"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(NativeInputDevice), "get_NumUnknownAnalogs"), value);
    }
}