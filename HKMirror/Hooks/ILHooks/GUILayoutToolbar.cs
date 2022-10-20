using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GUILayoutToolbar.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGUILayoutToolbar
{
    public static event ILContext.Manipulator get_Contents
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "get_Contents"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "get_Contents"),
            value);
    }

    public static event ILContext.Manipulator SetButtonsContent
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "SetButtonsContent"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "SetButtonsContent"), value);
    }

    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "Reset"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "Reset"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "OnEnter"),
            value);
    }

    public static event ILContext.Manipulator OnGUI
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "OnGUI"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "OnGUI"), value);
    }

    public static event ILContext.Manipulator ErrorCheck
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "ErrorCheck"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GUILayoutToolbar), "ErrorCheck"),
            value);
    }
}