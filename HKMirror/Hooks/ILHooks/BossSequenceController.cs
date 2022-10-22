using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BossSequenceController,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBossSequenceController
{
    public static event ILContext.Manipulator get_BoundNail
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_BoundNail", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_BoundNail", false), value);
    }

    public static event ILContext.Manipulator get_BoundShell
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_BoundShell", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_BoundShell", false), value);
    }

    public static event ILContext.Manipulator get_BoundCharms
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_BoundCharms", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_BoundCharms", false), value);
    }

    public static event ILContext.Manipulator get_BoundSoul
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_BoundSoul", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_BoundSoul", false), value);
    }

    public static event ILContext.Manipulator get_KnightDamaged
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_KnightDamaged", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_KnightDamaged", false), value);
    }

    public static event ILContext.Manipulator set_KnightDamaged
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "set_KnightDamaged", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "set_KnightDamaged", false), value);
    }

    public static event ILContext.Manipulator get_Timer
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_Timer", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_Timer", false), value);
    }

    public static event ILContext.Manipulator set_Timer
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "set_Timer", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "set_Timer", false), value);
    }

    public static event ILContext.Manipulator get_WasCompleted
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_WasCompleted", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_WasCompleted", false), value);
    }

    public static event ILContext.Manipulator set_WasCompleted
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "set_WasCompleted", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "set_WasCompleted", false), value);
    }

    public static event ILContext.Manipulator get_IsInSequence
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_IsInSequence", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_IsInSequence", false), value);
    }

    public static event ILContext.Manipulator get_IsLastBossScene
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_IsLastBossScene", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_IsLastBossScene", false), value);
    }

    public static event ILContext.Manipulator get_BossIndex
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_BossIndex", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_BossIndex", false), value);
    }

    public static event ILContext.Manipulator get_BossCount
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_BossCount", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_BossCount", false), value);
    }

    public static event ILContext.Manipulator get_ShouldUnlockGGMode
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_ShouldUnlockGGMode", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_ShouldUnlockGGMode", false), value);
    }

    public static event ILContext.Manipulator get_BoundMaxHealth
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_BoundMaxHealth", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_BoundMaxHealth", false), value);
    }

    public static event ILContext.Manipulator get_BoundNailDamage
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_BoundNailDamage", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_BoundNailDamage", false), value);
    }

    public static event ILContext.Manipulator get_ForceAssetUnload
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_ForceAssetUnload", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "get_ForceAssetUnload", false), value);
    }

    public static event ILContext.Manipulator Reset
    {
        add => IL.BossSequenceController.Reset += value;
        remove => IL.BossSequenceController.Reset -= value;
    }

    public static event ILContext.Manipulator CheckLoadSequence
    {
        add => IL.BossSequenceController.CheckLoadSequence += value;
        remove => IL.BossSequenceController.CheckLoadSequence -= value;
    }

    public static event ILContext.Manipulator LoadCurrentSequence
    {
        add => IL.BossSequenceController.LoadCurrentSequence += value;
        remove => IL.BossSequenceController.LoadCurrentSequence -= value;
    }

    public static event ILContext.Manipulator ApplyBindings
    {
        add => IL.BossSequenceController.ApplyBindings += value;
        remove => IL.BossSequenceController.ApplyBindings -= value;
    }

    public static event ILContext.Manipulator RestoreBindings
    {
        add => IL.BossSequenceController.RestoreBindings += value;
        remove => IL.BossSequenceController.RestoreBindings -= value;
    }

    public static event ILContext.Manipulator ResetBindingDisplay
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "ResetBindingDisplay", false)
                .GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossSequenceController), "ResetBindingDisplay", false)
                .GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator SetupBossScene
    {
        add => IL.BossSequenceController.SetupBossScene += value;
        remove => IL.BossSequenceController.SetupBossScene -= value;
    }

    public static event ILContext.Manipulator IncrementBossIndex
    {
        add => IL.BossSequenceController.IncrementBossIndex += value;
        remove => IL.BossSequenceController.IncrementBossIndex -= value;
    }

    public static event ILContext.Manipulator FinishLastBossScene
    {
        add => IL.BossSequenceController.FinishLastBossScene += value;
        remove => IL.BossSequenceController.FinishLastBossScene -= value;
    }

    public static event ILContext.Manipulator CheckIfSequence
    {
        add => IL.BossSequenceController.CheckIfSequence += value;
        remove => IL.BossSequenceController.CheckIfSequence -= value;
    }

    public static event ILContext.Manipulator SetMinValue
    {
        add => IL.BossSequenceController.SetMinValue += value;
        remove => IL.BossSequenceController.SetMinValue -= value;
    }

    public static event ILContext.Manipulator SetCharmsEquipped
    {
        add => IL.BossSequenceController.SetCharmsEquipped += value;
        remove => IL.BossSequenceController.SetCharmsEquipped -= value;
    }
}