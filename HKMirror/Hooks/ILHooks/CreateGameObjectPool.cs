namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CreateGameObjectPool.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCreateGameObjectPool
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.CreateGameObjectPool.Reset += value;
        remove => IL.CreateGameObjectPool.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.CreateGameObjectPool.OnEnter += value;
        remove => IL.CreateGameObjectPool.OnEnter -= value;
    }
}