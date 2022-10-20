namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ShowBossDoorLockedUI.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILShowBossDoorLockedUI
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.ShowBossDoorLockedUI.Reset += value;
        remove => IL.ShowBossDoorLockedUI.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.ShowBossDoorLockedUI.OnEnter += value;
        remove => IL.ShowBossDoorLockedUI.OnEnter -= value;
    }
}