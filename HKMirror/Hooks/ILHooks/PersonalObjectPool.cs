namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PersonalObjectPool.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPersonalObjectPool
{
    public static event ILContext.Manipulator Start
    {
        add => IL.PersonalObjectPool.Start += value;
        remove => IL.PersonalObjectPool.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.PersonalObjectPool.OnEnable += value;
        remove => IL.PersonalObjectPool.OnEnable -= value;
    }

    public static event ILContext.Manipulator CreateStartupPools
    {
        add => IL.PersonalObjectPool.CreateStartupPools += value;
        remove => IL.PersonalObjectPool.CreateStartupPools -= value;
    }

    public static event ILContext.Manipulator CreatePool
    {
        add => IL.PersonalObjectPool.CreatePool += value;
        remove => IL.PersonalObjectPool.CreatePool -= value;
    }

    public static event ILContext.Manipulator DestroyMyPooledObjects
    {
        add => IL.PersonalObjectPool.DestroyMyPooledObjects += value;
        remove => IL.PersonalObjectPool.DestroyMyPooledObjects -= value;
    }
}