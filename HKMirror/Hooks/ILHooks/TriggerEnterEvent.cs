namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TriggerEnterEvent.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTriggerEnterEvent
{
    public static event ILContext.Manipulator Start
    {
        add => IL.TriggerEnterEvent.Start += value;
        remove => IL.TriggerEnterEvent.Start -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.TriggerEnterEvent.OnTriggerEnter2D += value;
        remove => IL.TriggerEnterEvent.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerExit2D
    {
        add => IL.TriggerEnterEvent.OnTriggerExit2D += value;
        remove => IL.TriggerEnterEvent.OnTriggerExit2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerStay2D
    {
        add => IL.TriggerEnterEvent.OnTriggerStay2D += value;
        remove => IL.TriggerEnterEvent.OnTriggerStay2D -= value;
    }
}