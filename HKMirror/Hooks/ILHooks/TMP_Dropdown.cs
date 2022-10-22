using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TMP_Dropdown,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTMP_Dropdown
{
    public static event ILContext.Manipulator get_template
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "get_template"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "get_template"),
            value);
    }

    public static event ILContext.Manipulator set_template
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "set_template"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "set_template"),
            value);
    }

    public static event ILContext.Manipulator get_captionText
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "get_captionText"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "get_captionText"),
            value);
    }

    public static event ILContext.Manipulator set_captionText
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "set_captionText"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "set_captionText"),
            value);
    }

    public static event ILContext.Manipulator get_captionImage
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "get_captionImage"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "get_captionImage"),
            value);
    }

    public static event ILContext.Manipulator set_captionImage
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "set_captionImage"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "set_captionImage"),
            value);
    }

    public static event ILContext.Manipulator get_itemText
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "get_itemText"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "get_itemText"),
            value);
    }

    public static event ILContext.Manipulator set_itemText
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "set_itemText"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "set_itemText"),
            value);
    }

    public static event ILContext.Manipulator get_itemImage
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "get_itemImage"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "get_itemImage"),
            value);
    }

    public static event ILContext.Manipulator set_itemImage
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "set_itemImage"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "set_itemImage"),
            value);
    }

    public static event ILContext.Manipulator get_options
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "get_options"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "get_options"),
            value);
    }

    public static event ILContext.Manipulator set_options
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "set_options"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "set_options"),
            value);
    }

    public static event ILContext.Manipulator set_onValueChanged
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "set_onValueChanged"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "set_onValueChanged"), value);
    }

    public static event ILContext.Manipulator get_value
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "get_value"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "get_value"), value);
    }

    public static event ILContext.Manipulator set_value
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "set_value"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "set_value"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "Awake"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "Awake"), value);
    }

    public static event ILContext.Manipulator RefreshShownValue
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "RefreshShownValue"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "RefreshShownValue"), value);
    }

    public static event ILContext.Manipulator AddOptions_OptionData
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "AddOptions"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "AddOptions"),
            value);
    }

    public static event ILContext.Manipulator AddOptions_List
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "AddOptions"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "AddOptions"),
            value);
    }

    public static event ILContext.Manipulator AddOptions_Sprite
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "AddOptions"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "AddOptions"),
            value);
    }

    public static event ILContext.Manipulator ClearOptions
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "ClearOptions"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "ClearOptions"),
            value);
    }

    public static event ILContext.Manipulator SetupTemplate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "SetupTemplate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "SetupTemplate"),
            value);
    }

    public static event ILContext.Manipulator OnPointerClick
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "OnPointerClick"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "OnPointerClick"),
            value);
    }

    public static event ILContext.Manipulator OnSubmit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "OnSubmit"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "OnSubmit"), value);
    }

    public static event ILContext.Manipulator OnCancel
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "OnCancel"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "OnCancel"), value);
    }

    public static event ILContext.Manipulator Show
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "Show"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "Show"), value);
    }

    public static event ILContext.Manipulator CreateBlocker
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "CreateBlocker"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "CreateBlocker"),
            value);
    }

    public static event ILContext.Manipulator DestroyBlocker
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "DestroyBlocker"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "DestroyBlocker"),
            value);
    }

    public static event ILContext.Manipulator CreateDropdownList
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "CreateDropdownList"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "CreateDropdownList"), value);
    }

    public static event ILContext.Manipulator DestroyDropdownList
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "DestroyDropdownList"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "DestroyDropdownList"), value);
    }

    public static event ILContext.Manipulator DestroyItem
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "DestroyItem"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "DestroyItem"),
            value);
    }

    public static event ILContext.Manipulator AlphaFadeList_float_float
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "AlphaFadeList"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "AlphaFadeList"),
            value);
    }

    public static event ILContext.Manipulator AlphaFadeList_float_float_float
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "AlphaFadeList"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "AlphaFadeList"),
            value);
    }

    public static event ILContext.Manipulator SetAlpha
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "SetAlpha"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "SetAlpha"), value);
    }

    public static event ILContext.Manipulator Hide
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "Hide"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "Hide"), value);
    }

    public static event ILContext.Manipulator DelayedDestroyDropdownList
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "DelayedDestroyDropdownList").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "DelayedDestroyDropdownList").GetStateMachineTarget(),
            value);
    }

    public static event ILContext.Manipulator OnSelectItem
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "OnSelectItem"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_Dropdown), "OnSelectItem"),
            value);
    }
}