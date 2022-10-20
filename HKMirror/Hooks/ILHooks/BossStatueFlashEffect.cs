using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BossStatueFlashEffect.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBossStatueFlashEffect
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.BossStatueFlashEffect.Awake += value;
        remove => IL.BossStatueFlashEffect.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.BossStatueFlashEffect.Start += value;
        remove => IL.BossStatueFlashEffect.Start -= value;
    }

    public static event ILContext.Manipulator FlashRoutine
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossStatueFlashEffect), "FlashRoutine").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossStatueFlashEffect), "FlashRoutine").GetStateMachineTarget(),
            value);
    }

    public static event ILContext.Manipulator FlashApex
    {
        add => IL.BossStatueFlashEffect.FlashApex += value;
        remove => IL.BossStatueFlashEffect.FlashApex -= value;
    }
}