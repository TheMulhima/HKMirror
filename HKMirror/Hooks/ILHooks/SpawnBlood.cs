namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SpawnBlood.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSpawnBlood
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.SpawnBlood.Reset += value;
        remove => IL.SpawnBlood.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.SpawnBlood.OnEnter += value;
        remove => IL.SpawnBlood.OnEnter -= value;
    }

    public static event ILContext.Manipulator Spawn
    {
        add => IL.SpawnBlood.Spawn += value;
        remove => IL.SpawnBlood.Spawn -= value;
    }
}