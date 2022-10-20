using MonoMod.RuntimeDetour.HookGen;
using UnityEngine.UI;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MenuStyleSetting.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMenuStyleSetting
{
    public static event ILContext.Manipulator OnEnable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuStyleSetting), "OnEnable"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuStyleSetting), "OnEnable"),
            value);
    }

    public static event ILContext.Manipulator OnMove
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuStyleSetting), "OnMove"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuStyleSetting), "OnMove"),
            value);
    }

    public static event ILContext.Manipulator OnPointerClick
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuStyleSetting), "OnPointerClick"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuStyleSetting), "OnPointerClick"), value);
    }

    public static event ILContext.Manipulator UpdateStyle
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuStyleSetting), "UpdateStyle"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuStyleSetting), "UpdateStyle"),
            value);
    }
}