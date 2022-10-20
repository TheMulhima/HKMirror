namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SteepSlope.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSteepSlope
{
    public static event ILContext.Manipulator Start
    {
        add => IL.SteepSlope.Start += value;
        remove => IL.SteepSlope.Start -= value;
    }

    public static event ILContext.Manipulator OnCollisionStay2D
    {
        add => IL.SteepSlope.OnCollisionStay2D += value;
        remove => IL.SteepSlope.OnCollisionStay2D -= value;
    }

    public static event ILContext.Manipulator OnCollisionEnter2D
    {
        add => IL.SteepSlope.OnCollisionEnter2D += value;
        remove => IL.SteepSlope.OnCollisionEnter2D -= value;
    }

    public static event ILContext.Manipulator OnCollisionExit2D
    {
        add => IL.SteepSlope.OnCollisionExit2D += value;
        remove => IL.SteepSlope.OnCollisionExit2D -= value;
    }
}