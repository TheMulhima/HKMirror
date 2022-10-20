using MonoMod.RuntimeDetour.HookGen;
using UnityEngine.UI;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PauseMenuButton.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPauseMenuButton
{
    public static event ILContext.Manipulator get_cancelAction
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PauseMenuButton), "get_cancelAction"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PauseMenuButton), "get_cancelAction"), value);
    }

    public static event ILContext.Manipulator set_cancelAction
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PauseMenuButton), "set_cancelAction"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PauseMenuButton), "set_cancelAction"), value);
    }

    public static event ILContext.Manipulator Start
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PauseMenuButton), "Start"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PauseMenuButton), "Start"), value);
    }

    public static event ILContext.Manipulator OnSubmit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PauseMenuButton), "OnSubmit"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PauseMenuButton), "OnSubmit"),
            value);
    }

    public static event ILContext.Manipulator OnCancel
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PauseMenuButton), "OnCancel"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PauseMenuButton), "OnCancel"),
            value);
    }

    public static event ILContext.Manipulator OnPointerClick
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PauseMenuButton), "OnPointerClick"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PauseMenuButton), "OnPointerClick"), value);
    }
}