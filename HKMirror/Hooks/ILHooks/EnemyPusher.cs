namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for EnemyPusher.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILEnemyPusher
{
    public static event ILContext.Manipulator OnCollisionEnter2D
    {
        add => IL.EnemyPusher.OnCollisionEnter2D += value;
        remove => IL.EnemyPusher.OnCollisionEnter2D -= value;
    }
}