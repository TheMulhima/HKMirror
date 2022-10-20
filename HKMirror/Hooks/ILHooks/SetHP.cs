namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SetHP.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSetHP
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.SetHP.Reset += value;
        remove => IL.SetHP.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.SetHP.OnEnter += value;
        remove => IL.SetHP.OnEnter -= value;
    }
}