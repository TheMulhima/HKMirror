using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for uGuiToggleOnClickEvent.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILuGuiToggleOnClickEvent
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(uGuiToggleOnClickEvent), "Reset"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(uGuiToggleOnClickEvent), "Reset"),
            value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(uGuiToggleOnClickEvent), "OnEnter"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(uGuiToggleOnClickEvent), "OnEnter"), value);
    }

    public static event ILContext.Manipulator OnExit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(uGuiToggleOnClickEvent), "OnExit"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(uGuiToggleOnClickEvent), "OnExit"),
            value);
    }

    public static event ILContext.Manipulator DoOnValueChanged
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(uGuiToggleOnClickEvent), "DoOnValueChanged"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(uGuiToggleOnClickEvent), "DoOnValueChanged"), value);
    }
}