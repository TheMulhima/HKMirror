namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for EnemyWakeRegion.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILEnemyWakeRegion
{
    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.EnemyWakeRegion.OnTriggerEnter2D += value;
        remove => IL.EnemyWakeRegion.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerExit2D
    {
        add => IL.EnemyWakeRegion.OnTriggerExit2D += value;
        remove => IL.EnemyWakeRegion.OnTriggerExit2D -= value;
    }
}