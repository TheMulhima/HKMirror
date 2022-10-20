using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for HealthManager.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILHealthManager
{
    public static event ILContext.Manipulator get_IsInvincible
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HealthManager), "get_IsInvincible"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HealthManager), "get_IsInvincible"), value);
    }

    public static event ILContext.Manipulator set_IsInvincible
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HealthManager), "set_IsInvincible"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HealthManager), "set_IsInvincible"), value);
    }

    public static event ILContext.Manipulator get_InvincibleFromDirection
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HealthManager), "get_InvincibleFromDirection"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HealthManager), "get_InvincibleFromDirection"), value);
    }

    public static event ILContext.Manipulator set_InvincibleFromDirection
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HealthManager), "set_InvincibleFromDirection"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HealthManager), "set_InvincibleFromDirection"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.HealthManager.Awake += value;
        remove => IL.HealthManager.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.HealthManager.OnEnable += value;
        remove => IL.HealthManager.OnEnable -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.HealthManager.Start += value;
        remove => IL.HealthManager.Start -= value;
    }

    public static event ILContext.Manipulator CheckPersistence
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HealthManager), "CheckPersistence").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HealthManager), "CheckPersistence").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.HealthManager.Update += value;
        remove => IL.HealthManager.Update -= value;
    }

    public static event ILContext.Manipulator Hit
    {
        add => IL.HealthManager.Hit += value;
        remove => IL.HealthManager.Hit -= value;
    }

    public static event ILContext.Manipulator Invincible
    {
        add => IL.HealthManager.Invincible += value;
        remove => IL.HealthManager.Invincible -= value;
    }

    public static event ILContext.Manipulator TakeDamage
    {
        add => IL.HealthManager.TakeDamage += value;
        remove => IL.HealthManager.TakeDamage -= value;
    }

    public static event ILContext.Manipulator NonFatalHit
    {
        add => IL.HealthManager.NonFatalHit += value;
        remove => IL.HealthManager.NonFatalHit -= value;
    }

    public static event ILContext.Manipulator ApplyExtraDamage
    {
        add => IL.HealthManager.ApplyExtraDamage += value;
        remove => IL.HealthManager.ApplyExtraDamage -= value;
    }

    public static event ILContext.Manipulator Die
    {
        add => IL.HealthManager.Die += value;
        remove => IL.HealthManager.Die -= value;
    }

    public static event ILContext.Manipulator SendDeathEvent
    {
        add => IL.HealthManager.SendDeathEvent += value;
        remove => IL.HealthManager.SendDeathEvent -= value;
    }

    public static event ILContext.Manipulator SetGeoFlashing
    {
        add => IL.HealthManager.SetGeoFlashing += value;
        remove => IL.HealthManager.SetGeoFlashing -= value;
    }

    public static event ILContext.Manipulator IsBlockingByDirection
    {
        add => IL.HealthManager.IsBlockingByDirection += value;
        remove => IL.HealthManager.IsBlockingByDirection -= value;
    }

    public static event ILContext.Manipulator SetBattleScene
    {
        add => IL.HealthManager.SetBattleScene += value;
        remove => IL.HealthManager.SetBattleScene -= value;
    }

    public static event ILContext.Manipulator GetAttackDirection
    {
        add => IL.HealthManager.GetAttackDirection += value;
        remove => IL.HealthManager.GetAttackDirection -= value;
    }

    public static event ILContext.Manipulator SetPreventInvincibleEffect
    {
        add => IL.HealthManager.SetPreventInvincibleEffect += value;
        remove => IL.HealthManager.SetPreventInvincibleEffect -= value;
    }

    public static event ILContext.Manipulator SetGeoSmall
    {
        add => IL.HealthManager.SetGeoSmall += value;
        remove => IL.HealthManager.SetGeoSmall -= value;
    }

    public static event ILContext.Manipulator SetGeoMedium
    {
        add => IL.HealthManager.SetGeoMedium += value;
        remove => IL.HealthManager.SetGeoMedium -= value;
    }

    public static event ILContext.Manipulator SetGeoLarge
    {
        add => IL.HealthManager.SetGeoLarge += value;
        remove => IL.HealthManager.SetGeoLarge -= value;
    }

    public static event ILContext.Manipulator GetIsDead
    {
        add => IL.HealthManager.GetIsDead += value;
        remove => IL.HealthManager.GetIsDead -= value;
    }

    public static event ILContext.Manipulator SetIsDead
    {
        add => IL.HealthManager.SetIsDead += value;
        remove => IL.HealthManager.SetIsDead -= value;
    }

    public static event ILContext.Manipulator SetDamageOverride
    {
        add => IL.HealthManager.SetDamageOverride += value;
        remove => IL.HealthManager.SetDamageOverride -= value;
    }

    public static event ILContext.Manipulator SetSendKilledToObject
    {
        add => IL.HealthManager.SetSendKilledToObject += value;
        remove => IL.HealthManager.SetSendKilledToObject -= value;
    }

    public static event ILContext.Manipulator CheckInvincible
    {
        add => IL.HealthManager.CheckInvincible += value;
        remove => IL.HealthManager.CheckInvincible -= value;
    }
}