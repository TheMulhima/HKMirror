using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GetFsmVariable.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGetFsmVariable
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GetFsmVariable), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GetFsmVariable), "Reset"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GetFsmVariable), "OnEnter"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GetFsmVariable), "OnEnter"), value);
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GetFsmVariable), "OnUpdate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GetFsmVariable), "OnUpdate"),
            value);
    }

    public static event ILContext.Manipulator InitFsmVar
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GetFsmVariable), "InitFsmVar"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GetFsmVariable), "InitFsmVar"),
            value);
    }

    public static event ILContext.Manipulator DoGetFsmVariable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GetFsmVariable), "DoGetFsmVariable"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GetFsmVariable), "DoGetFsmVariable"), value);
    }
}