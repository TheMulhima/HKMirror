namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ConveyorMovement.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILConveyorMovement
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.ConveyorMovement.OnEnable += value;
        remove => IL.ConveyorMovement.OnEnable -= value;
    }

    public static event ILContext.Manipulator StartConveyorMove
    {
        add => IL.ConveyorMovement.StartConveyorMove += value;
        remove => IL.ConveyorMovement.StartConveyorMove -= value;
    }

    public static event ILContext.Manipulator StopConveyorMove
    {
        add => IL.ConveyorMovement.StopConveyorMove += value;
        remove => IL.ConveyorMovement.StopConveyorMove -= value;
    }

    public static event ILContext.Manipulator LateUpdate
    {
        add => IL.ConveyorMovement.LateUpdate += value;
        remove => IL.ConveyorMovement.LateUpdate -= value;
    }
}