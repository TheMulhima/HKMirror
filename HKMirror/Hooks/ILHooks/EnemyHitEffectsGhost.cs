namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for EnemyHitEffectsGhost.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILEnemyHitEffectsGhost
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.EnemyHitEffectsGhost.Awake += value;
        remove => IL.EnemyHitEffectsGhost.Awake -= value;
    }

    public static event ILContext.Manipulator RecieveHitEffect
    {
        add => IL.EnemyHitEffectsGhost.RecieveHitEffect += value;
        remove => IL.EnemyHitEffectsGhost.RecieveHitEffect -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.EnemyHitEffectsGhost.Update += value;
        remove => IL.EnemyHitEffectsGhost.Update -= value;
    }
}