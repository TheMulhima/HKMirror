using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GamepadVibration.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGamepadVibration
{
    public static event ILContext.Manipulator get_SmallMotor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GamepadVibration), "get_SmallMotor"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GamepadVibration), "get_SmallMotor"), value);
    }

    public static event ILContext.Manipulator get_LargeMotor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GamepadVibration), "get_LargeMotor"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GamepadVibration), "get_LargeMotor"), value);
    }

    public static event ILContext.Manipulator get_PlaybackRate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GamepadVibration), "get_PlaybackRate"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GamepadVibration), "get_PlaybackRate"), value);
    }

    public static event ILContext.Manipulator Reset
    {
        add => IL.GamepadVibration.Reset += value;
        remove => IL.GamepadVibration.Reset -= value;
    }

    public static event ILContext.Manipulator GetDuration
    {
        add => IL.GamepadVibration.GetDuration += value;
        remove => IL.GamepadVibration.GetDuration -= value;
    }

    public static event ILContext.Manipulator GetDuration_AnimationCurve
    {
        add => IL.GamepadVibration.GetDuration_AnimationCurve += value;
        remove => IL.GamepadVibration.GetDuration_AnimationCurve -= value;
    }
}