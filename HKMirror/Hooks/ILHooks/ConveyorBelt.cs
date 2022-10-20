namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ConveyorBelt.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILConveyorBelt
{
    public static event ILContext.Manipulator OnCollisionEnter2D
    {
        add => IL.ConveyorBelt.OnCollisionEnter2D += value;
        remove => IL.ConveyorBelt.OnCollisionEnter2D -= value;
    }

    public static event ILContext.Manipulator OnCollisionExit2D
    {
        add => IL.ConveyorBelt.OnCollisionExit2D += value;
        remove => IL.ConveyorBelt.OnCollisionExit2D -= value;
    }
}