namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TimeLimitCheck.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTimeLimitCheck
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.TimeLimitCheck.Reset += value;
        remove => IL.TimeLimitCheck.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.TimeLimitCheck.OnEnter += value;
        remove => IL.TimeLimitCheck.OnEnter -= value;
    }
}