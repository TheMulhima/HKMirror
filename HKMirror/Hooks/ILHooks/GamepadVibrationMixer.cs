using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GamepadVibrationMixer.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGamepadVibrationMixer
{
    public static event ILContext.Manipulator get_IsPaused
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer), "get_IsPaused"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer), "get_IsPaused"), value);
    }

    public static event ILContext.Manipulator set_IsPaused
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer), "set_IsPaused"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer), "set_IsPaused"), value);
    }

    public static event ILContext.Manipulator get_PlayingEmissionCount
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer), "get_PlayingEmissionCount"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer), "get_PlayingEmissionCount"), value);
    }

    public static event ILContext.Manipulator GetPlayingEmission
    {
        add => IL.GamepadVibrationMixer.GetPlayingEmission += value;
        remove => IL.GamepadVibrationMixer.GetPlayingEmission -= value;
    }

    public static event ILContext.Manipulator PlayEmission
    {
        add => IL.GamepadVibrationMixer.PlayEmission += value;
        remove => IL.GamepadVibrationMixer.PlayEmission -= value;
    }

    public static event ILContext.Manipulator StopAllEmissions
    {
        add => IL.GamepadVibrationMixer.StopAllEmissions += value;
        remove => IL.GamepadVibrationMixer.StopAllEmissions -= value;
    }

    public static event ILContext.Manipulator StopAllEmissionsWithTag
    {
        add => IL.GamepadVibrationMixer.StopAllEmissionsWithTag += value;
        remove => IL.GamepadVibrationMixer.StopAllEmissionsWithTag -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.GamepadVibrationMixer.Update += value;
        remove => IL.GamepadVibrationMixer.Update -= value;
    }

    public static event ILContext.Manipulator AdjustForPlatform
    {
        add => IL.GamepadVibrationMixer.AdjustForPlatform += value;
        remove => IL.GamepadVibrationMixer.AdjustForPlatform -= value;
    }
}