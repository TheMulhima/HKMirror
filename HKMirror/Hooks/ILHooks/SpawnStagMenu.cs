namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SpawnStagMenu.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSpawnStagMenu
{
    public static event ILContext.Manipulator Start
    {
        add => IL.SpawnStagMenu.Start += value;
        remove => IL.SpawnStagMenu.Start -= value;
    }

    public static event ILContext.Manipulator SendEvent
    {
        add => IL.SpawnStagMenu.SendEvent += value;
        remove => IL.SpawnStagMenu.SendEvent -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.SpawnStagMenu.OnDestroy += value;
        remove => IL.SpawnStagMenu.OnDestroy -= value;
    }
}