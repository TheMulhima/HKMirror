namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SubtractHP.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSubtractHP
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.SubtractHP.Reset += value;
        remove => IL.SubtractHP.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.SubtractHP.OnEnter += value;
        remove => IL.SubtractHP.OnEnter -= value;
    }
}