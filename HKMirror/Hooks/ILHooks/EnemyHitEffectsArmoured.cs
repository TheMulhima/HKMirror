namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for EnemyHitEffectsArmoured.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILEnemyHitEffectsArmoured
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.EnemyHitEffectsArmoured.Awake += value;
        remove => IL.EnemyHitEffectsArmoured.Awake -= value;
    }

    public static event ILContext.Manipulator RecieveHitEffect
    {
        add => IL.EnemyHitEffectsArmoured.RecieveHitEffect += value;
        remove => IL.EnemyHitEffectsArmoured.RecieveHitEffect -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.EnemyHitEffectsArmoured.Update += value;
        remove => IL.EnemyHitEffectsArmoured.Update -= value;
    }
}