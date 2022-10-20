using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for XB1CinematicVideoPlayer.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILXB1CinematicVideoPlayer
{
    public static event ILContext.Manipulator Dispose
    {
        add => IL.XB1CinematicVideoPlayer.Dispose += value;
        remove => IL.XB1CinematicVideoPlayer.Dispose -= value;
    }

    public static event ILContext.Manipulator get_Volume
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "get_Volume"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "get_Volume"), value);
    }

    public static event ILContext.Manipulator set_Volume
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "set_Volume"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "set_Volume"), value);
    }

    public static event ILContext.Manipulator get_IsLoading
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "get_IsLoading"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "get_IsLoading"), value);
    }

    public static event ILContext.Manipulator get_IsLooping
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "get_IsLooping"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "get_IsLooping"), value);
    }

    public static event ILContext.Manipulator set_IsLooping
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "set_IsLooping"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "set_IsLooping"), value);
    }

    public static event ILContext.Manipulator get_IsPlaying
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "get_IsPlaying"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(XB1CinematicVideoPlayer), "get_IsPlaying"), value);
    }

    public static event ILContext.Manipulator Play
    {
        add => IL.XB1CinematicVideoPlayer.Play += value;
        remove => IL.XB1CinematicVideoPlayer.Play -= value;
    }

    public static event ILContext.Manipulator Stop
    {
        add => IL.XB1CinematicVideoPlayer.Stop += value;
        remove => IL.XB1CinematicVideoPlayer.Stop -= value;
    }

    public static event ILContext.Manipulator OnPrepareCompleted
    {
        add => IL.XB1CinematicVideoPlayer.OnPrepareCompleted += value;
        remove => IL.XB1CinematicVideoPlayer.OnPrepareCompleted -= value;
    }
}