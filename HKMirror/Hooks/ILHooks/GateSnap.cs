namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GateSnap.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGateSnap
{
    public static event ILContext.Manipulator Update
    {
        add => IL.GateSnap.Update += value;
        remove => IL.GateSnap.Update -= value;
    }
}