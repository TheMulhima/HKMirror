using MonoMod.RuntimeDetour.HookGen;
using UnityEngine.UI;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ClearSaveButton.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILClearSaveButton
{
    public static event ILContext.Manipulator OnSubmit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ClearSaveButton), "OnSubmit"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ClearSaveButton), "OnSubmit"),
            value);
    }

    public static event ILContext.Manipulator OnPointerClick
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ClearSaveButton), "OnPointerClick"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ClearSaveButton), "OnPointerClick"), value);
    }

    public static event ILContext.Manipulator OnSelect
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ClearSaveButton), "OnSelect"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ClearSaveButton), "OnSelect"),
            value);
    }

    public static event ILContext.Manipulator SelectAfterFrame
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ClearSaveButton), "SelectAfterFrame").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ClearSaveButton), "SelectAfterFrame").GetStateMachineTarget(), value);
    }
}