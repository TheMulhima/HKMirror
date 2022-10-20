namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TriggerEnterEventSubscribe.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTriggerEnterEventSubscribe
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.TriggerEnterEventSubscribe.Reset += value;
        remove => IL.TriggerEnterEventSubscribe.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.TriggerEnterEventSubscribe.OnEnter += value;
        remove => IL.TriggerEnterEventSubscribe.OnEnter -= value;
    }

    public static event ILContext.Manipulator OnExit
    {
        add => IL.TriggerEnterEventSubscribe.OnExit += value;
        remove => IL.TriggerEnterEventSubscribe.OnExit -= value;
    }

    public static event ILContext.Manipulator SendEnteredEvent
    {
        add => IL.TriggerEnterEventSubscribe.SendEnteredEvent += value;
        remove => IL.TriggerEnterEventSubscribe.SendEnteredEvent -= value;
    }

    public static event ILContext.Manipulator SendExitedEvent
    {
        add => IL.TriggerEnterEventSubscribe.SendExitedEvent += value;
        remove => IL.TriggerEnterEventSubscribe.SendExitedEvent -= value;
    }

    public static event ILContext.Manipulator SendStayedEvent
    {
        add => IL.TriggerEnterEventSubscribe.SendStayedEvent += value;
        remove => IL.TriggerEnterEventSubscribe.SendStayedEvent -= value;
    }
}