using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ProjectileSquash.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILProjectileSquash
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ProjectileSquash), "Reset"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ProjectileSquash), "Reset"), value);
    }

    public static event ILContext.Manipulator OnPreprocess
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ProjectileSquash), "OnPreprocess"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ProjectileSquash), "OnPreprocess"),
            value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ProjectileSquash), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ProjectileSquash), "OnEnter"),
            value);
    }

    public static event ILContext.Manipulator OnFixedUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ProjectileSquash), "OnFixedUpdate"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ProjectileSquash), "OnFixedUpdate"), value);
    }

    public static event ILContext.Manipulator DoStretch
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ProjectileSquash), "DoStretch"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ProjectileSquash), "DoStretch"),
            value);
    }
}