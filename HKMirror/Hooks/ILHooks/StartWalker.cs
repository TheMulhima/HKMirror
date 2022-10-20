namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for StartWalker.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILStartWalker
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.StartWalker.Reset += value;
        remove => IL.StartWalker.Reset -= value;
    }

    public static event ILContext.Manipulator Apply
    {
        add => IL.StartWalker.Apply += value;
        remove => IL.StartWalker.Apply -= value;
    }
}