namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for EnemyHitEffectsBlackKnight.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILEnemyHitEffectsBlackKnight
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.EnemyHitEffectsBlackKnight.Awake += value;
        remove => IL.EnemyHitEffectsBlackKnight.Awake -= value;
    }

    public static event ILContext.Manipulator RecieveHitEffect
    {
        add => IL.EnemyHitEffectsBlackKnight.RecieveHitEffect += value;
        remove => IL.EnemyHitEffectsBlackKnight.RecieveHitEffect -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.EnemyHitEffectsBlackKnight.Update += value;
        remove => IL.EnemyHitEffectsBlackKnight.Update -= value;
    }
}