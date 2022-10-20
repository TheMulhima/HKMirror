namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CheckInvincibility.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCheckInvincibility
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.CheckInvincibility.Reset += value;
        remove => IL.CheckInvincibility.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.CheckInvincibility.OnEnter += value;
        remove => IL.CheckInvincibility.OnEnter -= value;
    }
}