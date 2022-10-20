namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GGCheckIfBossSequenceCompleted.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGGCheckIfBossSequenceCompleted
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.GGCheckIfBossSequenceCompleted.Reset += value;
        remove => IL.GGCheckIfBossSequenceCompleted.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.GGCheckIfBossSequenceCompleted.OnEnter += value;
        remove => IL.GGCheckIfBossSequenceCompleted.OnEnter -= value;
    }
}