namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for DamageEnemies.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDamageEnemies
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.DamageEnemies.Reset += value;
        remove => IL.DamageEnemies.Reset -= value;
    }

    public static event ILContext.Manipulator OnCollisionEnter2D
    {
        add => IL.DamageEnemies.OnCollisionEnter2D += value;
        remove => IL.DamageEnemies.OnCollisionEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.DamageEnemies.OnTriggerEnter2D += value;
        remove => IL.DamageEnemies.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerExit2D
    {
        add => IL.DamageEnemies.OnTriggerExit2D += value;
        remove => IL.DamageEnemies.OnTriggerExit2D -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.DamageEnemies.OnDisable += value;
        remove => IL.DamageEnemies.OnDisable -= value;
    }

    public static event ILContext.Manipulator FixedUpdate
    {
        add => IL.DamageEnemies.FixedUpdate += value;
        remove => IL.DamageEnemies.FixedUpdate -= value;
    }

    public static event ILContext.Manipulator DoDamage
    {
        add => IL.DamageEnemies.DoDamage += value;
        remove => IL.DamageEnemies.DoDamage -= value;
    }
}