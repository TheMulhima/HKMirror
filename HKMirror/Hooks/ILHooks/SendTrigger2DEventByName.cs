using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SendTrigger2DEventByName.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSendTrigger2DEventByName
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEventByName), "Reset"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEventByName), "Reset"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEventByName), "OnEnter"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEventByName), "OnEnter"), value);
    }

    public static event ILContext.Manipulator OnExit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEventByName), "OnExit"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEventByName), "OnExit"), value);
    }

    public static event ILContext.Manipulator StoreCollisionInfo
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEventByName), "StoreCollisionInfo"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEventByName), "StoreCollisionInfo"), value);
    }

    public static event ILContext.Manipulator DoTriggerEnter2D
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEventByName), "DoTriggerEnter2D"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEventByName), "DoTriggerEnter2D"), value);
    }

    public static event ILContext.Manipulator DoTriggerStay2D
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEventByName), "DoTriggerStay2D"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEventByName), "DoTriggerStay2D"), value);
    }

    public static event ILContext.Manipulator DoTriggerExit2D
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEventByName), "DoTriggerExit2D"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEventByName), "DoTriggerExit2D"), value);
    }

    public static event ILContext.Manipulator ErrorCheck
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEventByName), "ErrorCheck"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SendTrigger2DEventByName), "ErrorCheck"), value);
    }
}