using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Collision2dEvent.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCollision2dEvent
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Collision2dEvent), "Reset"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Collision2dEvent), "Reset"), value);
    }

    public static event ILContext.Manipulator OnPreprocess
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Collision2dEvent), "OnPreprocess"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Collision2dEvent), "OnPreprocess"),
            value);
    }

    public static event ILContext.Manipulator StoreCollisionInfo
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Collision2dEvent), "StoreCollisionInfo"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Collision2dEvent), "StoreCollisionInfo"), value);
    }

    public static event ILContext.Manipulator DoCollisionEnter2D
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Collision2dEvent), "DoCollisionEnter2D"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Collision2dEvent), "DoCollisionEnter2D"), value);
    }

    public static event ILContext.Manipulator DoCollisionStay2D
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Collision2dEvent), "DoCollisionStay2D"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Collision2dEvent), "DoCollisionStay2D"), value);
    }

    public static event ILContext.Manipulator DoCollisionExit2D
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Collision2dEvent), "DoCollisionExit2D"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Collision2dEvent), "DoCollisionExit2D"), value);
    }

    public static event ILContext.Manipulator DoParticleCollision
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Collision2dEvent), "DoParticleCollision"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Collision2dEvent), "DoParticleCollision"), value);
    }

    public static event ILContext.Manipulator ErrorCheck
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Collision2dEvent), "ErrorCheck"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Collision2dEvent), "ErrorCheck"),
            value);
    }
}