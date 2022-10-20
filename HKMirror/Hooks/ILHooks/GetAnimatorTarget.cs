using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GetAnimatorTarget.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGetAnimatorTarget
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GetAnimatorTarget), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GetAnimatorTarget), "Reset"),
            value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GetAnimatorTarget), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GetAnimatorTarget), "OnEnter"),
            value);
    }

    public static event ILContext.Manipulator OnActionUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GetAnimatorTarget), "OnActionUpdate"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GetAnimatorTarget), "OnActionUpdate"), value);
    }

    public static event ILContext.Manipulator DoGetTarget
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GetAnimatorTarget), "DoGetTarget"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GetAnimatorTarget), "DoGetTarget"),
            value);
    }
}