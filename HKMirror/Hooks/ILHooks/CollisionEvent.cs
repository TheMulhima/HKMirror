using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CollisionEvent.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCollisionEvent
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CollisionEvent), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(CollisionEvent), "Reset"), value);
    }

    public static event ILContext.Manipulator OnPreprocess
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CollisionEvent), "OnPreprocess"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(CollisionEvent), "OnPreprocess"),
            value);
    }

    public static event ILContext.Manipulator StoreCollisionInfo
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CollisionEvent), "StoreCollisionInfo"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CollisionEvent), "StoreCollisionInfo"), value);
    }

    public static event ILContext.Manipulator DoCollisionEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CollisionEvent), "DoCollisionEnter"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CollisionEvent), "DoCollisionEnter"), value);
    }

    public static event ILContext.Manipulator DoCollisionStay
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CollisionEvent), "DoCollisionStay"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CollisionEvent), "DoCollisionStay"), value);
    }

    public static event ILContext.Manipulator DoCollisionExit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CollisionEvent), "DoCollisionExit"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CollisionEvent), "DoCollisionExit"), value);
    }

    public static event ILContext.Manipulator DoControllerColliderHit
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CollisionEvent), "DoControllerColliderHit"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CollisionEvent), "DoControllerColliderHit"), value);
    }

    public static event ILContext.Manipulator DoParticleCollision
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CollisionEvent), "DoParticleCollision"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CollisionEvent), "DoParticleCollision"), value);
    }

    public static event ILContext.Manipulator ErrorCheck
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CollisionEvent), "ErrorCheck"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(CollisionEvent), "ErrorCheck"),
            value);
    }
}