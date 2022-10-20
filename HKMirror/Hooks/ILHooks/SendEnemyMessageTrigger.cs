namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SendEnemyMessageTrigger.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSendEnemyMessageTrigger
{
    public static event ILContext.Manipulator Start
    {
        add => IL.SendEnemyMessageTrigger.Start += value;
        remove => IL.SendEnemyMessageTrigger.Start -= value;
    }

    public static event ILContext.Manipulator FixedUpdate
    {
        add => IL.SendEnemyMessageTrigger.FixedUpdate += value;
        remove => IL.SendEnemyMessageTrigger.FixedUpdate -= value;
    }

    public static event ILContext.Manipulator OnTriggerStay2D
    {
        add => IL.SendEnemyMessageTrigger.OnTriggerStay2D += value;
        remove => IL.SendEnemyMessageTrigger.OnTriggerStay2D -= value;
    }

    public static event ILContext.Manipulator SendEvent
    {
        add => IL.SendEnemyMessageTrigger.SendEvent += value;
        remove => IL.SendEnemyMessageTrigger.SendEvent -= value;
    }

    public static event ILContext.Manipulator SendWalkerGoInDirection
    {
        add => IL.SendEnemyMessageTrigger.SendWalkerGoInDirection += value;
        remove => IL.SendEnemyMessageTrigger.SendWalkerGoInDirection -= value;
    }
}