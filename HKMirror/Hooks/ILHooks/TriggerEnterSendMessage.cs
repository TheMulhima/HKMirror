namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TriggerEnterSendMessage.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTriggerEnterSendMessage
{
    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.TriggerEnterSendMessage.OnTriggerEnter2D += value;
        remove => IL.TriggerEnterSendMessage.OnTriggerEnter2D -= value;
    }
}