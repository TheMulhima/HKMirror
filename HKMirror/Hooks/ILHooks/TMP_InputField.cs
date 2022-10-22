using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TMP_InputField,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTMP_InputField
{
    public static event ILContext.Manipulator get_mesh
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_mesh"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_mesh"),
            value);
    }

    public static event ILContext.Manipulator set_shouldHideMobileInput
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_shouldHideMobileInput"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_shouldHideMobileInput"), value);
    }

    public static event ILContext.Manipulator get_shouldHideMobileInput
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_shouldHideMobileInput"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_shouldHideMobileInput"), value);
    }

    public static event ILContext.Manipulator get_text
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_text"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_text"),
            value);
    }

    public static event ILContext.Manipulator set_text
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_text"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_text"),
            value);
    }

    public static event ILContext.Manipulator get_isFocused
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_isFocused"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_isFocused"),
            value);
    }

    public static event ILContext.Manipulator get_caretBlinkRate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_caretBlinkRate"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_caretBlinkRate"), value);
    }

    public static event ILContext.Manipulator set_caretBlinkRate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_caretBlinkRate"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_caretBlinkRate"), value);
    }

    public static event ILContext.Manipulator get_caretWidth
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_caretWidth"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_caretWidth"),
            value);
    }

    public static event ILContext.Manipulator set_caretWidth
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_caretWidth"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_caretWidth"),
            value);
    }

    public static event ILContext.Manipulator get_textViewport
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_textViewport"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_textViewport"), value);
    }

    public static event ILContext.Manipulator set_textViewport
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_textViewport"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_textViewport"), value);
    }

    public static event ILContext.Manipulator get_textComponent
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_textComponent"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_textComponent"), value);
    }

    public static event ILContext.Manipulator set_textComponent
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_textComponent"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_textComponent"), value);
    }

    public static event ILContext.Manipulator get_placeholder
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_placeholder"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_placeholder"), value);
    }

    public static event ILContext.Manipulator set_placeholder
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_placeholder"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_placeholder"), value);
    }

    public static event ILContext.Manipulator get_caretColor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_caretColor"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_caretColor"),
            value);
    }

    public static event ILContext.Manipulator set_caretColor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_caretColor"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_caretColor"),
            value);
    }

    public static event ILContext.Manipulator get_customCaretColor
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_customCaretColor"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_customCaretColor"), value);
    }

    public static event ILContext.Manipulator set_customCaretColor
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_customCaretColor"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_customCaretColor"), value);
    }

    public static event ILContext.Manipulator get_selectionColor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_selectionColor"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_selectionColor"), value);
    }

    public static event ILContext.Manipulator set_selectionColor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_selectionColor"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_selectionColor"), value);
    }

    public static event ILContext.Manipulator set_onEndEdit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_onEndEdit"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_onEndEdit"),
            value);
    }

    public static event ILContext.Manipulator set_onSubmit
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_onSubmit"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_onSubmit"),
            value);
    }

    public static event ILContext.Manipulator set_onFocusLost
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_onFocusLost"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_onFocusLost"), value);
    }

    public static event ILContext.Manipulator set_onValueChanged
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_onValueChanged"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_onValueChanged"), value);
    }

    public static event ILContext.Manipulator set_onValidateInput
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_onValidateInput"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_onValidateInput"), value);
    }

    public static event ILContext.Manipulator get_characterLimit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_characterLimit"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_characterLimit"), value);
    }

    public static event ILContext.Manipulator set_characterLimit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_characterLimit"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_characterLimit"), value);
    }

    public static event ILContext.Manipulator set_contentType
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_contentType"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_contentType"), value);
    }

    public static event ILContext.Manipulator set_lineType
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_lineType"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_lineType"),
            value);
    }

    public static event ILContext.Manipulator set_inputType
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_inputType"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_inputType"),
            value);
    }

    public static event ILContext.Manipulator get_keyboardType
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_keyboardType"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_keyboardType"), value);
    }

    public static event ILContext.Manipulator set_keyboardType
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_keyboardType"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_keyboardType"), value);
    }

    public static event ILContext.Manipulator set_characterValidation
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_characterValidation"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_characterValidation"), value);
    }

    public static event ILContext.Manipulator get_readOnly
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_readOnly"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_readOnly"),
            value);
    }

    public static event ILContext.Manipulator set_readOnly
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_readOnly"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_readOnly"),
            value);
    }

    public static event ILContext.Manipulator get_richText
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_richText"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_richText"),
            value);
    }

    public static event ILContext.Manipulator set_richText
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_richText"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_richText"),
            value);
    }

    public static event ILContext.Manipulator get_multiLine
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_multiLine"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_multiLine"),
            value);
    }

    public static event ILContext.Manipulator get_asteriskChar
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_asteriskChar"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_asteriskChar"), value);
    }

    public static event ILContext.Manipulator set_asteriskChar
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_asteriskChar"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_asteriskChar"), value);
    }

    public static event ILContext.Manipulator get_wasCanceled
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_wasCanceled"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_wasCanceled"), value);
    }

    public static event ILContext.Manipulator ClampPos
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "ClampPos"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "ClampPos"),
            value);
    }

    public static event ILContext.Manipulator get_caretPositionInternal
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_caretPositionInternal"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_caretPositionInternal"), value);
    }

    public static event ILContext.Manipulator set_caretPositionInternal
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_caretPositionInternal"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_caretPositionInternal"), value);
    }

    public static event ILContext.Manipulator get_stringPositionInternal
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_stringPositionInternal"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_stringPositionInternal"), value);
    }

    public static event ILContext.Manipulator set_stringPositionInternal
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_stringPositionInternal"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_stringPositionInternal"), value);
    }

    public static event ILContext.Manipulator get_caretSelectPositionInternal
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_caretSelectPositionInternal"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_caretSelectPositionInternal"), value);
    }

    public static event ILContext.Manipulator set_caretSelectPositionInternal
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_caretSelectPositionInternal"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_caretSelectPositionInternal"), value);
    }

    public static event ILContext.Manipulator get_stringSelectPositionInternal
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_stringSelectPositionInternal"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_stringSelectPositionInternal"), value);
    }

    public static event ILContext.Manipulator set_stringSelectPositionInternal
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_stringSelectPositionInternal"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_stringSelectPositionInternal"), value);
    }

    public static event ILContext.Manipulator get_hasSelection
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_hasSelection"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_hasSelection"), value);
    }

    public static event ILContext.Manipulator get_caretPosition
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_caretPosition"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_caretPosition"), value);
    }

    public static event ILContext.Manipulator set_caretPosition
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_caretPosition"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_caretPosition"), value);
    }

    public static event ILContext.Manipulator get_selectionAnchorPosition
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_selectionAnchorPosition"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_selectionAnchorPosition"), value);
    }

    public static event ILContext.Manipulator set_selectionAnchorPosition
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_selectionAnchorPosition"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_selectionAnchorPosition"), value);
    }

    public static event ILContext.Manipulator get_selectionFocusPosition
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_selectionFocusPosition"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_selectionFocusPosition"), value);
    }

    public static event ILContext.Manipulator set_selectionFocusPosition
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_selectionFocusPosition"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_selectionFocusPosition"), value);
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "OnEnable"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "OnEnable"),
            value);
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "OnDisable"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "OnDisable"),
            value);
    }

    public static event ILContext.Manipulator CaretBlink
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "CaretBlink").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "CaretBlink").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator SetCaretVisible
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "SetCaretVisible"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "SetCaretVisible"), value);
    }

    public static event ILContext.Manipulator SetCaretActive
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "SetCaretActive"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "SetCaretActive"),
            value);
    }

    public static event ILContext.Manipulator OnFocus
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "OnFocus"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "OnFocus"), value);
    }

    public static event ILContext.Manipulator SelectAll
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "SelectAll"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "SelectAll"),
            value);
    }

    public static event ILContext.Manipulator MoveTextEnd
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "MoveTextEnd"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "MoveTextEnd"),
            value);
    }

    public static event ILContext.Manipulator MoveTextStart
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "MoveTextStart"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "MoveTextStart"),
            value);
    }

    public static event ILContext.Manipulator get_clipboard
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_clipboard", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "get_clipboard", false), value);
    }

    public static event ILContext.Manipulator set_clipboard
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_clipboard", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "set_clipboard", false), value);
    }

    public static event ILContext.Manipulator InPlaceEditing
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "InPlaceEditing"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "InPlaceEditing"),
            value);
    }

    public static event ILContext.Manipulator LateUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "LateUpdate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "LateUpdate"),
            value);
    }

    public static event ILContext.Manipulator GetCharacterIndexFromPosition
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "GetCharacterIndexFromPosition"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "GetCharacterIndexFromPosition"), value);
    }

    public static event ILContext.Manipulator MayDrag
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "MayDrag"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "MayDrag"), value);
    }

    public static event ILContext.Manipulator OnBeginDrag
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "OnBeginDrag"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "OnBeginDrag"),
            value);
    }

    public static event ILContext.Manipulator OnDrag
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "OnDrag"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "OnDrag"), value);
    }

    public static event ILContext.Manipulator MouseDragOutsideRect
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "MouseDragOutsideRect").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "MouseDragOutsideRect").GetStateMachineTarget(),
            value);
    }

    public static event ILContext.Manipulator OnEndDrag
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "OnEndDrag"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "OnEndDrag"),
            value);
    }

    public static event ILContext.Manipulator OnPointerDown
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "OnPointerDown"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "OnPointerDown"),
            value);
    }

    public static event ILContext.Manipulator IsValidChar
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "IsValidChar"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "IsValidChar"),
            value);
    }

    public static event ILContext.Manipulator ProcessEvent
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "ProcessEvent"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "ProcessEvent"),
            value);
    }

    public static event ILContext.Manipulator OnUpdateSelected
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "OnUpdateSelected"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "OnUpdateSelected"), value);
    }

    public static event ILContext.Manipulator GetSelectedString
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "GetSelectedString"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "GetSelectedString"), value);
    }

    public static event ILContext.Manipulator FindtNextWordBegin
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "FindtNextWordBegin"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "FindtNextWordBegin"), value);
    }

    public static event ILContext.Manipulator MoveRight
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "MoveRight"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "MoveRight"),
            value);
    }

    public static event ILContext.Manipulator FindtPrevWordBegin
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "FindtPrevWordBegin"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "FindtPrevWordBegin"), value);
    }

    public static event ILContext.Manipulator MoveLeft
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "MoveLeft"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "MoveLeft"),
            value);
    }

    public static event ILContext.Manipulator LineUpCharacterPosition
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "LineUpCharacterPosition"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "LineUpCharacterPosition"), value);
    }

    public static event ILContext.Manipulator LineDownCharacterPosition
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "LineDownCharacterPosition"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "LineDownCharacterPosition"), value);
    }

    public static event ILContext.Manipulator MoveDown_bool
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "MoveDown"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "MoveDown"),
            value);
    }

    public static event ILContext.Manipulator MoveDown_bool_bool
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "MoveDown"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "MoveDown"),
            value);
    }

    public static event ILContext.Manipulator MoveUp_bool
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "MoveUp"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "MoveUp"), value);
    }

    public static event ILContext.Manipulator MoveUp_bool_bool
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "MoveUp"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "MoveUp"), value);
    }

    public static event ILContext.Manipulator Delete
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "Delete"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "Delete"), value);
    }

    public static event ILContext.Manipulator ForwardSpace
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "ForwardSpace"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "ForwardSpace"),
            value);
    }

    public static event ILContext.Manipulator Backspace
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "Backspace"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "Backspace"),
            value);
    }

    public static event ILContext.Manipulator Insert
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "Insert"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "Insert"), value);
    }

    public static event ILContext.Manipulator SendOnValueChangedAndUpdateLabel
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "SendOnValueChangedAndUpdateLabel"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "SendOnValueChangedAndUpdateLabel"), value);
    }

    public static event ILContext.Manipulator SendOnValueChanged
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "SendOnValueChanged"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "SendOnValueChanged"), value);
    }

    public static event ILContext.Manipulator SendOnSubmit
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "SendOnSubmit"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "SendOnSubmit"),
            value);
    }

    public static event ILContext.Manipulator SendOnFocusLost
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "SendOnFocusLost"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "SendOnFocusLost"), value);
    }

    public static event ILContext.Manipulator Append_string
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "Append"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "Append"), value);
    }

    public static event ILContext.Manipulator Append_Char
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "Append"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "Append"), value);
    }

    public static event ILContext.Manipulator UpdateLabel
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "UpdateLabel"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "UpdateLabel"),
            value);
    }

    public static event ILContext.Manipulator GetCaretPositionFromStringIndex
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "GetCaretPositionFromStringIndex"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "GetCaretPositionFromStringIndex"), value);
    }

    public static event ILContext.Manipulator GetStringIndexFromCaretPosition
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "GetStringIndexFromCaretPosition"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "GetStringIndexFromCaretPosition"), value);
    }

    public static event ILContext.Manipulator ForceLabelUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "ForceLabelUpdate"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "ForceLabelUpdate"), value);
    }

    public static event ILContext.Manipulator MarkGeometryAsDirty
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "MarkGeometryAsDirty"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "MarkGeometryAsDirty"), value);
    }

    public static event ILContext.Manipulator Rebuild
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "Rebuild"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "Rebuild"), value);
    }

    public static event ILContext.Manipulator LayoutComplete
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "LayoutComplete"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "LayoutComplete"),
            value);
    }

    public static event ILContext.Manipulator GraphicUpdateComplete
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "GraphicUpdateComplete"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "GraphicUpdateComplete"), value);
    }

    public static event ILContext.Manipulator UpdateGeometry
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "UpdateGeometry"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "UpdateGeometry"),
            value);
    }

    public static event ILContext.Manipulator AssignPositioningIfNeeded
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "AssignPositioningIfNeeded"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "AssignPositioningIfNeeded"), value);
    }

    public static event ILContext.Manipulator OnFillVBO
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "OnFillVBO"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "OnFillVBO"),
            value);
    }

    public static event ILContext.Manipulator GenerateCaret
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "GenerateCaret"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "GenerateCaret"),
            value);
    }

    public static event ILContext.Manipulator CreateCursorVerts
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "CreateCursorVerts"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "CreateCursorVerts"), value);
    }

    public static event ILContext.Manipulator GenerateHightlight
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "GenerateHightlight"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "GenerateHightlight"), value);
    }

    public static event ILContext.Manipulator AdjustRectTransformRelativeToViewport
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "AdjustRectTransformRelativeToViewport"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "AdjustRectTransformRelativeToViewport"), value);
    }

    public static event ILContext.Manipulator Validate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "Validate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "Validate"),
            value);
    }

    public static event ILContext.Manipulator ActivateInputField
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "ActivateInputField"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "ActivateInputField"), value);
    }

    public static event ILContext.Manipulator ActivateInputFieldInternal
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "ActivateInputFieldInternal"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "ActivateInputFieldInternal"), value);
    }

    public static event ILContext.Manipulator OnSelect
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "OnSelect"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "OnSelect"),
            value);
    }

    public static event ILContext.Manipulator OnPointerClick
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "OnPointerClick"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "OnPointerClick"),
            value);
    }

    public static event ILContext.Manipulator DeactivateInputField
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "DeactivateInputField"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "DeactivateInputField"), value);
    }

    public static event ILContext.Manipulator OnDeselect
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "OnDeselect"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "OnDeselect"),
            value);
    }

    public static event ILContext.Manipulator OnSubmit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "OnSubmit"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "OnSubmit"),
            value);
    }

    public static event ILContext.Manipulator EnforceContentType
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "EnforceContentType"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "EnforceContentType"), value);
    }

    public static event ILContext.Manipulator SetTextComponentWrapMode
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "SetTextComponentWrapMode"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "SetTextComponentWrapMode"), value);
    }

    public static event ILContext.Manipulator SetTextComponentRichTextMode
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "SetTextComponentRichTextMode"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "SetTextComponentRichTextMode"), value);
    }

    public static event ILContext.Manipulator SetToCustomIfContentTypeIsNot
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "SetToCustomIfContentTypeIsNot"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "SetToCustomIfContentTypeIsNot"), value);
    }

    public static event ILContext.Manipulator SetToCustom
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "SetToCustom"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "SetToCustom"),
            value);
    }

    public static event ILContext.Manipulator DoStateTransition
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "DoStateTransition"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "DoStateTransition"), value);
    }

    public static event ILContext.Manipulator get_transform
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "UnityEngine.UI.ICanvasElement.get_transform"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_InputField), "UnityEngine.UI.ICanvasElement.get_transform"),
            value);
    }
}