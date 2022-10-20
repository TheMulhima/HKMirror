using MonoMod.RuntimeDetour.HookGen;
using UnityEngine.UI;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MenuFrameCapSetting.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMenuFrameCapSetting
{
    public static event ILContext.Manipulator OnEnable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuFrameCapSetting), "OnEnable"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuFrameCapSetting), "OnEnable"),
            value);
    }

    public static event ILContext.Manipulator OnMove
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuFrameCapSetting), "OnMove"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuFrameCapSetting), "OnMove"),
            value);
    }

    public static event ILContext.Manipulator OnPointerClick
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuFrameCapSetting), "OnPointerClick"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuFrameCapSetting), "OnPointerClick"), value);
    }

    public static event ILContext.Manipulator RefreshControls
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuFrameCapSetting), "RefreshControls"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuFrameCapSetting), "RefreshControls"), value);
    }

    public static event ILContext.Manipulator DisableFrameCapSetting
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuFrameCapSetting), "DisableFrameCapSetting"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuFrameCapSetting), "DisableFrameCapSetting"), value);
    }

    public static event ILContext.Manipulator ApplyValueFromGameSettings
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuFrameCapSetting), "ApplyValueFromGameSettings"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuFrameCapSetting), "ApplyValueFromGameSettings"), value);
    }

    public static event ILContext.Manipulator UpdateFrameCapSetting
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuFrameCapSetting), "UpdateFrameCapSetting"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuFrameCapSetting), "UpdateFrameCapSetting"), value);
    }

    public static event ILContext.Manipulator RefreshCurrentIndex
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuFrameCapSetting), "RefreshCurrentIndex"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuFrameCapSetting), "RefreshCurrentIndex"), value);
    }

    public static event ILContext.Manipulator PushUpdateOptionList
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuFrameCapSetting), "PushUpdateOptionList"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuFrameCapSetting), "PushUpdateOptionList"), value);
    }
}