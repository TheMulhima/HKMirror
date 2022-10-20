namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PlayAudioEvent.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPlayAudioEvent
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.PlayAudioEvent.Reset += value;
        remove => IL.PlayAudioEvent.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.PlayAudioEvent.OnEnter += value;
        remove => IL.PlayAudioEvent.OnEnter -= value;
    }
}