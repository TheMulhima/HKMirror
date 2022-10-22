using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.ILHooks;
/// <summary>
/// Contains all correct IL Hooks for TMP_Dropdown,
/// Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
/// Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTMP_Dropdown
{
public static event ILContext.Manipulator get_template
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "get_template", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "get_template", true), value);
}
public static event ILContext.Manipulator set_template
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "set_template", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "set_template", true), value);
}
public static event ILContext.Manipulator get_captionText
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "get_captionText", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "get_captionText", true), value);
}
public static event ILContext.Manipulator set_captionText
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "set_captionText", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "set_captionText", true), value);
}
public static event ILContext.Manipulator get_captionImage
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "get_captionImage", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "get_captionImage", true), value);
}
public static event ILContext.Manipulator set_captionImage
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "set_captionImage", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "set_captionImage", true), value);
}
public static event ILContext.Manipulator get_itemText
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "get_itemText", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "get_itemText", true), value);
}
public static event ILContext.Manipulator set_itemText
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "set_itemText", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "set_itemText", true), value);
}
public static event ILContext.Manipulator get_itemImage
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "get_itemImage", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "get_itemImage", true), value);
}
public static event ILContext.Manipulator set_itemImage
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "set_itemImage", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "set_itemImage", true), value);
}
public static event ILContext.Manipulator get_options
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "get_options", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "get_options", true), value);
}
public static event ILContext.Manipulator set_options
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "set_options", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "set_options", true), value);
}
public static event ILContext.Manipulator set_onValueChanged
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "set_onValueChanged", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "set_onValueChanged", true), value);
}
public static event ILContext.Manipulator get_value
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "get_value", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "get_value", true), value);
}
public static event ILContext.Manipulator set_value
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "set_value", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "set_value", true), value);
}
public static event ILContext.Manipulator Awake
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "Awake", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "Awake", true), value);
}
public static event ILContext.Manipulator RefreshShownValue
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "RefreshShownValue", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "RefreshShownValue", true), value);
}
public static event ILContext.Manipulator AddOptions_OptionData
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "AddOptions", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "AddOptions", true), value);
}
public static event ILContext.Manipulator AddOptions_List
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "AddOptions", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "AddOptions", true), value);
}
public static event ILContext.Manipulator AddOptions_Sprite
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "AddOptions", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "AddOptions", true), value);
}
public static event ILContext.Manipulator ClearOptions
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "ClearOptions", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "ClearOptions", true), value);
}
public static event ILContext.Manipulator SetupTemplate
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "SetupTemplate", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "SetupTemplate", true), value);
}
public static event ILContext.Manipulator OnPointerClick
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "OnPointerClick", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "OnPointerClick", true), value);
}
public static event ILContext.Manipulator OnSubmit
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "OnSubmit", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "OnSubmit", true), value);
}
public static event ILContext.Manipulator OnCancel
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "OnCancel", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "OnCancel", true), value);
}
public static event ILContext.Manipulator Show
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "Show", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "Show", true), value);
}
public static event ILContext.Manipulator CreateBlocker
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "CreateBlocker", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "CreateBlocker", true), value);
}
public static event ILContext.Manipulator DestroyBlocker
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "DestroyBlocker", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "DestroyBlocker", true), value);
}
public static event ILContext.Manipulator CreateDropdownList
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "CreateDropdownList", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "CreateDropdownList", true), value);
}
public static event ILContext.Manipulator DestroyDropdownList
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "DestroyDropdownList", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "DestroyDropdownList", true), value);
}
public static event ILContext.Manipulator DestroyItem
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "DestroyItem", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "DestroyItem", true), value);
}
public static event ILContext.Manipulator AlphaFadeList_float_float
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "AlphaFadeList", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "AlphaFadeList", true), value);
}
public static event ILContext.Manipulator AlphaFadeList_float_float_float
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "AlphaFadeList", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "AlphaFadeList", true), value);
}
public static event ILContext.Manipulator SetAlpha
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "SetAlpha", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "SetAlpha", true), value);
}
public static event ILContext.Manipulator Hide
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "Hide", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "Hide", true), value);
}
public static event ILContext.Manipulator DelayedDestroyDropdownList
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "DelayedDestroyDropdownList", true).GetStateMachineTarget(), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "DelayedDestroyDropdownList", true).GetStateMachineTarget(), value);
}
public static event ILContext.Manipulator OnSelectItem
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "OnSelectItem", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_Dropdown), "OnSelectItem", true), value);
}
}
