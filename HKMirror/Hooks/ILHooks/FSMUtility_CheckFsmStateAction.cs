using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.ILHooks;
/// <summary>
/// Contains all correct IL Hooks for FSMUtility_CheckFsmStateAction,
/// Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
/// Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILFSMUtility_CheckFsmStateAction
{
public static event ILContext.Manipulator get_IsTrue
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(FSMUtility.CheckFsmStateAction), "get_IsTrue", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(FSMUtility.CheckFsmStateAction), "get_IsTrue", true), value);
}
public static event ILContext.Manipulator Reset
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(FSMUtility.CheckFsmStateAction), "Reset", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(FSMUtility.CheckFsmStateAction), "Reset", true), value);
}
public static event ILContext.Manipulator OnEnter
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(FSMUtility.CheckFsmStateAction), "OnEnter", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(FSMUtility.CheckFsmStateAction), "OnEnter", true), value);
}
}
