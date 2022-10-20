namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for EnemyDreamnailReaction.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILEnemyDreamnailReaction
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.EnemyDreamnailReaction.Reset += value;
        remove => IL.EnemyDreamnailReaction.Reset -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.EnemyDreamnailReaction.Start += value;
        remove => IL.EnemyDreamnailReaction.Start -= value;
    }

    public static event ILContext.Manipulator RecieveDreamImpact
    {
        add => IL.EnemyDreamnailReaction.RecieveDreamImpact += value;
        remove => IL.EnemyDreamnailReaction.RecieveDreamImpact -= value;
    }

    public static event ILContext.Manipulator MakeReady
    {
        add => IL.EnemyDreamnailReaction.MakeReady += value;
        remove => IL.EnemyDreamnailReaction.MakeReady -= value;
    }

    public static event ILContext.Manipulator SetConvoTitle
    {
        add => IL.EnemyDreamnailReaction.SetConvoTitle += value;
        remove => IL.EnemyDreamnailReaction.SetConvoTitle -= value;
    }

    public static event ILContext.Manipulator ShowConvo
    {
        add => IL.EnemyDreamnailReaction.ShowConvo += value;
        remove => IL.EnemyDreamnailReaction.ShowConvo -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.EnemyDreamnailReaction.Update += value;
        remove => IL.EnemyDreamnailReaction.Update -= value;
    }
}