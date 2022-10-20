namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for AudioSourcePitchRandomizer.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILAudioSourcePitchRandomizer
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.AudioSourcePitchRandomizer.Awake += value;
        remove => IL.AudioSourcePitchRandomizer.Awake -= value;
    }
}