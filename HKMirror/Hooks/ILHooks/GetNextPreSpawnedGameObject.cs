namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GetNextPreSpawnedGameObject.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGetNextPreSpawnedGameObject
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.GetNextPreSpawnedGameObject.Reset += value;
        remove => IL.GetNextPreSpawnedGameObject.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.GetNextPreSpawnedGameObject.OnEnter += value;
        remove => IL.GetNextPreSpawnedGameObject.OnEnter -= value;
    }
}