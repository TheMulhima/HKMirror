namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ShowBossChallengeUI.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILShowBossChallengeUI
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.ShowBossChallengeUI.Reset += value;
        remove => IL.ShowBossChallengeUI.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.ShowBossChallengeUI.OnEnter += value;
        remove => IL.ShowBossChallengeUI.OnEnter -= value;
    }
}