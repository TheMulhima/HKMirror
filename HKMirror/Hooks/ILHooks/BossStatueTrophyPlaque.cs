using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BossStatueTrophyPlaque.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBossStatueTrophyPlaque
{
    public static event ILContext.Manipulator TierCompleteEffectDelayed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossStatueTrophyPlaque), "TierCompleteEffectDelayed")
                .GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossStatueTrophyPlaque), "TierCompleteEffectDelayed")
                .GetStateMachineTarget(), value);
    }
}