using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TriggerEvent.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTriggerEvent
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TriggerEvent), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TriggerEvent), "Reset"), value);
    }

    public static event ILContext.Manipulator OnPreprocess
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TriggerEvent), "OnPreprocess"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TriggerEvent), "OnPreprocess"),
            value);
    }

    public static event ILContext.Manipulator StoreCollisionInfo
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TriggerEvent), "StoreCollisionInfo"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TriggerEvent), "StoreCollisionInfo"), value);
    }

    public static event ILContext.Manipulator DoTriggerEnter
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TriggerEvent), "DoTriggerEnter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TriggerEvent), "DoTriggerEnter"),
            value);
    }

    public static event ILContext.Manipulator DoTriggerStay
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TriggerEvent), "DoTriggerStay"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TriggerEvent), "DoTriggerStay"),
            value);
    }

    public static event ILContext.Manipulator DoTriggerExit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TriggerEvent), "DoTriggerExit"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TriggerEvent), "DoTriggerExit"),
            value);
    }

    public static event ILContext.Manipulator ErrorCheck
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TriggerEvent), "ErrorCheck"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TriggerEvent), "ErrorCheck"),
            value);
    }
}