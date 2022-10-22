using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MusicCue_MusicChannelInfo,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMusicCue_MusicChannelInfo
{
    public static event ILContext.Manipulator get_Clip
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MusicCue.MusicChannelInfo), "get_Clip"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MusicCue.MusicChannelInfo), "get_Clip"), value);
    }

    public static event ILContext.Manipulator get_IsEnabled
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MusicCue.MusicChannelInfo), "get_IsEnabled"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MusicCue.MusicChannelInfo), "get_IsEnabled"), value);
    }

    public static event ILContext.Manipulator get_IsSyncRequired
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MusicCue.MusicChannelInfo), "get_IsSyncRequired"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MusicCue.MusicChannelInfo), "get_IsSyncRequired"), value);
    }
}