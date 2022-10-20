namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PreSpawnGameObjects.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPreSpawnGameObjects
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.PreSpawnGameObjects.Reset += value;
        remove => IL.PreSpawnGameObjects.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.PreSpawnGameObjects.OnEnter += value;
        remove => IL.PreSpawnGameObjects.OnEnter -= value;
    }
}