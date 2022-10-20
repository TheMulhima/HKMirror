namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for AddHP.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILAddHP
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.AddHP.Reset += value;
        remove => IL.AddHP.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.AddHP.OnEnter += value;
        remove => IL.AddHP.OnEnter -= value;
    }
}