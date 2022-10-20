using Modding.Menu;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MenuResources.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMenuResources
{
    public static event ILContext.Manipulator get_TrajanRegular
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "get_TrajanRegular", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "get_TrajanRegular", false), value);
    }

    public static event ILContext.Manipulator set_TrajanRegular
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "set_TrajanRegular", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "set_TrajanRegular", false), value);
    }

    public static event ILContext.Manipulator get_TrajanBold
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "get_TrajanBold", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "get_TrajanBold", false), value);
    }

    public static event ILContext.Manipulator set_TrajanBold
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "set_TrajanBold", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "set_TrajanBold", false), value);
    }

    public static event ILContext.Manipulator get_Perpetua
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuResources), "get_Perpetua", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "get_Perpetua", false), value);
    }

    public static event ILContext.Manipulator set_Perpetua
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuResources), "set_Perpetua", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "set_Perpetua", false), value);
    }

    public static event ILContext.Manipulator get_NotoSerifCJKSCRegular
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "get_NotoSerifCJKSCRegular", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "get_NotoSerifCJKSCRegular", false), value);
    }

    public static event ILContext.Manipulator set_NotoSerifCJKSCRegular
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "set_NotoSerifCJKSCRegular", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "set_NotoSerifCJKSCRegular", false), value);
    }

    public static event ILContext.Manipulator get_MenuTopFleurAnimator
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "get_MenuTopFleurAnimator", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "get_MenuTopFleurAnimator", false), value);
    }

    public static event ILContext.Manipulator set_MenuTopFleurAnimator
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "set_MenuTopFleurAnimator", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "set_MenuTopFleurAnimator", false), value);
    }

    public static event ILContext.Manipulator get_MenuCursorAnimator
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "get_MenuCursorAnimator", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "get_MenuCursorAnimator", false), value);
    }

    public static event ILContext.Manipulator set_MenuCursorAnimator
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "set_MenuCursorAnimator", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "set_MenuCursorAnimator", false), value);
    }

    public static event ILContext.Manipulator get_MenuButtonFlashAnimator
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "get_MenuButtonFlashAnimator", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "get_MenuButtonFlashAnimator", false), value);
    }

    public static event ILContext.Manipulator set_MenuButtonFlashAnimator
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "set_MenuButtonFlashAnimator", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "set_MenuButtonFlashAnimator", false), value);
    }

    public static event ILContext.Manipulator get_TextHideShowAnimator
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "get_TextHideShowAnimator", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "get_TextHideShowAnimator", false), value);
    }

    public static event ILContext.Manipulator set_TextHideShowAnimator
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "set_TextHideShowAnimator", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "set_TextHideShowAnimator", false), value);
    }

    public static event ILContext.Manipulator get_ScrollbarHandleSprite
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "get_ScrollbarHandleSprite", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "get_ScrollbarHandleSprite", false), value);
    }

    public static event ILContext.Manipulator set_ScrollbarHandleSprite
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "set_ScrollbarHandleSprite", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "set_ScrollbarHandleSprite", false), value);
    }

    public static event ILContext.Manipulator get_ScrollbarBackgroundSprite
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "get_ScrollbarBackgroundSprite", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "get_ScrollbarBackgroundSprite", false), value);
    }

    public static event ILContext.Manipulator set_ScrollbarBackgroundSprite
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "set_ScrollbarBackgroundSprite", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "set_ScrollbarBackgroundSprite", false), value);
    }

    public static event ILContext.Manipulator ReloadResources
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "ReloadResources", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuResources), "ReloadResources", false), value);
    }
}