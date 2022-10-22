namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BossStatueCompletionStates,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBossStatueCompletionStates
{
    public static event ILContext.Manipulator OnValidate
    {
        add => IL.BossStatueCompletionStates.OnValidate += value;
        remove => IL.BossStatueCompletionStates.OnValidate -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.BossStatueCompletionStates.Start += value;
        remove => IL.BossStatueCompletionStates.Start -= value;
    }

    public static event ILContext.Manipulator GetHighestCompletedTier
    {
        add => IL.BossStatueCompletionStates.GetHighestCompletedTier += value;
        remove => IL.BossStatueCompletionStates.GetHighestCompletedTier -= value;
    }

    public static event ILContext.Manipulator GetIsTierCompleted
    {
        add => IL.BossStatueCompletionStates.GetIsTierCompleted += value;
        remove => IL.BossStatueCompletionStates.GetIsTierCompleted -= value;
    }

    public static event ILContext.Manipulator CountCompletion
    {
        add => IL.BossStatueCompletionStates.CountCompletion += value;
        remove => IL.BossStatueCompletionStates.CountCompletion -= value;
    }

    public static event ILContext.Manipulator HasCompletedTier
    {
        add => IL.BossStatueCompletionStates.HasCompletedTier += value;
        remove => IL.BossStatueCompletionStates.HasCompletedTier -= value;
    }
}