using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for QuaternionLowPassFilter.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILQuaternionLowPassFilter
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(QuaternionLowPassFilter), "Reset"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(QuaternionLowPassFilter), "Reset"),
            value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(QuaternionLowPassFilter), "OnEnter"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(QuaternionLowPassFilter), "OnEnter"), value);
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(QuaternionLowPassFilter), "OnUpdate"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(QuaternionLowPassFilter), "OnUpdate"), value);
    }

    public static event ILContext.Manipulator OnLateUpdate
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(QuaternionLowPassFilter), "OnLateUpdate"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(QuaternionLowPassFilter), "OnLateUpdate"), value);
    }

    public static event ILContext.Manipulator OnFixedUpdate
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(QuaternionLowPassFilter), "OnFixedUpdate"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(QuaternionLowPassFilter), "OnFixedUpdate"), value);
    }

    public static event ILContext.Manipulator DoQuatLowPassFilter
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(QuaternionLowPassFilter), "DoQuatLowPassFilter"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(QuaternionLowPassFilter), "DoQuatLowPassFilter"), value);
    }
}