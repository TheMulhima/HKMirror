using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Trigger2dEvent.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTrigger2dEvent
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Trigger2dEvent), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Trigger2dEvent), "Reset"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Trigger2dEvent), "OnEnter"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Trigger2dEvent), "OnEnter"), value);
    }

    public static event ILContext.Manipulator OnExit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Trigger2dEvent), "OnExit"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Trigger2dEvent), "OnExit"), value);
    }

    public static event ILContext.Manipulator StoreCollisionInfo
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Trigger2dEvent), "StoreCollisionInfo"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Trigger2dEvent), "StoreCollisionInfo"), value);
    }

    public static event ILContext.Manipulator DoTriggerEnter2D
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Trigger2dEvent), "DoTriggerEnter2D"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Trigger2dEvent), "DoTriggerEnter2D"), value);
    }

    public static event ILContext.Manipulator DoTriggerStay2D
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Trigger2dEvent), "DoTriggerStay2D"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Trigger2dEvent), "DoTriggerStay2D"), value);
    }

    public static event ILContext.Manipulator DoTriggerExit2D
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Trigger2dEvent), "DoTriggerExit2D"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Trigger2dEvent), "DoTriggerExit2D"), value);
    }

    public static event ILContext.Manipulator ErrorCheck
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Trigger2dEvent), "ErrorCheck"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Trigger2dEvent), "ErrorCheck"),
            value);
    }
}