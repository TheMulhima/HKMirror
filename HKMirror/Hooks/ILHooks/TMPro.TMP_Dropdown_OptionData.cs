using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.ILHooks;
/// <summary>
/// Contains all correct IL Hooks for TMPro.TMP_Dropdown_OptionData,
/// Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
/// Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTMPro_TMP_Dropdown_OptionData
{
public static event ILContext.Manipulator get_text
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown.OptionData), "get_text", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown.OptionData), "get_text", true), value);
}
public static event ILContext.Manipulator set_text
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown.OptionData), "set_text", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown.OptionData), "set_text", true), value);
}
public static event ILContext.Manipulator get_image
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown.OptionData), "get_image", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown.OptionData), "get_image", true), value);
}
public static event ILContext.Manipulator set_image
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown.OptionData), "set_image", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown.OptionData), "set_image", true), value);
}
}
