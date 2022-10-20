namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TimeLimitSet.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTimeLimitSet
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.TimeLimitSet.Reset += value;
        remove => IL.TimeLimitSet.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.TimeLimitSet.OnEnter += value;
        remove => IL.TimeLimitSet.OnEnter -= value;
    }
}