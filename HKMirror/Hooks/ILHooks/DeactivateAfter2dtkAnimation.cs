namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for DeactivateAfter2dtkAnimation.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDeactivateAfter2dtkAnimation
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.DeactivateAfter2dtkAnimation.OnEnable += value;
        remove => IL.DeactivateAfter2dtkAnimation.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.DeactivateAfter2dtkAnimation.Update += value;
        remove => IL.DeactivateAfter2dtkAnimation.Update -= value;
    }
}