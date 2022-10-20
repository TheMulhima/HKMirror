namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ConveyorMovementHero.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILConveyorMovementHero
{
    public static event ILContext.Manipulator Start
    {
        add => IL.ConveyorMovementHero.Start += value;
        remove => IL.ConveyorMovementHero.Start -= value;
    }

    public static event ILContext.Manipulator StartConveyorMove
    {
        add => IL.ConveyorMovementHero.StartConveyorMove += value;
        remove => IL.ConveyorMovementHero.StartConveyorMove -= value;
    }

    public static event ILContext.Manipulator StopConveyorMove
    {
        add => IL.ConveyorMovementHero.StopConveyorMove += value;
        remove => IL.ConveyorMovementHero.StopConveyorMove -= value;
    }

    public static event ILContext.Manipulator LateUpdate
    {
        add => IL.ConveyorMovementHero.LateUpdate += value;
        remove => IL.ConveyorMovementHero.LateUpdate -= value;
    }
}