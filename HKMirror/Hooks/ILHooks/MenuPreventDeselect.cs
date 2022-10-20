using MonoMod.RuntimeDetour.HookGen;
using UnityEngine.UI;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MenuPreventDeselect.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMenuPreventDeselect
{
    public static event ILContext.Manipulator Start
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuPreventDeselect), "Start"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuPreventDeselect), "Start"),
            value);
    }

    public static event ILContext.Manipulator OnSelect
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuPreventDeselect), "OnSelect"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuPreventDeselect), "OnSelect"),
            value);
    }

    public static event ILContext.Manipulator OnDeselect
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuPreventDeselect), "OnDeselect"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuPreventDeselect), "OnDeselect"), value);
    }

    public static event ILContext.Manipulator OnCancel
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuPreventDeselect), "OnCancel"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuPreventDeselect), "OnCancel"),
            value);
    }

    public static event ILContext.Manipulator ValidateDeselect
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuPreventDeselect), "ValidateDeselect").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuPreventDeselect), "ValidateDeselect").GetStateMachineTarget(),
            value);
    }

    public static event ILContext.Manipulator HookUpAudioPlayer
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuPreventDeselect), "HookUpAudioPlayer"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuPreventDeselect), "HookUpAudioPlayer"), value);
    }

    public static event ILContext.Manipulator ForceDeselect
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuPreventDeselect), "ForceDeselect"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuPreventDeselect), "ForceDeselect"), value);
    }

    public static event ILContext.Manipulator SimulateSubmit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuPreventDeselect), "SimulateSubmit"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuPreventDeselect), "SimulateSubmit"), value);
    }

    public static event ILContext.Manipulator get_customCancelAction
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuPreventDeselect), "get_customCancelAction"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuPreventDeselect), "get_customCancelAction"), value);
    }

    public static event ILContext.Manipulator set_customCancelAction
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuPreventDeselect), "set_customCancelAction"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuPreventDeselect), "set_customCancelAction"), value);
    }

    public static event ILContext.Manipulator orig_OnCancel
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuPreventDeselect), "orig_OnCancel"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuPreventDeselect), "orig_OnCancel"), value);
    }
}