using MonoMod.RuntimeDetour.HookGen;
using UnityEngine.UI;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MenuSelectable.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMenuSelectable
{
    public static event ILContext.Manipulator get_DontPlaySelectSound
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "get_DontPlaySelectSound"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "get_DontPlaySelectSound"), value);
    }

    public static event ILContext.Manipulator set_DontPlaySelectSound
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "set_DontPlaySelectSound"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "set_DontPlaySelectSound"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "Awake"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "Awake"), value);
    }

    public static event ILContext.Manipulator Start
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "Start"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "Start"), value);
    }

    public static event ILContext.Manipulator OnSelect
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "OnSelect"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "OnSelect"),
            value);
    }

    public static event ILContext.Manipulator OnDeselect
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "OnDeselect"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "OnDeselect"),
            value);
    }

    public static event ILContext.Manipulator ForceDeselect
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "ForceDeselect"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "ForceDeselect"),
            value);
    }

    public static event ILContext.Manipulator OnCancel
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "OnCancel"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "OnCancel"),
            value);
    }

    public static event ILContext.Manipulator ValidateDeselect
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "ValidateDeselect").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "ValidateDeselect").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator HookUpAudioPlayer
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "HookUpAudioPlayer"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "HookUpAudioPlayer"), value);
    }

    public static event ILContext.Manipulator PlaySubmitSound
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "PlaySubmitSound"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "PlaySubmitSound"), value);
    }

    public static event ILContext.Manipulator PlayCancelSound
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "PlayCancelSound"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "PlayCancelSound"), value);
    }

    public static event ILContext.Manipulator PlaySelectSound
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "PlaySelectSound"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "PlaySelectSound"), value);
    }

    public static event ILContext.Manipulator get_customCancelAction
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "get_customCancelAction"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "get_customCancelAction"), value);
    }

    public static event ILContext.Manipulator set_customCancelAction
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "set_customCancelAction"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "set_customCancelAction"), value);
    }

    public static event ILContext.Manipulator orig_OnCancel
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "orig_OnCancel"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuSelectable), "orig_OnCancel"),
            value);
    }
}