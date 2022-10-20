using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for VibrationPlayer.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILVibrationPlayer
{
    public static event ILContext.Manipulator get_VibrationData
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "get_VibrationData"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "get_VibrationData"), value);
    }

    public static event ILContext.Manipulator set_VibrationData
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "set_VibrationData"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "set_VibrationData"), value);
    }

    public static event ILContext.Manipulator get_Target
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "get_Target"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "get_Target"),
            value);
    }

    public static event ILContext.Manipulator set_Target
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "set_Target"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "set_Target"),
            value);
    }

    public static event ILContext.Manipulator get_PlayAutomatically
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "get_PlayAutomatically"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "get_PlayAutomatically"), value);
    }

    public static event ILContext.Manipulator set_PlayAutomatically
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "set_PlayAutomatically"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "set_PlayAutomatically"), value);
    }

    public static event ILContext.Manipulator get_IsLooping
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "get_IsLooping"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "get_IsLooping"),
            value);
    }

    public static event ILContext.Manipulator set_IsLooping
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "set_IsLooping"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "set_IsLooping"),
            value);
    }

    public static event ILContext.Manipulator get_VibrationTag
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "get_VibrationTag"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "get_VibrationTag"), value);
    }

    public static event ILContext.Manipulator set_VibrationTag
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "set_VibrationTag"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(VibrationPlayer), "set_VibrationTag"), value);
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.VibrationPlayer.OnEnable += value;
        remove => IL.VibrationPlayer.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.VibrationPlayer.OnDisable += value;
        remove => IL.VibrationPlayer.OnDisable -= value;
    }

    public static event ILContext.Manipulator Play
    {
        add => IL.VibrationPlayer.Play += value;
        remove => IL.VibrationPlayer.Play -= value;
    }

    public static event ILContext.Manipulator Stop
    {
        add => IL.VibrationPlayer.Stop += value;
        remove => IL.VibrationPlayer.Stop -= value;
    }
}