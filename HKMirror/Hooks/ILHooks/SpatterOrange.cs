namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SpatterOrange.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSpatterOrange
{
    public static event ILContext.Manipulator Start
    {
        add => IL.SpatterOrange.Start += value;
        remove => IL.SpatterOrange.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.SpatterOrange.OnEnable += value;
        remove => IL.SpatterOrange.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.SpatterOrange.Update += value;
        remove => IL.SpatterOrange.Update -= value;
    }

    public static event ILContext.Manipulator Impact
    {
        add => IL.SpatterOrange.Impact += value;
        remove => IL.SpatterOrange.Impact -= value;
    }

    public static event ILContext.Manipulator FaceAngle
    {
        add => IL.SpatterOrange.FaceAngle += value;
        remove => IL.SpatterOrange.FaceAngle -= value;
    }

    public static event ILContext.Manipulator ProjectileSquash
    {
        add => IL.SpatterOrange.ProjectileSquash += value;
        remove => IL.SpatterOrange.ProjectileSquash -= value;
    }

    public static event ILContext.Manipulator OnCollisionEnter2D
    {
        add => IL.SpatterOrange.OnCollisionEnter2D += value;
        remove => IL.SpatterOrange.OnCollisionEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.SpatterOrange.OnTriggerEnter2D += value;
        remove => IL.SpatterOrange.OnTriggerEnter2D -= value;
    }
}