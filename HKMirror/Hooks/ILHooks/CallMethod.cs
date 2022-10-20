using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CallMethod.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCallMethod
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CallMethod), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(CallMethod), "Reset"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CallMethod), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(CallMethod), "OnEnter"), value);
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CallMethod), "OnUpdate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(CallMethod), "OnUpdate"), value);
    }

    public static event ILContext.Manipulator DoMethodCall
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CallMethod), "DoMethodCall"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(CallMethod), "DoMethodCall"),
            value);
    }

    public static event ILContext.Manipulator NeedToUpdateCache
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CallMethod), "NeedToUpdateCache"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(CallMethod), "NeedToUpdateCache"),
            value);
    }

    public static event ILContext.Manipulator ClearCache
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CallMethod), "ClearCache"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(CallMethod), "ClearCache"), value);
    }

    public static event ILContext.Manipulator DoCache
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CallMethod), "DoCache"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(CallMethod), "DoCache"), value);
    }

    public static event ILContext.Manipulator ErrorCheck
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CallMethod), "ErrorCheck"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(CallMethod), "ErrorCheck"), value);
    }
}