using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for LookAt.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILLookAt
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(LookAt), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(LookAt), "Reset"), value);
    }

    public static event ILContext.Manipulator OnPreprocess
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(LookAt), "OnPreprocess"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(LookAt), "OnPreprocess"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(LookAt), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(LookAt), "OnEnter"), value);
    }

    public static event ILContext.Manipulator OnLateUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(LookAt), "OnLateUpdate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(LookAt), "OnLateUpdate"), value);
    }

    public static event ILContext.Manipulator DoLookAt
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(LookAt), "DoLookAt"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(LookAt), "DoLookAt"), value);
    }

    public static event ILContext.Manipulator UpdateLookAtPosition
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(LookAt), "UpdateLookAtPosition"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(LookAt), "UpdateLookAtPosition"),
            value);
    }

    public static event ILContext.Manipulator GetLookAtPosition
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(LookAt), "GetLookAtPosition"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(LookAt), "GetLookAtPosition"),
            value);
    }

    public static event ILContext.Manipulator GetLookAtPositionWithVertical
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(LookAt), "GetLookAtPositionWithVertical"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(LookAt), "GetLookAtPositionWithVertical"), value);
    }
}