using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for uGuiInputFieldDeactivate.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILuGuiInputFieldDeactivate
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(uGuiInputFieldDeactivate), "Reset"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(uGuiInputFieldDeactivate), "Reset"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(uGuiInputFieldDeactivate), "OnEnter"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(uGuiInputFieldDeactivate), "OnEnter"), value);
    }

    public static event ILContext.Manipulator DoAction
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(uGuiInputFieldDeactivate), "DoAction"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(uGuiInputFieldDeactivate), "DoAction"), value);
    }

    public static event ILContext.Manipulator OnExit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(uGuiInputFieldDeactivate), "OnExit"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(uGuiInputFieldDeactivate), "OnExit"), value);
    }
}