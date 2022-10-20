namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for LiftPlatform.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILLiftPlatform
{
    public static event ILContext.Manipulator Start
    {
        add => IL.LiftPlatform.Start += value;
        remove => IL.LiftPlatform.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.LiftPlatform.Update += value;
        remove => IL.LiftPlatform.Update -= value;
    }

    public static event ILContext.Manipulator OnCollisionEnter2D
    {
        add => IL.LiftPlatform.OnCollisionEnter2D += value;
        remove => IL.LiftPlatform.OnCollisionEnter2D -= value;
    }
}