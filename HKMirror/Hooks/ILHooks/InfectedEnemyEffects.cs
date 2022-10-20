namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for InfectedEnemyEffects.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILInfectedEnemyEffects
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.InfectedEnemyEffects.Reset += value;
        remove => IL.InfectedEnemyEffects.Reset -= value;
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.InfectedEnemyEffects.Awake += value;
        remove => IL.InfectedEnemyEffects.Awake -= value;
    }

    public static event ILContext.Manipulator RecieveHitEffect
    {
        add => IL.InfectedEnemyEffects.RecieveHitEffect += value;
        remove => IL.InfectedEnemyEffects.RecieveHitEffect -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.InfectedEnemyEffects.Update += value;
        remove => IL.InfectedEnemyEffects.Update -= value;
    }
}