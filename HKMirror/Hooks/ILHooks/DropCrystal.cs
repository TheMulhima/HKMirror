namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for DropCrystal.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDropCrystal
{
    public static event ILContext.Manipulator Start
    {
        add => IL.DropCrystal.Start += value;
        remove => IL.DropCrystal.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.DropCrystal.OnEnable += value;
        remove => IL.DropCrystal.OnEnable -= value;
    }

    public static event ILContext.Manipulator FixedUpdate
    {
        add => IL.DropCrystal.FixedUpdate += value;
        remove => IL.DropCrystal.FixedUpdate -= value;
    }

    public static event ILContext.Manipulator OnCollisionEnter2D
    {
        add => IL.DropCrystal.OnCollisionEnter2D += value;
        remove => IL.DropCrystal.OnCollisionEnter2D -= value;
    }

    public static event ILContext.Manipulator LateUpdate
    {
        add => IL.DropCrystal.LateUpdate += value;
        remove => IL.DropCrystal.LateUpdate -= value;
    }

    public static event ILContext.Manipulator StartConveyorMove
    {
        add => IL.DropCrystal.StartConveyorMove += value;
        remove => IL.DropCrystal.StartConveyorMove -= value;
    }

    public static event ILContext.Manipulator StopConveyorMove
    {
        add => IL.DropCrystal.StopConveyorMove += value;
        remove => IL.DropCrystal.StopConveyorMove -= value;
    }
}