using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CinematicVideoPlayerConfig.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCinematicVideoPlayerConfig
{
    public static event ILContext.Manipulator get_VideoReference
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicVideoPlayerConfig), "get_VideoReference"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicVideoPlayerConfig), "get_VideoReference"), value);
    }

    public static event ILContext.Manipulator get_MeshRenderer
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicVideoPlayerConfig), "get_MeshRenderer"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicVideoPlayerConfig), "get_MeshRenderer"), value);
    }

    public static event ILContext.Manipulator get_AudioSource
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicVideoPlayerConfig), "get_AudioSource"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicVideoPlayerConfig), "get_AudioSource"), value);
    }

    public static event ILContext.Manipulator get_FaderStyle
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicVideoPlayerConfig), "get_FaderStyle"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicVideoPlayerConfig), "get_FaderStyle"), value);
    }

    public static event ILContext.Manipulator get_ImplicitVolume
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicVideoPlayerConfig), "get_ImplicitVolume"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicVideoPlayerConfig), "get_ImplicitVolume"), value);
    }
}