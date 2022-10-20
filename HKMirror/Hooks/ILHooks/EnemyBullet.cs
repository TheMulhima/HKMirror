using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for EnemyBullet.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILEnemyBullet
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.EnemyBullet.Awake += value;
        remove => IL.EnemyBullet.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.EnemyBullet.OnEnable += value;
        remove => IL.EnemyBullet.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.EnemyBullet.Update += value;
        remove => IL.EnemyBullet.Update -= value;
    }

    public static event ILContext.Manipulator OnCollisionEnter2D
    {
        add => IL.EnemyBullet.OnCollisionEnter2D += value;
        remove => IL.EnemyBullet.OnCollisionEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.EnemyBullet.OnTriggerEnter2D += value;
        remove => IL.EnemyBullet.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator OrbitShieldHit
    {
        add => IL.EnemyBullet.OrbitShieldHit += value;
        remove => IL.EnemyBullet.OrbitShieldHit -= value;
    }

    public static event ILContext.Manipulator Collision
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(EnemyBullet), "Collision").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(EnemyBullet), "Collision").GetStateMachineTarget(), value);
    }
}