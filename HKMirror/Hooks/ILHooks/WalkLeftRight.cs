using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for WalkLeftRight.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILWalkLeftRight
{
    public static event ILContext.Manipulator get_Direction
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "get_Direction"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "get_Direction"),
            value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "OnEnter"), value);
    }

    public static event ILContext.Manipulator OnExit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "OnExit"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "OnExit"), value);
    }

    public static event ILContext.Manipulator UpdateIfTargetChanged
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "UpdateIfTargetChanged"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "UpdateIfTargetChanged"), value);
    }

    public static event ILContext.Manipulator Walk
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "Walk").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "Walk").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Turn
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "Turn").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "Turn").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator CheckWall
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "CheckWall"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "CheckWall"),
            value);
    }

    public static event ILContext.Manipulator CheckFloor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "CheckFloor"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "CheckFloor"),
            value);
    }

    public static event ILContext.Manipulator CheckIsGrounded
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "CheckIsGrounded"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "CheckIsGrounded"),
            value);
    }

    public static event ILContext.Manipulator SetupStartingDirection
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "SetupStartingDirection"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(WalkLeftRight), "SetupStartingDirection"), value);
    }
}