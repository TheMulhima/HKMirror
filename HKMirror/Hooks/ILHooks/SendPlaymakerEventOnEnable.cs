namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SendPlaymakerEventOnEnable.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSendPlaymakerEventOnEnable
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.SendPlaymakerEventOnEnable.OnEnable += value;
        remove => IL.SendPlaymakerEventOnEnable.OnEnable -= value;
    }
}