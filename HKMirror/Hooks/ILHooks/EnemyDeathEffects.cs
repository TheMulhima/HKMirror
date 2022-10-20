using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for EnemyDeathEffects.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILEnemyDeathEffects
{
    public static event ILContext.Manipulator Start
    {
        add => IL.EnemyDeathEffects.Start += value;
        remove => IL.EnemyDeathEffects.Start -= value;
    }

    public static event ILContext.Manipulator PreInstantiate
    {
        add => IL.EnemyDeathEffects.PreInstantiate += value;
        remove => IL.EnemyDeathEffects.PreInstantiate -= value;
    }

    public static event ILContext.Manipulator RecieveDeathEvent
    {
        add => IL.EnemyDeathEffects.RecieveDeathEvent += value;
        remove => IL.EnemyDeathEffects.RecieveDeathEvent -= value;
    }

    public static event ILContext.Manipulator RecordKillForJournal
    {
        add => IL.EnemyDeathEffects.RecordKillForJournal += value;
        remove => IL.EnemyDeathEffects.RecordKillForJournal -= value;
    }

    public static event ILContext.Manipulator EmitCorpse
    {
        add => IL.EnemyDeathEffects.EmitCorpse += value;
        remove => IL.EnemyDeathEffects.EmitCorpse -= value;
    }

    public static event ILContext.Manipulator EmitEffects
    {
        add => IL.EnemyDeathEffects.EmitEffects += value;
        remove => IL.EnemyDeathEffects.EmitEffects -= value;
    }

    public static event ILContext.Manipulator EmitSound
    {
        add => IL.EnemyDeathEffects.EmitSound += value;
        remove => IL.EnemyDeathEffects.EmitSound -= value;
    }

    public static event ILContext.Manipulator EmitInfectedEffects
    {
        add => IL.EnemyDeathEffects.EmitInfectedEffects += value;
        remove => IL.EnemyDeathEffects.EmitInfectedEffects -= value;
    }

    public static event ILContext.Manipulator EmitSmallInfectedEffects
    {
        add => IL.EnemyDeathEffects.EmitSmallInfectedEffects += value;
        remove => IL.EnemyDeathEffects.EmitSmallInfectedEffects -= value;
    }

    public static event ILContext.Manipulator EmitLargeInfectedEffects
    {
        add => IL.EnemyDeathEffects.EmitLargeInfectedEffects += value;
        remove => IL.EnemyDeathEffects.EmitLargeInfectedEffects -= value;
    }

    public static event ILContext.Manipulator ShakeCameraIfVisible
    {
        add => IL.EnemyDeathEffects.ShakeCameraIfVisible += value;
        remove => IL.EnemyDeathEffects.ShakeCameraIfVisible -= value;
    }

    public static event ILContext.Manipulator EmitEssence
    {
        add => IL.EnemyDeathEffects.EmitEssence += value;
        remove => IL.EnemyDeathEffects.EmitEssence -= value;
    }

    public static event ILContext.Manipulator orig_RecieveDeathEvent
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(EnemyDeathEffects), "orig_RecieveDeathEvent"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(EnemyDeathEffects), "orig_RecieveDeathEvent"), value);
    }

    public static event ILContext.Manipulator orig_RecordKillForJournal
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(EnemyDeathEffects), "orig_RecordKillForJournal"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(EnemyDeathEffects), "orig_RecordKillForJournal"), value);
    }
}