using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.ILHooks;
/// <summary>
/// Contains all correct IL Hooks for GamepadVibrationMixer_GamepadVibrationEmission,
/// Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
/// Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGamepadVibrationMixer_GamepadVibrationEmission
{
public static event ILContext.Manipulator get_IsLooping
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "get_IsLooping", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "get_IsLooping", true), value);
}
public static event ILContext.Manipulator set_IsLooping
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "set_IsLooping", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "set_IsLooping", true), value);
}
public static event ILContext.Manipulator get_IsPlaying
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "get_IsPlaying", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "get_IsPlaying", true), value);
}
public static event ILContext.Manipulator get_Tag
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "get_Tag", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "get_Tag", true), value);
}
public static event ILContext.Manipulator set_Tag
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "set_Tag", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "set_Tag", true), value);
}
public static event ILContext.Manipulator get_Target
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "get_Target", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "get_Target", true), value);
}
public static event ILContext.Manipulator set_Target
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "set_Target", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "set_Target", true), value);
}
public static event ILContext.Manipulator Stop
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "Stop", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "Stop", true), value);
}
public static event ILContext.Manipulator Advance
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "Advance", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GamepadVibrationMixer.GamepadVibrationEmission), "Advance", true), value);
}
}
