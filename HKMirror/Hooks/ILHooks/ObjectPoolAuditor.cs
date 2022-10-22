namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ObjectPoolAuditor,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILObjectPoolAuditor
{
    public static event ILContext.Manipulator RecordPoolCreated
    {
        add => IL.ObjectPoolAuditor.RecordPoolCreated += value;
        remove => IL.ObjectPoolAuditor.RecordPoolCreated -= value;
    }

    public static event ILContext.Manipulator RecordSpawned
    {
        add => IL.ObjectPoolAuditor.RecordSpawned += value;
        remove => IL.ObjectPoolAuditor.RecordSpawned -= value;
    }

    public static event ILContext.Manipulator RecordDespawned
    {
        add => IL.ObjectPoolAuditor.RecordDespawned += value;
        remove => IL.ObjectPoolAuditor.RecordDespawned -= value;
    }
}