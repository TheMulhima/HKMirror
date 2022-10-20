namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for DestroyEnemyBullet.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDestroyEnemyBullet
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.DestroyEnemyBullet.Reset += value;
        remove => IL.DestroyEnemyBullet.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.DestroyEnemyBullet.OnEnter += value;
        remove => IL.DestroyEnemyBullet.OnEnter -= value;
    }
}