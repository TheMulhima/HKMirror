using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for UnityInputDevice.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILUnityInputDevice
{
    public static event ILContext.Manipulator get_JoystickId
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "get_JoystickId"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "get_JoystickId"), value);
    }

    public static event ILContext.Manipulator set_JoystickId
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "set_JoystickId"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "set_JoystickId"), value);
    }

    public static event ILContext.Manipulator Update
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "Update"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "Update"),
            value);
    }

    public static event ILContext.Manipulator SetupAnalogQueries
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "SetupAnalogQueries", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "SetupAnalogQueries", false), value);
    }

    public static event ILContext.Manipulator SetupButtonQueries
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "SetupButtonQueries", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "SetupButtonQueries", false), value);
    }

    public static event ILContext.Manipulator ReadRawButtonState
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "ReadRawButtonState"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "ReadRawButtonState"), value);
    }

    public static event ILContext.Manipulator ReadRawAnalogValue
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "ReadRawAnalogValue"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "ReadRawAnalogValue"), value);
    }

    public static event ILContext.Manipulator get_IsSupportedOnThisPlatform
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "get_IsSupportedOnThisPlatform"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "get_IsSupportedOnThisPlatform"), value);
    }

    public static event ILContext.Manipulator get_IsKnown
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "get_IsKnown"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "get_IsKnown"),
            value);
    }

    public static event ILContext.Manipulator get_NumUnknownButtons
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "get_NumUnknownButtons"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "get_NumUnknownButtons"), value);
    }

    public static event ILContext.Manipulator get_NumUnknownAnalogs
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "get_NumUnknownAnalogs"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityInputDevice), "get_NumUnknownAnalogs"), value);
    }
}