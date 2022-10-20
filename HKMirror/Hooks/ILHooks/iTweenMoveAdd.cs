using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for iTweenMoveAdd.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILiTweenMoveAdd
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(iTweenMoveAdd), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(iTweenMoveAdd), "Reset"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(iTweenMoveAdd), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(iTweenMoveAdd), "OnEnter"), value);
    }

    public static event ILContext.Manipulator OnExit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(iTweenMoveAdd), "OnExit"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(iTweenMoveAdd), "OnExit"), value);
    }

    public static event ILContext.Manipulator DoiTween
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(iTweenMoveAdd), "DoiTween"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(iTweenMoveAdd), "DoiTween"), value);
    }
}