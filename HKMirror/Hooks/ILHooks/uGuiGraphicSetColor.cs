using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for uGuiGraphicSetColor.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILuGuiGraphicSetColor
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(uGuiGraphicSetColor), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(uGuiGraphicSetColor), "Reset"),
            value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(uGuiGraphicSetColor), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(uGuiGraphicSetColor), "OnEnter"),
            value);
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(uGuiGraphicSetColor), "OnUpdate"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(uGuiGraphicSetColor), "OnUpdate"),
            value);
    }

    public static event ILContext.Manipulator DoSetColorValue
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(uGuiGraphicSetColor), "DoSetColorValue"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(uGuiGraphicSetColor), "DoSetColorValue"), value);
    }

    public static event ILContext.Manipulator OnExit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(uGuiGraphicSetColor), "OnExit"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(uGuiGraphicSetColor), "OnExit"),
            value);
    }
}