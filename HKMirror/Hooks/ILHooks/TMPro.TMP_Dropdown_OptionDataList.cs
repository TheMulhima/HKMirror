using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.ILHooks;
/// <summary>
/// Contains all correct IL Hooks for TMPro.TMP_Dropdown_OptionDataList,
/// Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
/// Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTMPro_TMP_Dropdown_OptionDataList
{
public static event ILContext.Manipulator get_options
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown.OptionDataList), "get_options", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown.OptionDataList), "get_options", true), value);
}
public static event ILContext.Manipulator set_options
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown.OptionDataList), "set_options", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown.OptionDataList), "set_options", true), value);
}
}
