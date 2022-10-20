using Modding.Menu;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MenuBuilder.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMenuBuilder
{
    public static event ILContext.Manipulator get_MenuObject
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "get_MenuObject"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "get_MenuObject"),
            value);
    }

    public static event ILContext.Manipulator set_MenuObject
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "set_MenuObject"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "set_MenuObject"),
            value);
    }

    public static event ILContext.Manipulator get_Screen
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "get_Screen"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "get_Screen"), value);
    }

    public static event ILContext.Manipulator set_Screen
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "set_Screen"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "set_Screen"), value);
    }

    public static event ILContext.Manipulator get_DefaultNavGraph
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "get_DefaultNavGraph"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "get_DefaultNavGraph"), value);
    }

    public static event ILContext.Manipulator set_DefaultNavGraph
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "set_DefaultNavGraph"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "set_DefaultNavGraph"), value);
    }

    public static event ILContext.Manipulator Build
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "Build"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "Build"), value);
    }

    public static event ILContext.Manipulator AddContent_IContentLayout_INavigationGraph_ContentArea
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "AddContent"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "AddContent"), value);
    }

    public static event ILContext.Manipulator AddContent_IContentLayout_ContentArea
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "AddContent"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "AddContent"), value);
    }

    public static event ILContext.Manipulator AddControls_IContentLayout_INavigationGraph_ContentArea
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "AddControls"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "AddControls"),
            value);
    }

    public static event ILContext.Manipulator AddControls_IContentLayout_ContentArea
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "AddControls"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "AddControls"),
            value);
    }

    public static event ILContext.Manipulator CreateTitle
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "CreateTitle"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "CreateTitle"),
            value);
    }

    public static event ILContext.Manipulator CreateContentPane
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "CreateContentPane"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "CreateContentPane"),
            value);
    }

    public static event ILContext.Manipulator CreateControlPane
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "CreateControlPane"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "CreateControlPane"),
            value);
    }

    public static event ILContext.Manipulator SetDefaultNavGraph
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "SetDefaultNavGraph"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuBuilder), "SetDefaultNavGraph"), value);
    }
}