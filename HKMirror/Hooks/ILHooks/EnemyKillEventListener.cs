namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for EnemyKillEventListener.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILEnemyKillEventListener
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.EnemyKillEventListener.Awake += value;
        remove => IL.EnemyKillEventListener.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.EnemyKillEventListener.OnEnable += value;
        remove => IL.EnemyKillEventListener.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.EnemyKillEventListener.OnDisable += value;
        remove => IL.EnemyKillEventListener.OnDisable -= value;
    }

    public static event ILContext.Manipulator Die
    {
        add => IL.EnemyKillEventListener.Die += value;
        remove => IL.EnemyKillEventListener.Die -= value;
    }
}