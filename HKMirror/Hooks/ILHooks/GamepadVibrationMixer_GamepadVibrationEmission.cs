using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GamepadVibrationMixer_GamepadVibrationEmission,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGamepadVibrationMixer_GamepadVibrationEmission
{
    public static event ILContext.Manipulator get_IsLooping
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "get_IsLooping"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "get_IsLooping"),
            value);
    }

    public static event ILContext.Manipulator set_IsLooping
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "set_IsLooping"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "set_IsLooping"),
            value);
    }

    public static event ILContext.Manipulator get_IsPlaying
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "get_IsPlaying"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "get_IsPlaying"),
            value);
    }

    public static event ILContext.Manipulator get_Tag
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "get_Tag"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "get_Tag"), value);
    }

    public static event ILContext.Manipulator set_Tag
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "set_Tag"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "set_Tag"), value);
    }

    public static event ILContext.Manipulator get_Target
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "get_Target"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "get_Target"),
            value);
    }

    public static event ILContext.Manipulator set_Target
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "set_Target"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "set_Target"),
            value);
    }

    public static event ILContext.Manipulator Stop
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "Stop"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "Stop"), value);
    }

    public static event ILContext.Manipulator Advance
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "Advance"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "Advance"), value);
    }
}