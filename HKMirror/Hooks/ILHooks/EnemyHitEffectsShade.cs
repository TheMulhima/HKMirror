namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for EnemyHitEffectsShade.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILEnemyHitEffectsShade
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.EnemyHitEffectsShade.Awake += value;
        remove => IL.EnemyHitEffectsShade.Awake -= value;
    }

    public static event ILContext.Manipulator RecieveHitEffect
    {
        add => IL.EnemyHitEffectsShade.RecieveHitEffect += value;
        remove => IL.EnemyHitEffectsShade.RecieveHitEffect -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.EnemyHitEffectsShade.Update += value;
        remove => IL.EnemyHitEffectsShade.Update -= value;
    }
}