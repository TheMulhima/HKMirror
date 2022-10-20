using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PS4SimpleInputDevice.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPS4SimpleInputDevice
{
    public static event ILContext.Manipulator Update
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDevice), "Update"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDevice), "Update"),
            value);
    }

    public static event ILContext.Manipulator GetNativeVibrationValue
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDevice), "GetNativeVibrationValue", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDevice), "GetNativeVibrationValue", false), value);
    }

    public static event ILContext.Manipulator get_IsConnected
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDevice), "get_IsConnected"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDevice), "get_IsConnected"), value);
    }

    public static event ILContext.Manipulator GetVibrationMixer
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDevice),
                "VibrationManager.IVibrationMixerProvider.GetVibrationMixer"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PS4SimpleInputDevice),
                "VibrationManager.IVibrationMixerProvider.GetVibrationMixer"), value);
    }
}