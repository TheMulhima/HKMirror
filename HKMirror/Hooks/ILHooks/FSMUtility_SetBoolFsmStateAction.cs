using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.ILHooks;
/// <summary>
/// Contains all correct IL Hooks for FSMUtility_SetBoolFsmStateAction,
/// Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
/// Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILFSMUtility_SetBoolFsmStateAction
{
public static event ILContext.Manipulator set_BoolValue
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(FSMUtility.SetBoolFsmStateAction), "set_BoolValue", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(FSMUtility.SetBoolFsmStateAction), "set_BoolValue", true), value);
}
public static event ILContext.Manipulator Reset
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(FSMUtility.SetBoolFsmStateAction), "Reset", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(FSMUtility.SetBoolFsmStateAction), "Reset", true), value);
}
public static event ILContext.Manipulator OnEnter
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(FSMUtility.SetBoolFsmStateAction), "OnEnter", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(FSMUtility.SetBoolFsmStateAction), "OnEnter", true), value);
}
}
