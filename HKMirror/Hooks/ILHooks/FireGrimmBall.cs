namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for FireGrimmBall.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILFireGrimmBall
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.FireGrimmBall.Reset += value;
        remove => IL.FireGrimmBall.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.FireGrimmBall.OnEnter += value;
        remove => IL.FireGrimmBall.OnEnter -= value;
    }
}