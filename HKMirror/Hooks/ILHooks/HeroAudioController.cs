using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for HeroAudioController.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILHeroAudioController
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.HeroAudioController.Awake += value;
        remove => IL.HeroAudioController.Awake -= value;
    }

    public static event ILContext.Manipulator PlaySound
    {
        add => IL.HeroAudioController.PlaySound += value;
        remove => IL.HeroAudioController.PlaySound -= value;
    }

    public static event ILContext.Manipulator StopSound
    {
        add => IL.HeroAudioController.StopSound += value;
        remove => IL.HeroAudioController.StopSound -= value;
    }

    public static event ILContext.Manipulator StopAllSounds
    {
        add => IL.HeroAudioController.StopAllSounds += value;
        remove => IL.HeroAudioController.StopAllSounds -= value;
    }

    public static event ILContext.Manipulator PauseAllSounds
    {
        add => IL.HeroAudioController.PauseAllSounds += value;
        remove => IL.HeroAudioController.PauseAllSounds -= value;
    }

    public static event ILContext.Manipulator UnPauseAllSounds
    {
        add => IL.HeroAudioController.UnPauseAllSounds += value;
        remove => IL.HeroAudioController.UnPauseAllSounds -= value;
    }

    public static event ILContext.Manipulator RandomizePitch
    {
        add => IL.HeroAudioController.RandomizePitch += value;
        remove => IL.HeroAudioController.RandomizePitch -= value;
    }

    public static event ILContext.Manipulator ResetPitch
    {
        add => IL.HeroAudioController.ResetPitch += value;
        remove => IL.HeroAudioController.ResetPitch -= value;
    }

    public static event ILContext.Manipulator FadeInVolume
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HeroAudioController), "FadeInVolume").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HeroAudioController), "FadeInVolume").GetStateMachineTarget(), value);
    }
}