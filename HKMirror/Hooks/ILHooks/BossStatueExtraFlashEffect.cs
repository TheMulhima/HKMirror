using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BossStatueExtraFlashEffect.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBossStatueExtraFlashEffect
{
    public static event ILContext.Manipulator Start
    {
        add => IL.BossStatueExtraFlashEffect.Start += value;
        remove => IL.BossStatueExtraFlashEffect.Start -= value;
    }

    public static event ILContext.Manipulator DoAppear
    {
        add => IL.BossStatueExtraFlashEffect.DoAppear += value;
        remove => IL.BossStatueExtraFlashEffect.DoAppear -= value;
    }

    public static event ILContext.Manipulator AppearRoutine
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossStatueExtraFlashEffect), "AppearRoutine").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossStatueExtraFlashEffect), "AppearRoutine").GetStateMachineTarget(),
            value);
    }
}