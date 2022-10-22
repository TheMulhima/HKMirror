using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.ILHooks;
/// <summary>
/// Contains all correct IL Hooks for FSMUtility_GetIntFsmStateAction,
/// Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
/// Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILFSMUtility_GetIntFsmStateAction
{
public static event ILContext.Manipulator get_IntValue
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(FSMUtility.GetIntFsmStateAction), "get_IntValue", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(FSMUtility.GetIntFsmStateAction), "get_IntValue", true), value);
}
public static event ILContext.Manipulator Reset
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(FSMUtility.GetIntFsmStateAction), "Reset", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(FSMUtility.GetIntFsmStateAction), "Reset", true), value);
}
public static event ILContext.Manipulator OnEnter
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(FSMUtility.GetIntFsmStateAction), "OnEnter", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(FSMUtility.GetIntFsmStateAction), "OnEnter", true), value);
}
}
