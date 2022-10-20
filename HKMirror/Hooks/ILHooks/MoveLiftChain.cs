namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MoveLiftChain.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMoveLiftChain
{
    public static event ILContext.Manipulator Apply
    {
        add => IL.MoveLiftChain.Apply += value;
        remove => IL.MoveLiftChain.Apply -= value;
    }
}