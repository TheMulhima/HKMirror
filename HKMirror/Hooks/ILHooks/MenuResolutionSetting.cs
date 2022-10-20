using MonoMod.RuntimeDetour.HookGen;
using UnityEngine.UI;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MenuResolutionSetting.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMenuResolutionSetting
{
    public static event ILContext.Manipulator get_currentRes
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "get_currentRes"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "get_currentRes"), value);
    }

    public static event ILContext.Manipulator set_currentRes
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "set_currentRes"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "set_currentRes"), value);
    }

    public static event ILContext.Manipulator get_screenRes
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "get_screenRes"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "get_screenRes"), value);
    }

    public static event ILContext.Manipulator set_screenRes
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "set_screenRes"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "set_screenRes"), value);
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "OnEnable"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "OnEnable"), value);
    }

    public static event ILContext.Manipulator OnSubmit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "OnSubmit"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "OnSubmit"), value);
    }

    public static event ILContext.Manipulator OnMove
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "OnMove"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "OnMove"),
            value);
    }

    public static event ILContext.Manipulator OnPointerClick
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "OnPointerClick"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "OnPointerClick"), value);
    }

    public static event ILContext.Manipulator ApplySettings
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "ApplySettings"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "ApplySettings"), value);
    }

    public static event ILContext.Manipulator UpdateApplyButton
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "UpdateApplyButton"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "UpdateApplyButton"), value);
    }

    public static event ILContext.Manipulator ResetToDefaultResolution
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "ResetToDefaultResolution"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "ResetToDefaultResolution"), value);
    }

    public static event ILContext.Manipulator RefreshControls
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "RefreshControls"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "RefreshControls"), value);
    }

    public static event ILContext.Manipulator RollbackResolution
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "RollbackResolution"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "RollbackResolution"), value);
    }

    public static event ILContext.Manipulator RefreshCurrentIndex
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "RefreshCurrentIndex"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "RefreshCurrentIndex"), value);
    }

    public static event ILContext.Manipulator PushUpdateOptionList
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "PushUpdateOptionList"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "PushUpdateOptionList"), value);
    }

    public static event ILContext.Manipulator HideApplyButton
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "HideApplyButton"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "HideApplyButton"), value);
    }

    public static event ILContext.Manipulator ShowApplyButton
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "ShowApplyButton"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "ShowApplyButton"), value);
    }

    public static event ILContext.Manipulator RefreshAvailableResolutions
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "RefreshAvailableResolutions"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "RefreshAvailableResolutions"), value);
    }

    public static event ILContext.Manipulator RefreshOnNextFrame
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "RefreshOnNextFrame").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResolutionSetting), "RefreshOnNextFrame").GetStateMachineTarget(),
            value);
    }
}