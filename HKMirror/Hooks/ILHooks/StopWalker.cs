namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for StopWalker.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILStopWalker
{
    public static event ILContext.Manipulator Apply
    {
        add => IL.StopWalker.Apply += value;
        remove => IL.StopWalker.Apply -= value;
    }
}