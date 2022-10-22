namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Walker,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILWalker
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.Walker.Awake += value;
        remove => IL.Walker.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.Walker.Start += value;
        remove => IL.Walker.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.Walker.Update += value;
        remove => IL.Walker.Update -= value;
    }

    public static event ILContext.Manipulator StartMoving
    {
        add => IL.Walker.StartMoving += value;
        remove => IL.Walker.StartMoving -= value;
    }

    public static event ILContext.Manipulator CancelTurn
    {
        add => IL.Walker.CancelTurn += value;
        remove => IL.Walker.CancelTurn -= value;
    }

    public static event ILContext.Manipulator Go
    {
        add => IL.Walker.Go += value;
        remove => IL.Walker.Go -= value;
    }

    public static event ILContext.Manipulator RecieveGoMessage
    {
        add => IL.Walker.RecieveGoMessage += value;
        remove => IL.Walker.RecieveGoMessage -= value;
    }

    public static event ILContext.Manipulator Stop
    {
        add => IL.Walker.Stop += value;
        remove => IL.Walker.Stop -= value;
    }

    public static event ILContext.Manipulator ChangeFacing
    {
        add => IL.Walker.ChangeFacing += value;
        remove => IL.Walker.ChangeFacing -= value;
    }

    public static event ILContext.Manipulator BeginWaitingForConditions
    {
        add => IL.Walker.BeginWaitingForConditions += value;
        remove => IL.Walker.BeginWaitingForConditions -= value;
    }

    public static event ILContext.Manipulator UpdateWaitingForConditions
    {
        add => IL.Walker.UpdateWaitingForConditions += value;
        remove => IL.Walker.UpdateWaitingForConditions -= value;
    }

    public static event ILContext.Manipulator BeginStopped
    {
        add => IL.Walker.BeginStopped += value;
        remove => IL.Walker.BeginStopped -= value;
    }

    public static event ILContext.Manipulator UpdateStopping
    {
        add => IL.Walker.UpdateStopping += value;
        remove => IL.Walker.UpdateStopping -= value;
    }

    public static event ILContext.Manipulator EndStopping
    {
        add => IL.Walker.EndStopping += value;
        remove => IL.Walker.EndStopping -= value;
    }

    public static event ILContext.Manipulator BeginWalkingOrTurning
    {
        add => IL.Walker.BeginWalkingOrTurning += value;
        remove => IL.Walker.BeginWalkingOrTurning -= value;
    }

    public static event ILContext.Manipulator BeginWalking
    {
        add => IL.Walker.BeginWalking += value;
        remove => IL.Walker.BeginWalking -= value;
    }

    public static event ILContext.Manipulator UpdateWalking
    {
        add => IL.Walker.UpdateWalking += value;
        remove => IL.Walker.UpdateWalking -= value;
    }

    public static event ILContext.Manipulator BeginTurning
    {
        add => IL.Walker.BeginTurning += value;
        remove => IL.Walker.BeginTurning -= value;
    }

    public static event ILContext.Manipulator UpdateTurning
    {
        add => IL.Walker.UpdateTurning += value;
        remove => IL.Walker.UpdateTurning -= value;
    }

    public static event ILContext.Manipulator EndTurning
    {
        add => IL.Walker.EndTurning += value;
        remove => IL.Walker.EndTurning -= value;
    }

    public static event ILContext.Manipulator ClearTurnCooldown
    {
        add => IL.Walker.ClearTurnCooldown += value;
        remove => IL.Walker.ClearTurnCooldown -= value;
    }
}