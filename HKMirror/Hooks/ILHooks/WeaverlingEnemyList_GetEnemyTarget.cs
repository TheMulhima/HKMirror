using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.ILHooks;
/// <summary>
/// Contains all correct IL Hooks for WeaverlingEnemyList_GetEnemyTarget,
/// Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
/// Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILWeaverlingEnemyList_GetEnemyTarget
{
public static event ILContext.Manipulator Reset
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(WeaverlingEnemyList.GetEnemyTarget), "Reset", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(WeaverlingEnemyList.GetEnemyTarget), "Reset", true), value);
}
public static event ILContext.Manipulator OnEnter
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(WeaverlingEnemyList.GetEnemyTarget), "OnEnter", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(WeaverlingEnemyList.GetEnemyTarget), "OnEnter", true), value);
}
}
