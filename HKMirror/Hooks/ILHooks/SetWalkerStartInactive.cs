namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SetWalkerStartInactive.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSetWalkerStartInactive
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.SetWalkerStartInactive.Reset += value;
        remove => IL.SetWalkerStartInactive.Reset -= value;
    }

    public static event ILContext.Manipulator Apply
    {
        add => IL.SetWalkerStartInactive.Apply += value;
        remove => IL.SetWalkerStartInactive.Apply -= value;
    }
}