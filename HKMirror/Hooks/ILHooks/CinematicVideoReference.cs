using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CinematicVideoReference.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCinematicVideoReference
{
    public static event ILContext.Manipulator get_VideoFileName
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicVideoReference), "get_VideoFileName"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicVideoReference), "get_VideoFileName"), value);
    }

    public static event ILContext.Manipulator get_VideoAssetPath
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicVideoReference), "get_VideoAssetPath"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicVideoReference), "get_VideoAssetPath"), value);
    }

    public static event ILContext.Manipulator get_AudioAssetPath
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicVideoReference), "get_AudioAssetPath"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicVideoReference), "get_AudioAssetPath"), value);
    }

    public static event ILContext.Manipulator get_EmbeddedVideoClip
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicVideoReference), "get_EmbeddedVideoClip"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicVideoReference), "get_EmbeddedVideoClip"), value);
    }
}