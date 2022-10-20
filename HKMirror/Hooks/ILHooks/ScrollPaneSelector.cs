using Modding.Menu.Components;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ScrollPaneSelector.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILScrollPaneSelector
{
    public static event ILContext.Manipulator get_PaneRect
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ScrollPaneSelector), "get_PaneRect"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ScrollPaneSelector), "get_PaneRect"), value);
    }

    public static event ILContext.Manipulator set_PaneRect
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ScrollPaneSelector), "set_PaneRect"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ScrollPaneSelector), "set_PaneRect"), value);
    }

    public static event ILContext.Manipulator get_MaskRect
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ScrollPaneSelector), "get_MaskRect"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ScrollPaneSelector), "get_MaskRect"), value);
    }

    public static event ILContext.Manipulator set_MaskRect
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ScrollPaneSelector), "set_MaskRect"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ScrollPaneSelector), "set_MaskRect"), value);
    }

    public static event ILContext.Manipulator get_Scrollbar
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ScrollPaneSelector), "get_Scrollbar"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ScrollPaneSelector), "get_Scrollbar"), value);
    }

    public static event ILContext.Manipulator set_Scrollbar
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ScrollPaneSelector), "set_Scrollbar"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ScrollPaneSelector), "set_Scrollbar"), value);
    }

    public static event ILContext.Manipulator get_SelectionPadding
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ScrollPaneSelector), "get_SelectionPadding"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ScrollPaneSelector), "get_SelectionPadding"), value);
    }

    public static event ILContext.Manipulator set_SelectionPadding
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ScrollPaneSelector), "set_SelectionPadding"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ScrollPaneSelector), "set_SelectionPadding"), value);
    }

    public static event ILContext.Manipulator OnSelect
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ScrollPaneSelector), "OnSelect"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ScrollPaneSelector), "OnSelect"),
            value);
    }
}