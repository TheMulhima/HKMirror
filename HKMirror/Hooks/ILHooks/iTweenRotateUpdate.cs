using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for iTweenRotateUpdate.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILiTweenRotateUpdate
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(iTweenRotateUpdate), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(iTweenRotateUpdate), "Reset"),
            value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(iTweenRotateUpdate), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(iTweenRotateUpdate), "OnEnter"),
            value);
    }

    public static event ILContext.Manipulator OnExit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(iTweenRotateUpdate), "OnExit"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(iTweenRotateUpdate), "OnExit"),
            value);
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(iTweenRotateUpdate), "OnUpdate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(iTweenRotateUpdate), "OnUpdate"),
            value);
    }

    public static event ILContext.Manipulator DoiTween
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(iTweenRotateUpdate), "DoiTween"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(iTweenRotateUpdate), "DoiTween"),
            value);
    }
}