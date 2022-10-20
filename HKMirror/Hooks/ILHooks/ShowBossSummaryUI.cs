namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ShowBossSummaryUI.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILShowBossSummaryUI
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.ShowBossSummaryUI.Reset += value;
        remove => IL.ShowBossSummaryUI.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.ShowBossSummaryUI.OnEnter += value;
        remove => IL.ShowBossSummaryUI.OnEnter -= value;
    }
}