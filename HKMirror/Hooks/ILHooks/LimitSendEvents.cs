namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for LimitSendEvents.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILLimitSendEvents
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.LimitSendEvents.OnEnable += value;
        remove => IL.LimitSendEvents.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.LimitSendEvents.Update += value;
        remove => IL.LimitSendEvents.Update -= value;
    }

    public static event ILContext.Manipulator Add
    {
        add => IL.LimitSendEvents.Add += value;
        remove => IL.LimitSendEvents.Add -= value;
    }
}