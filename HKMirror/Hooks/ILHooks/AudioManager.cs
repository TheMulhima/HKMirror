using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for AudioManager.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILAudioManager
{
    public static event ILContext.Manipulator get_CurrentMusicCue
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(AudioManager), "get_CurrentMusicCue"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(AudioManager), "get_CurrentMusicCue"), value);
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.AudioManager.Start += value;
        remove => IL.AudioManager.Start -= value;
    }

    public static event ILContext.Manipulator ApplyAtmosCue
    {
        add => IL.AudioManager.ApplyAtmosCue += value;
        remove => IL.AudioManager.ApplyAtmosCue -= value;
    }

    public static event ILContext.Manipulator BeginApplyAtmosCue
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(AudioManager), "BeginApplyAtmosCue").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(AudioManager), "BeginApplyAtmosCue").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator ApplyMusicCue
    {
        add => IL.AudioManager.ApplyMusicCue += value;
        remove => IL.AudioManager.ApplyMusicCue -= value;
    }

    public static event ILContext.Manipulator BeginApplyMusicCue
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(AudioManager), "BeginApplyMusicCue").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(AudioManager), "BeginApplyMusicCue").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator UpdateMusicSync
    {
        add => IL.AudioManager.UpdateMusicSync += value;
        remove => IL.AudioManager.UpdateMusicSync -= value;
    }

    public static event ILContext.Manipulator ApplyMusicSnapshot
    {
        add => IL.AudioManager.ApplyMusicSnapshot += value;
        remove => IL.AudioManager.ApplyMusicSnapshot -= value;
    }

    public static event ILContext.Manipulator BeginApplyMusicSnapshot
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(AudioManager), "BeginApplyMusicSnapshot").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(AudioManager), "BeginApplyMusicSnapshot").GetStateMachineTarget(),
            value);
    }
}