namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PlayMakerAnimatorMoveProxy.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPlayMakerAnimatorMoveProxy
{
    public static event ILContext.Manipulator Start
    {
        add => IL.PlayMakerAnimatorMoveProxy.Start += value;
        remove => IL.PlayMakerAnimatorMoveProxy.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.PlayMakerAnimatorMoveProxy.Update += value;
        remove => IL.PlayMakerAnimatorMoveProxy.Update -= value;
    }

    public static event ILContext.Manipulator OnAnimatorMove
    {
        add => IL.PlayMakerAnimatorMoveProxy.OnAnimatorMove += value;
        remove => IL.PlayMakerAnimatorMoveProxy.OnAnimatorMove -= value;
    }
}