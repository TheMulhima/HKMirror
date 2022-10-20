namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for UIAnimationEvents.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILUIAnimationEvents
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.UIAnimationEvents.OnEnable += value;
        remove => IL.UIAnimationEvents.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.UIAnimationEvents.OnDisable += value;
        remove => IL.UIAnimationEvents.OnDisable -= value;
    }

    public static event ILContext.Manipulator AnimateIn
    {
        add => IL.UIAnimationEvents.AnimateIn += value;
        remove => IL.UIAnimationEvents.AnimateIn -= value;
    }

    public static event ILContext.Manipulator AnimateOut
    {
        add => IL.UIAnimationEvents.AnimateOut += value;
        remove => IL.UIAnimationEvents.AnimateOut -= value;
    }
}