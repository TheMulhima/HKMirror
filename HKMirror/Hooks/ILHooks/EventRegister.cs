namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for EventRegister.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILEventRegister
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.EventRegister.Awake += value;
        remove => IL.EventRegister.Awake -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.EventRegister.OnDestroy += value;
        remove => IL.EventRegister.OnDestroy -= value;
    }

    public static event ILContext.Manipulator ReceiveEvent
    {
        add => IL.EventRegister.ReceiveEvent += value;
        remove => IL.EventRegister.ReceiveEvent -= value;
    }

    public static event ILContext.Manipulator SwitchEvent
    {
        add => IL.EventRegister.SwitchEvent += value;
        remove => IL.EventRegister.SwitchEvent -= value;
    }

    public static event ILContext.Manipulator SendEvent
    {
        add => IL.EventRegister.SendEvent += value;
        remove => IL.EventRegister.SendEvent -= value;
    }

    public static event ILContext.Manipulator SubscribeEvent
    {
        add => IL.EventRegister.SubscribeEvent += value;
        remove => IL.EventRegister.SubscribeEvent -= value;
    }

    public static event ILContext.Manipulator UnsubscribeEvent
    {
        add => IL.EventRegister.UnsubscribeEvent += value;
        remove => IL.EventRegister.UnsubscribeEvent -= value;
    }
}