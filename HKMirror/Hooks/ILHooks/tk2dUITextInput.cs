using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dUITextInput.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dUITextInput
{
    public static event ILContext.Manipulator get_LayoutItem
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUITextInput), "get_LayoutItem"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUITextInput), "get_LayoutItem"), value);
    }

    public static event ILContext.Manipulator set_LayoutItem
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUITextInput), "set_LayoutItem"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUITextInput), "set_LayoutItem"), value);
    }

    public static event ILContext.Manipulator get_SendMessageTarget
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUITextInput), "get_SendMessageTarget"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUITextInput), "get_SendMessageTarget"), value);
    }

    public static event ILContext.Manipulator set_SendMessageTarget
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUITextInput), "set_SendMessageTarget"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUITextInput), "set_SendMessageTarget"), value);
    }

    public static event ILContext.Manipulator get_IsFocus
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUITextInput), "get_IsFocus"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dUITextInput), "get_IsFocus"),
            value);
    }

    public static event ILContext.Manipulator get_Text
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUITextInput), "get_Text"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dUITextInput), "get_Text"),
            value);
    }

    public static event ILContext.Manipulator set_Text
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUITextInput), "set_Text"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dUITextInput), "set_Text"),
            value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.tk2dUITextInput.Awake += value;
        remove => IL.tk2dUITextInput.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.tk2dUITextInput.Start += value;
        remove => IL.tk2dUITextInput.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.tk2dUITextInput.OnEnable += value;
        remove => IL.tk2dUITextInput.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.tk2dUITextInput.OnDisable += value;
        remove => IL.tk2dUITextInput.OnDisable -= value;
    }

    public static event ILContext.Manipulator SetFocus
    {
        add => IL.tk2dUITextInput.SetFocus += value;
        remove => IL.tk2dUITextInput.SetFocus -= value;
    }

    public static event ILContext.Manipulator SetFocus_bool
    {
        add => IL.tk2dUITextInput.SetFocus_bool += value;
        remove => IL.tk2dUITextInput.SetFocus_bool -= value;
    }

    public static event ILContext.Manipulator FormatTextForDisplay
    {
        add => IL.tk2dUITextInput.FormatTextForDisplay += value;
        remove => IL.tk2dUITextInput.FormatTextForDisplay -= value;
    }

    public static event ILContext.Manipulator ListenForKeyboardTextUpdate
    {
        add => IL.tk2dUITextInput.ListenForKeyboardTextUpdate += value;
        remove => IL.tk2dUITextInput.ListenForKeyboardTextUpdate -= value;
    }

    public static event ILContext.Manipulator InputSelected
    {
        add => IL.tk2dUITextInput.InputSelected += value;
        remove => IL.tk2dUITextInput.InputSelected -= value;
    }

    public static event ILContext.Manipulator InputDeselected
    {
        add => IL.tk2dUITextInput.InputDeselected += value;
        remove => IL.tk2dUITextInput.InputDeselected -= value;
    }

    public static event ILContext.Manipulator AnyPress
    {
        add => IL.tk2dUITextInput.AnyPress += value;
        remove => IL.tk2dUITextInput.AnyPress -= value;
    }

    public static event ILContext.Manipulator SetState
    {
        add => IL.tk2dUITextInput.SetState += value;
        remove => IL.tk2dUITextInput.SetState -= value;
    }

    public static event ILContext.Manipulator SetCursorPosition
    {
        add => IL.tk2dUITextInput.SetCursorPosition += value;
        remove => IL.tk2dUITextInput.SetCursorPosition -= value;
    }

    public static event ILContext.Manipulator ShowDisplayText
    {
        add => IL.tk2dUITextInput.ShowDisplayText += value;
        remove => IL.tk2dUITextInput.ShowDisplayText -= value;
    }

    public static event ILContext.Manipulator HideDisplayText
    {
        add => IL.tk2dUITextInput.HideDisplayText += value;
        remove => IL.tk2dUITextInput.HideDisplayText -= value;
    }

    public static event ILContext.Manipulator LayoutReshaped
    {
        add => IL.tk2dUITextInput.LayoutReshaped += value;
        remove => IL.tk2dUITextInput.LayoutReshaped -= value;
    }
}