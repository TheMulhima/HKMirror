namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ConveyorZone.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILConveyorZone
{
    public static event ILContext.Manipulator Start
    {
        add => IL.ConveyorZone.Start += value;
        remove => IL.ConveyorZone.Start -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.ConveyorZone.OnTriggerEnter2D += value;
        remove => IL.ConveyorZone.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerExit2D
    {
        add => IL.ConveyorZone.OnTriggerExit2D += value;
        remove => IL.ConveyorZone.OnTriggerExit2D -= value;
    }
}