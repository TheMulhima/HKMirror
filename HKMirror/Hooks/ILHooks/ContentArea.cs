using Modding.Menu;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ContentArea.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILContentArea
{
    public static event ILContext.Manipulator get_ContentObject
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ContentArea), "get_ContentObject"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ContentArea), "get_ContentObject"),
            value);
    }

    public static event ILContext.Manipulator set_ContentObject
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ContentArea), "set_ContentObject"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ContentArea), "set_ContentObject"),
            value);
    }

    public static event ILContext.Manipulator get_Layout
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ContentArea), "get_Layout"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ContentArea), "get_Layout"), value);
    }

    public static event ILContext.Manipulator set_Layout
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ContentArea), "set_Layout"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ContentArea), "set_Layout"), value);
    }

    public static event ILContext.Manipulator get_NavGraph
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ContentArea), "get_NavGraph"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ContentArea), "get_NavGraph"),
            value);
    }

    public static event ILContext.Manipulator set_NavGraph
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ContentArea), "set_NavGraph"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ContentArea), "set_NavGraph"),
            value);
    }
}