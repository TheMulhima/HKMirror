using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ReceivedDamage.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILReceivedDamage
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ReceivedDamage), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ReceivedDamage), "Reset"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ReceivedDamage), "OnEnter"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ReceivedDamage), "OnEnter"), value);
    }

    public static event ILContext.Manipulator OnExit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ReceivedDamage), "OnExit"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ReceivedDamage), "OnExit"), value);
    }

    public static event ILContext.Manipulator DoCollisionEnter2D
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ReceivedDamage), "DoCollisionEnter2D"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ReceivedDamage), "DoCollisionEnter2D"), value);
    }

    public static event ILContext.Manipulator DoTriggerEnter2D
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ReceivedDamage), "DoTriggerEnter2D"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ReceivedDamage), "DoTriggerEnter2D"), value);
    }

    public static event ILContext.Manipulator DoTriggerStay2D
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ReceivedDamage), "DoTriggerStay2D"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ReceivedDamage), "DoTriggerStay2D"), value);
    }

    public static event ILContext.Manipulator StoreCollisionInfo
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ReceivedDamage), "StoreCollisionInfo"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ReceivedDamage), "StoreCollisionInfo"), value);
    }

    public static event ILContext.Manipulator StoreTriggerInfo
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ReceivedDamage), "StoreTriggerInfo"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ReceivedDamage), "StoreTriggerInfo"), value);
    }

    public static event ILContext.Manipulator StoreIfDamagingObject
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ReceivedDamage), "StoreIfDamagingObject"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ReceivedDamage), "StoreIfDamagingObject"), value);
    }

    public static event ILContext.Manipulator ErrorCheck
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ReceivedDamage), "ErrorCheck"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ReceivedDamage), "ErrorCheck"),
            value);
    }
}