namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CheckSendEventLimit.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCheckSendEventLimit
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.CheckSendEventLimit.Reset += value;
        remove => IL.CheckSendEventLimit.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.CheckSendEventLimit.OnEnter += value;
        remove => IL.CheckSendEventLimit.OnEnter -= value;
    }
}