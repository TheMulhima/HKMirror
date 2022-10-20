using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MoveTowards.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMoveTowards
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MoveTowards), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MoveTowards), "Reset"), value);
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MoveTowards), "OnUpdate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MoveTowards), "OnUpdate"), value);
    }

    public static event ILContext.Manipulator DoMoveTowards
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MoveTowards), "DoMoveTowards"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MoveTowards), "DoMoveTowards"),
            value);
    }

    public static event ILContext.Manipulator UpdateTargetPos
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MoveTowards), "UpdateTargetPos"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MoveTowards), "UpdateTargetPos"),
            value);
    }

    public static event ILContext.Manipulator GetTargetPos
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MoveTowards), "GetTargetPos"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MoveTowards), "GetTargetPos"),
            value);
    }

    public static event ILContext.Manipulator GetTargetPosWithVertical
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MoveTowards), "GetTargetPosWithVertical"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MoveTowards), "GetTargetPosWithVertical"), value);
    }
}