using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MusicCue.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMusicCue
{
    public static event ILContext.Manipulator get_OriginalMusicEventName
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MusicCue), "get_OriginalMusicEventName"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MusicCue), "get_OriginalMusicEventName"), value);
    }

    public static event ILContext.Manipulator get_OriginalMusicTrackNumber
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MusicCue), "get_OriginalMusicTrackNumber"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MusicCue), "get_OriginalMusicTrackNumber"), value);
    }

    public static event ILContext.Manipulator get_Snapshot
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MusicCue), "get_Snapshot"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MusicCue), "get_Snapshot"), value);
    }

    public static event ILContext.Manipulator ResolveAlternatives
    {
        add => IL.MusicCue.ResolveAlternatives += value;
        remove => IL.MusicCue.ResolveAlternatives -= value;
    }
}