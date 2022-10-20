using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MousePick2dEvent.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMousePick2dEvent
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MousePick2dEvent), "Reset"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MousePick2dEvent), "Reset"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MousePick2dEvent), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MousePick2dEvent), "OnEnter"),
            value);
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MousePick2dEvent), "OnUpdate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MousePick2dEvent), "OnUpdate"),
            value);
    }

    public static event ILContext.Manipulator DoMousePickEvent
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MousePick2dEvent), "DoMousePickEvent"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MousePick2dEvent), "DoMousePickEvent"), value);
    }

    public static event ILContext.Manipulator DoRaycast
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MousePick2dEvent), "DoRaycast"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MousePick2dEvent), "DoRaycast"),
            value);
    }
}