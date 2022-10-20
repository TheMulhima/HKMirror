namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for EnemySpawner.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILEnemySpawner
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.EnemySpawner.Awake += value;
        remove => IL.EnemySpawner.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.EnemySpawner.Start += value;
        remove => IL.EnemySpawner.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.EnemySpawner.Update += value;
        remove => IL.EnemySpawner.Update -= value;
    }
}