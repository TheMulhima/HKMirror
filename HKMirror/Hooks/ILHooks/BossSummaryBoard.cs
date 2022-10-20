namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BossSummaryBoard.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBossSummaryBoard
{
    public static event ILContext.Manipulator Start
    {
        add => IL.BossSummaryBoard.Start += value;
        remove => IL.BossSummaryBoard.Start -= value;
    }

    public static event ILContext.Manipulator Show
    {
        add => IL.BossSummaryBoard.Show += value;
        remove => IL.BossSummaryBoard.Show -= value;
    }

    public static event ILContext.Manipulator Hide
    {
        add => IL.BossSummaryBoard.Hide += value;
        remove => IL.BossSummaryBoard.Hide -= value;
    }
}