using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.ILHooks;
/// <summary>
/// Contains all correct IL Hooks for BossStatueTrophyPlaque,
/// Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
/// Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBossStatueTrophyPlaque
{
public static event ILContext.Manipulator SetDisplay
{
add => IL.BossStatueTrophyPlaque.SetDisplay += value;
remove => IL.BossStatueTrophyPlaque.SetDisplay -= value;
}
public static event ILContext.Manipulator DoTierCompleteEffect
{
add => IL.BossStatueTrophyPlaque.DoTierCompleteEffect += value;
remove => IL.BossStatueTrophyPlaque.DoTierCompleteEffect -= value;
}
public static event ILContext.Manipulator TierCompleteEffectDelayed
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BossStatueTrophyPlaque), "TierCompleteEffectDelayed", true).GetStateMachineTarget(), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(BossStatueTrophyPlaque), "TierCompleteEffectDelayed", true).GetStateMachineTarget(), value);
}
public static event ILContext.Manipulator SetDisplayObject
{
add => IL.BossStatueTrophyPlaque.SetDisplayObject += value;
remove => IL.BossStatueTrophyPlaque.SetDisplayObject -= value;
}
}
