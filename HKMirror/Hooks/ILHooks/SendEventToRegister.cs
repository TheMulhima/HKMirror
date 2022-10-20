namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SendEventToRegister.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSendEventToRegister
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.SendEventToRegister.Reset += value;
        remove => IL.SendEventToRegister.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.SendEventToRegister.OnEnter += value;
        remove => IL.SendEventToRegister.OnEnter -= value;
    }
}