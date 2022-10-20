namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SnapshotOnActivation.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSnapshotOnActivation
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.SnapshotOnActivation.OnEnable += value;
        remove => IL.SnapshotOnActivation.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.SnapshotOnActivation.OnDisable += value;
        remove => IL.SnapshotOnActivation.OnDisable -= value;
    }
}