namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for EnemyDeathEffectsDung.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILEnemyDeathEffectsDung
{
    public static event ILContext.Manipulator EmitEffects
    {
        add => IL.EnemyDeathEffectsDung.EmitEffects += value;
        remove => IL.EnemyDeathEffectsDung.EmitEffects -= value;
    }
}