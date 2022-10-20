using MonoMod.RuntimeDetour.HookGen;
using UnityEngine.UI;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ControllerProfileButtons.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILControllerProfileButtons
{
    public static event ILContext.Manipulator SelectItem
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButtons), "SelectItem"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ControllerProfileButtons), "SelectItem"), value);
    }
}