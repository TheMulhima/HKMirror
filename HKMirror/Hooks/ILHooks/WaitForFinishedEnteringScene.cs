namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for WaitForFinishedEnteringScene.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILWaitForFinishedEnteringScene
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.WaitForFinishedEnteringScene.Reset += value;
        remove => IL.WaitForFinishedEnteringScene.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.WaitForFinishedEnteringScene.OnEnter += value;
        remove => IL.WaitForFinishedEnteringScene.OnEnter -= value;
    }
}