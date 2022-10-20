using MonoMod.RuntimeDetour.HookGen;
using UnityEngine.UI;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ControllerProfileButton.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILControllerProfileButton
{
    public static event ILContext.Manipulator OnSelect
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButton), "OnSelect"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButton), "OnSelect"), value);
    }

    public static event ILContext.Manipulator OnDeselect
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButton), "OnDeselect"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButton), "OnDeselect"), value);
    }

    public static event ILContext.Manipulator OnSubmit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButton), "OnSubmit"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButton), "OnSubmit"), value);
    }

    public static event ILContext.Manipulator OnPointerClick
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButton), "OnPointerClick"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButton), "OnPointerClick"), value);
    }

    public static event ILContext.Manipulator ValidateDeselect
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButton), "ValidateDeselect").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButton), "ValidateDeselect").GetStateMachineTarget(),
            value);
    }
}