using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SendTrigger2DEvent.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSendTrigger2DEvent
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEvent), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEvent), "Reset"),
            value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEvent), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEvent), "OnEnter"),
            value);
    }

    public static event ILContext.Manipulator OnExit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEvent), "OnExit"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEvent), "OnExit"),
            value);
    }

    public static event ILContext.Manipulator StoreCollisionInfo
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEvent), "StoreCollisionInfo"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEvent), "StoreCollisionInfo"), value);
    }

    public static event ILContext.Manipulator DoTriggerEnter2D
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEvent), "DoTriggerEnter2D"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEvent), "DoTriggerEnter2D"), value);
    }

    public static event ILContext.Manipulator DoTriggerStay2D
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEvent), "DoTriggerStay2D"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEvent), "DoTriggerStay2D"), value);
    }

    public static event ILContext.Manipulator DoTriggerExit2D
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEvent), "DoTriggerExit2D"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEvent), "DoTriggerExit2D"), value);
    }

    public static event ILContext.Manipulator ErrorCheck
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEvent), "ErrorCheck"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEvent), "ErrorCheck"),
            value);
    }
}