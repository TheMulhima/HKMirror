namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SpatterHoney.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSpatterHoney
{
    public static event ILContext.Manipulator Start
    {
        add => IL.SpatterHoney.Start += value;
        remove => IL.SpatterHoney.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.SpatterHoney.OnEnable += value;
        remove => IL.SpatterHoney.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.SpatterHoney.Update += value;
        remove => IL.SpatterHoney.Update -= value;
    }

    public static event ILContext.Manipulator Impact
    {
        add => IL.SpatterHoney.Impact += value;
        remove => IL.SpatterHoney.Impact -= value;
    }

    public static event ILContext.Manipulator FaceAngle
    {
        add => IL.SpatterHoney.FaceAngle += value;
        remove => IL.SpatterHoney.FaceAngle -= value;
    }

    public static event ILContext.Manipulator ProjectileSquash
    {
        add => IL.SpatterHoney.ProjectileSquash += value;
        remove => IL.SpatterHoney.ProjectileSquash -= value;
    }

    public static event ILContext.Manipulator OnCollisionEnter2D
    {
        add => IL.SpatterHoney.OnCollisionEnter2D += value;
        remove => IL.SpatterHoney.OnCollisionEnter2D -= value;
    }
}