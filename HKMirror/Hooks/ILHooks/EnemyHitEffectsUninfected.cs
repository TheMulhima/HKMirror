namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for EnemyHitEffectsUninfected.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILEnemyHitEffectsUninfected
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.EnemyHitEffectsUninfected.Awake += value;
        remove => IL.EnemyHitEffectsUninfected.Awake -= value;
    }

    public static event ILContext.Manipulator RecieveHitEffect
    {
        add => IL.EnemyHitEffectsUninfected.RecieveHitEffect += value;
        remove => IL.EnemyHitEffectsUninfected.RecieveHitEffect -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.EnemyHitEffectsUninfected.Update += value;
        remove => IL.EnemyHitEffectsUninfected.Update -= value;
    }
}