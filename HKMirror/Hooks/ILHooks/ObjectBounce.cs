namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ObjectBounce.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILObjectBounce
{
    public static event ILContext.Manipulator Start
    {
        add => IL.ObjectBounce.Start += value;
        remove => IL.ObjectBounce.Start -= value;
    }

    public static event ILContext.Manipulator FixedUpdate
    {
        add => IL.ObjectBounce.FixedUpdate += value;
        remove => IL.ObjectBounce.FixedUpdate -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.ObjectBounce.Update += value;
        remove => IL.ObjectBounce.Update -= value;
    }

    public static event ILContext.Manipulator OnCollisionEnter2D
    {
        add => IL.ObjectBounce.OnCollisionEnter2D += value;
        remove => IL.ObjectBounce.OnCollisionEnter2D -= value;
    }

    public static event ILContext.Manipulator StopBounce
    {
        add => IL.ObjectBounce.StopBounce += value;
        remove => IL.ObjectBounce.StopBounce -= value;
    }

    public static event ILContext.Manipulator StartBounce
    {
        add => IL.ObjectBounce.StartBounce += value;
        remove => IL.ObjectBounce.StartBounce -= value;
    }

    public static event ILContext.Manipulator SetBounceFactor
    {
        add => IL.ObjectBounce.SetBounceFactor += value;
        remove => IL.ObjectBounce.SetBounceFactor -= value;
    }

    public static event ILContext.Manipulator SetBounceAnimation
    {
        add => IL.ObjectBounce.SetBounceAnimation += value;
        remove => IL.ObjectBounce.SetBounceAnimation -= value;
    }
}