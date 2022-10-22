using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.ILHooks;
/// <summary>
/// Contains all correct IL Hooks for AchievementIDMap_AchievementIDPair,
/// Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
/// Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILAchievementIDMap_AchievementIDPair
{
public static event ILContext.Manipulator get_InternalId
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(AchievementIDMap.AchievementIDPair), "get_InternalId", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(AchievementIDMap.AchievementIDPair), "get_InternalId", true), value);
}
public static event ILContext.Manipulator get_ServiceId
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(AchievementIDMap.AchievementIDPair), "get_ServiceId", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(AchievementIDMap.AchievementIDPair), "get_ServiceId", true), value);
}
}