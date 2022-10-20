using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for QuaternionAngleAxis.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILQuaternionAngleAxis
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(QuaternionAngleAxis), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(QuaternionAngleAxis), "Reset"),
            value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(QuaternionAngleAxis), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(QuaternionAngleAxis), "OnEnter"),
            value);
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(QuaternionAngleAxis), "OnUpdate"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(QuaternionAngleAxis), "OnUpdate"),
            value);
    }

    public static event ILContext.Manipulator OnLateUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(QuaternionAngleAxis), "OnLateUpdate"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(QuaternionAngleAxis), "OnLateUpdate"), value);
    }

    public static event ILContext.Manipulator OnFixedUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(QuaternionAngleAxis), "OnFixedUpdate"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(QuaternionAngleAxis), "OnFixedUpdate"), value);
    }

    public static event ILContext.Manipulator DoQuatAngleAxis
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(QuaternionAngleAxis), "DoQuatAngleAxis"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(QuaternionAngleAxis), "DoQuatAngleAxis"), value);
    }
}