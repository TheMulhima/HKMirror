using MonoMod.RuntimeDetour.HookGen;
using UnityEngine.UI;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MenuLanguageSetting.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMenuLanguageSetting
{
    public static event ILContext.Manipulator OnEnable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuLanguageSetting), "OnEnable"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuLanguageSetting), "OnEnable"),
            value);
    }

    public static event ILContext.Manipulator UpdateAlpha
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuLanguageSetting), "UpdateAlpha"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuLanguageSetting), "UpdateAlpha"), value);
    }

    public static event ILContext.Manipulator OnMove
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuLanguageSetting), "OnMove"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuLanguageSetting), "OnMove"),
            value);
    }

    public static event ILContext.Manipulator OnPointerClick
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuLanguageSetting), "OnPointerClick"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuLanguageSetting), "OnPointerClick"), value);
    }

    public static event ILContext.Manipulator RectTransformToScreenSpace
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuLanguageSetting), "RectTransformToScreenSpace", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuLanguageSetting), "RectTransformToScreenSpace", false), value);
    }

    public static event ILContext.Manipulator RefreshControls
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuLanguageSetting), "RefreshControls"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuLanguageSetting), "RefreshControls"), value);
    }

    public static event ILContext.Manipulator UpdateLanguageSetting
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuLanguageSetting), "UpdateLanguageSetting"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuLanguageSetting), "UpdateLanguageSetting"), value);
    }

    public static event ILContext.Manipulator RefreshAvailableLanguages
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuLanguageSetting), "RefreshAvailableLanguages"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuLanguageSetting), "RefreshAvailableLanguages"), value);
    }

    public static event ILContext.Manipulator RefreshCurrentIndex
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuLanguageSetting), "RefreshCurrentIndex"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuLanguageSetting), "RefreshCurrentIndex"), value);
    }

    public static event ILContext.Manipulator PushUpdateOptionList
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuLanguageSetting), "PushUpdateOptionList"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuLanguageSetting), "PushUpdateOptionList"), value);
    }

    public static event ILContext.Manipulator UpdateText
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuLanguageSetting), "UpdateText"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuLanguageSetting), "UpdateText"), value);
    }
}