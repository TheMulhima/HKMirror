using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.ILHooks;
/// <summary>
/// Contains all correct IL Hooks for TMP_InputField,
/// Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
/// Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTMP_InputField
{
public static event ILContext.Manipulator get_mesh
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_mesh", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_mesh", true), value);
}
public static event ILContext.Manipulator set_shouldHideMobileInput
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_shouldHideMobileInput", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_shouldHideMobileInput", true), value);
}
public static event ILContext.Manipulator get_shouldHideMobileInput
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_shouldHideMobileInput", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_shouldHideMobileInput", true), value);
}
public static event ILContext.Manipulator get_text
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_text", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_text", true), value);
}
public static event ILContext.Manipulator set_text
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_text", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_text", true), value);
}
public static event ILContext.Manipulator get_isFocused
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_isFocused", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_isFocused", true), value);
}
public static event ILContext.Manipulator get_caretBlinkRate
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_caretBlinkRate", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_caretBlinkRate", true), value);
}
public static event ILContext.Manipulator set_caretBlinkRate
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_caretBlinkRate", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_caretBlinkRate", true), value);
}
public static event ILContext.Manipulator get_caretWidth
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_caretWidth", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_caretWidth", true), value);
}
public static event ILContext.Manipulator set_caretWidth
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_caretWidth", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_caretWidth", true), value);
}
public static event ILContext.Manipulator get_textViewport
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_textViewport", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_textViewport", true), value);
}
public static event ILContext.Manipulator set_textViewport
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_textViewport", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_textViewport", true), value);
}
public static event ILContext.Manipulator get_textComponent
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_textComponent", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_textComponent", true), value);
}
public static event ILContext.Manipulator set_textComponent
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_textComponent", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_textComponent", true), value);
}
public static event ILContext.Manipulator get_placeholder
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_placeholder", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_placeholder", true), value);
}
public static event ILContext.Manipulator set_placeholder
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_placeholder", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_placeholder", true), value);
}
public static event ILContext.Manipulator get_caretColor
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_caretColor", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_caretColor", true), value);
}
public static event ILContext.Manipulator set_caretColor
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_caretColor", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_caretColor", true), value);
}
public static event ILContext.Manipulator get_customCaretColor
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_customCaretColor", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_customCaretColor", true), value);
}
public static event ILContext.Manipulator set_customCaretColor
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_customCaretColor", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_customCaretColor", true), value);
}
public static event ILContext.Manipulator get_selectionColor
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_selectionColor", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_selectionColor", true), value);
}
public static event ILContext.Manipulator set_selectionColor
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_selectionColor", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_selectionColor", true), value);
}
public static event ILContext.Manipulator set_onEndEdit
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_onEndEdit", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_onEndEdit", true), value);
}
public static event ILContext.Manipulator set_onSubmit
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_onSubmit", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_onSubmit", true), value);
}
public static event ILContext.Manipulator set_onFocusLost
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_onFocusLost", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_onFocusLost", true), value);
}
public static event ILContext.Manipulator set_onValueChanged
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_onValueChanged", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_onValueChanged", true), value);
}
public static event ILContext.Manipulator set_onValidateInput
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_onValidateInput", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_onValidateInput", true), value);
}
public static event ILContext.Manipulator get_characterLimit
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_characterLimit", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_characterLimit", true), value);
}
public static event ILContext.Manipulator set_characterLimit
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_characterLimit", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_characterLimit", true), value);
}
public static event ILContext.Manipulator set_contentType
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_contentType", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_contentType", true), value);
}
public static event ILContext.Manipulator set_lineType
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_lineType", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_lineType", true), value);
}
public static event ILContext.Manipulator set_inputType
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_inputType", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_inputType", true), value);
}
public static event ILContext.Manipulator get_keyboardType
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_keyboardType", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_keyboardType", true), value);
}
public static event ILContext.Manipulator set_keyboardType
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_keyboardType", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_keyboardType", true), value);
}
public static event ILContext.Manipulator set_characterValidation
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_characterValidation", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_characterValidation", true), value);
}
public static event ILContext.Manipulator get_readOnly
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_readOnly", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_readOnly", true), value);
}
public static event ILContext.Manipulator set_readOnly
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_readOnly", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_readOnly", true), value);
}
public static event ILContext.Manipulator get_richText
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_richText", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_richText", true), value);
}
public static event ILContext.Manipulator set_richText
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_richText", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_richText", true), value);
}
public static event ILContext.Manipulator get_multiLine
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_multiLine", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_multiLine", true), value);
}
public static event ILContext.Manipulator get_asteriskChar
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_asteriskChar", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_asteriskChar", true), value);
}
public static event ILContext.Manipulator set_asteriskChar
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_asteriskChar", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_asteriskChar", true), value);
}
public static event ILContext.Manipulator get_wasCanceled
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_wasCanceled", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_wasCanceled", true), value);
}
public static event ILContext.Manipulator ClampPos
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "ClampPos", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "ClampPos", true), value);
}
public static event ILContext.Manipulator get_caretPositionInternal
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_caretPositionInternal", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_caretPositionInternal", true), value);
}
public static event ILContext.Manipulator set_caretPositionInternal
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_caretPositionInternal", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_caretPositionInternal", true), value);
}
public static event ILContext.Manipulator get_stringPositionInternal
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_stringPositionInternal", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_stringPositionInternal", true), value);
}
public static event ILContext.Manipulator set_stringPositionInternal
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_stringPositionInternal", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_stringPositionInternal", true), value);
}
public static event ILContext.Manipulator get_caretSelectPositionInternal
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_caretSelectPositionInternal", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_caretSelectPositionInternal", true), value);
}
public static event ILContext.Manipulator set_caretSelectPositionInternal
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_caretSelectPositionInternal", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_caretSelectPositionInternal", true), value);
}
public static event ILContext.Manipulator get_stringSelectPositionInternal
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_stringSelectPositionInternal", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_stringSelectPositionInternal", true), value);
}
public static event ILContext.Manipulator set_stringSelectPositionInternal
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_stringSelectPositionInternal", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_stringSelectPositionInternal", true), value);
}
public static event ILContext.Manipulator get_hasSelection
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_hasSelection", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_hasSelection", true), value);
}
public static event ILContext.Manipulator get_caretPosition
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_caretPosition", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_caretPosition", true), value);
}
public static event ILContext.Manipulator set_caretPosition
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_caretPosition", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_caretPosition", true), value);
}
public static event ILContext.Manipulator get_selectionAnchorPosition
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_selectionAnchorPosition", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_selectionAnchorPosition", true), value);
}
public static event ILContext.Manipulator set_selectionAnchorPosition
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_selectionAnchorPosition", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_selectionAnchorPosition", true), value);
}
public static event ILContext.Manipulator get_selectionFocusPosition
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_selectionFocusPosition", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_selectionFocusPosition", true), value);
}
public static event ILContext.Manipulator set_selectionFocusPosition
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_selectionFocusPosition", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_selectionFocusPosition", true), value);
}
public static event ILContext.Manipulator OnEnable
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "OnEnable", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "OnEnable", true), value);
}
public static event ILContext.Manipulator OnDisable
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "OnDisable", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "OnDisable", true), value);
}
public static event ILContext.Manipulator CaretBlink
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "CaretBlink", true).GetStateMachineTarget(), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "CaretBlink", true).GetStateMachineTarget(), value);
}
public static event ILContext.Manipulator SetCaretVisible
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "SetCaretVisible", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "SetCaretVisible", true), value);
}
public static event ILContext.Manipulator SetCaretActive
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "SetCaretActive", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "SetCaretActive", true), value);
}
public static event ILContext.Manipulator OnFocus
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "OnFocus", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "OnFocus", true), value);
}
public static event ILContext.Manipulator SelectAll
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "SelectAll", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "SelectAll", true), value);
}
public static event ILContext.Manipulator MoveTextEnd
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "MoveTextEnd", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "MoveTextEnd", true), value);
}
public static event ILContext.Manipulator MoveTextStart
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "MoveTextStart", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "MoveTextStart", true), value);
}
public static event ILContext.Manipulator get_clipboard
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_clipboard", false), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "get_clipboard", false), value);
}
public static event ILContext.Manipulator set_clipboard
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_clipboard", false), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "set_clipboard", false), value);
}
public static event ILContext.Manipulator InPlaceEditing
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "InPlaceEditing", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "InPlaceEditing", true), value);
}
public static event ILContext.Manipulator LateUpdate
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "LateUpdate", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "LateUpdate", true), value);
}
public static event ILContext.Manipulator GetCharacterIndexFromPosition
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "GetCharacterIndexFromPosition", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "GetCharacterIndexFromPosition", true), value);
}
public static event ILContext.Manipulator MayDrag
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "MayDrag", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "MayDrag", true), value);
}
public static event ILContext.Manipulator OnBeginDrag
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "OnBeginDrag", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "OnBeginDrag", true), value);
}
public static event ILContext.Manipulator OnDrag
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "OnDrag", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "OnDrag", true), value);
}
public static event ILContext.Manipulator MouseDragOutsideRect
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "MouseDragOutsideRect", true).GetStateMachineTarget(), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "MouseDragOutsideRect", true).GetStateMachineTarget(), value);
}
public static event ILContext.Manipulator OnEndDrag
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "OnEndDrag", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "OnEndDrag", true), value);
}
public static event ILContext.Manipulator OnPointerDown
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "OnPointerDown", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "OnPointerDown", true), value);
}
public static event ILContext.Manipulator IsValidChar
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "IsValidChar", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "IsValidChar", true), value);
}
public static event ILContext.Manipulator ProcessEvent
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "ProcessEvent", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "ProcessEvent", true), value);
}
public static event ILContext.Manipulator OnUpdateSelected
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "OnUpdateSelected", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "OnUpdateSelected", true), value);
}
public static event ILContext.Manipulator GetSelectedString
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "GetSelectedString", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "GetSelectedString", true), value);
}
public static event ILContext.Manipulator FindtNextWordBegin
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "FindtNextWordBegin", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "FindtNextWordBegin", true), value);
}
public static event ILContext.Manipulator MoveRight
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "MoveRight", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "MoveRight", true), value);
}
public static event ILContext.Manipulator FindtPrevWordBegin
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "FindtPrevWordBegin", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "FindtPrevWordBegin", true), value);
}
public static event ILContext.Manipulator MoveLeft
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "MoveLeft", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "MoveLeft", true), value);
}
public static event ILContext.Manipulator LineUpCharacterPosition
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "LineUpCharacterPosition", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "LineUpCharacterPosition", true), value);
}
public static event ILContext.Manipulator LineDownCharacterPosition
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "LineDownCharacterPosition", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "LineDownCharacterPosition", true), value);
}
public static event ILContext.Manipulator MoveDown_bool
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "MoveDown", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "MoveDown", true), value);
}
public static event ILContext.Manipulator MoveDown_bool_bool
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "MoveDown", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "MoveDown", true), value);
}
public static event ILContext.Manipulator MoveUp_bool
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "MoveUp", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "MoveUp", true), value);
}
public static event ILContext.Manipulator MoveUp_bool_bool
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "MoveUp", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "MoveUp", true), value);
}
public static event ILContext.Manipulator Delete
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "Delete", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "Delete", true), value);
}
public static event ILContext.Manipulator ForwardSpace
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "ForwardSpace", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "ForwardSpace", true), value);
}
public static event ILContext.Manipulator Backspace
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "Backspace", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "Backspace", true), value);
}
public static event ILContext.Manipulator Insert
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "Insert", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "Insert", true), value);
}
public static event ILContext.Manipulator SendOnValueChangedAndUpdateLabel
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "SendOnValueChangedAndUpdateLabel", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "SendOnValueChangedAndUpdateLabel", true), value);
}
public static event ILContext.Manipulator SendOnValueChanged
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "SendOnValueChanged", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "SendOnValueChanged", true), value);
}
public static event ILContext.Manipulator SendOnSubmit
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "SendOnSubmit", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "SendOnSubmit", true), value);
}
public static event ILContext.Manipulator SendOnFocusLost
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "SendOnFocusLost", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "SendOnFocusLost", true), value);
}
public static event ILContext.Manipulator Append_string
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "Append", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "Append", true), value);
}
public static event ILContext.Manipulator Append_Char
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "Append", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "Append", true), value);
}
public static event ILContext.Manipulator UpdateLabel
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "UpdateLabel", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "UpdateLabel", true), value);
}
public static event ILContext.Manipulator GetCaretPositionFromStringIndex
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "GetCaretPositionFromStringIndex", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "GetCaretPositionFromStringIndex", true), value);
}
public static event ILContext.Manipulator GetStringIndexFromCaretPosition
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "GetStringIndexFromCaretPosition", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "GetStringIndexFromCaretPosition", true), value);
}
public static event ILContext.Manipulator ForceLabelUpdate
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "ForceLabelUpdate", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "ForceLabelUpdate", true), value);
}
public static event ILContext.Manipulator MarkGeometryAsDirty
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "MarkGeometryAsDirty", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "MarkGeometryAsDirty", true), value);
}
public static event ILContext.Manipulator Rebuild
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "Rebuild", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "Rebuild", true), value);
}
public static event ILContext.Manipulator LayoutComplete
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "LayoutComplete", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "LayoutComplete", true), value);
}
public static event ILContext.Manipulator GraphicUpdateComplete
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "GraphicUpdateComplete", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "GraphicUpdateComplete", true), value);
}
public static event ILContext.Manipulator UpdateGeometry
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "UpdateGeometry", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "UpdateGeometry", true), value);
}
public static event ILContext.Manipulator AssignPositioningIfNeeded
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "AssignPositioningIfNeeded", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "AssignPositioningIfNeeded", true), value);
}
public static event ILContext.Manipulator OnFillVBO
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "OnFillVBO", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "OnFillVBO", true), value);
}
public static event ILContext.Manipulator GenerateCaret
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "GenerateCaret", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "GenerateCaret", true), value);
}
public static event ILContext.Manipulator CreateCursorVerts
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "CreateCursorVerts", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "CreateCursorVerts", true), value);
}
public static event ILContext.Manipulator GenerateHightlight
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "GenerateHightlight", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "GenerateHightlight", true), value);
}
public static event ILContext.Manipulator AdjustRectTransformRelativeToViewport
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "AdjustRectTransformRelativeToViewport", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "AdjustRectTransformRelativeToViewport", true), value);
}
public static event ILContext.Manipulator Validate
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "Validate", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "Validate", true), value);
}
public static event ILContext.Manipulator ActivateInputField
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "ActivateInputField", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "ActivateInputField", true), value);
}
public static event ILContext.Manipulator ActivateInputFieldInternal
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "ActivateInputFieldInternal", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "ActivateInputFieldInternal", true), value);
}
public static event ILContext.Manipulator OnSelect
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "OnSelect", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "OnSelect", true), value);
}
public static event ILContext.Manipulator OnPointerClick
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "OnPointerClick", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "OnPointerClick", true), value);
}
public static event ILContext.Manipulator DeactivateInputField
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "DeactivateInputField", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "DeactivateInputField", true), value);
}
public static event ILContext.Manipulator OnDeselect
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "OnDeselect", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "OnDeselect", true), value);
}
public static event ILContext.Manipulator OnSubmit
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "OnSubmit", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "OnSubmit", true), value);
}
public static event ILContext.Manipulator EnforceContentType
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "EnforceContentType", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "EnforceContentType", true), value);
}
public static event ILContext.Manipulator SetTextComponentWrapMode
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "SetTextComponentWrapMode", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "SetTextComponentWrapMode", true), value);
}
public static event ILContext.Manipulator SetTextComponentRichTextMode
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "SetTextComponentRichTextMode", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "SetTextComponentRichTextMode", true), value);
}
public static event ILContext.Manipulator SetToCustomIfContentTypeIsNot
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "SetToCustomIfContentTypeIsNot", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "SetToCustomIfContentTypeIsNot", true), value);
}
public static event ILContext.Manipulator SetToCustom
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "SetToCustom", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "SetToCustom", true), value);
}
public static event ILContext.Manipulator DoStateTransition
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "DoStateTransition", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "DoStateTransition", true), value);
}
public static event ILContext.Manipulator get_transform
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "UnityEngine.UI.ICanvasElement.get_transform", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMPro.TMP_InputField), "UnityEngine.UI.ICanvasElement.get_transform", true), value);
}
}
