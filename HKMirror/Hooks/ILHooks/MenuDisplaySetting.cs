using MonoMod.RuntimeDetour.HookGen;
using UnityEngine.UI;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MenuDisplaySetting.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMenuDisplaySetting
{
    public static event ILContext.Manipulator OnEnable
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "OnEnable"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "OnEnable"),
            value);
    }

    public static event ILContext.Manipulator OnMove
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "OnMove"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "OnMove"),
            value);
    }

    public static event ILContext.Manipulator OnPointerClick
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "OnPointerClick"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "OnPointerClick"), value);
    }

    public static event ILContext.Manipulator RefreshControls
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "RefreshControls"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "RefreshControls"), value);
    }

    public static event ILContext.Manipulator DisableMonitorSelectSetting
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "DisableMonitorSelectSetting"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "DisableMonitorSelectSetting"), value);
    }

    public static event ILContext.Manipulator UpdateMonitorSetting
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "UpdateMonitorSetting"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "UpdateMonitorSetting"), value);
    }

    public static event ILContext.Manipulator RefreshCurrentIndex
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "RefreshCurrentIndex"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "RefreshCurrentIndex"), value);
    }

    public static event ILContext.Manipulator PushUpdateOptionList
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "PushUpdateOptionList"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "PushUpdateOptionList"), value);
    }

    public static event ILContext.Manipulator TargetDisplayHack
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "TargetDisplayHack").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuDisplaySetting), "TargetDisplayHack").GetStateMachineTarget(),
            value);
    }
}