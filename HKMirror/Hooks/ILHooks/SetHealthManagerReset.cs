namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SetHealthManagerReset.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSetHealthManagerReset
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.SetHealthManagerReset.Reset += value;
        remove => IL.SetHealthManagerReset.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.SetHealthManagerReset.OnEnter += value;
        remove => IL.SetHealthManagerReset.OnEnter -= value;
    }
}