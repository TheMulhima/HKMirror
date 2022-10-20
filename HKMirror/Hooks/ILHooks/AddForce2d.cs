using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for AddForce2d.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILAddForce2d
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(AddForce2d), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(AddForce2d), "Reset"), value);
    }

    public static event ILContext.Manipulator OnPreprocess
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(AddForce2d), "OnPreprocess"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(AddForce2d), "OnPreprocess"),
            value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(AddForce2d), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(AddForce2d), "OnEnter"), value);
    }

    public static event ILContext.Manipulator OnFixedUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(AddForce2d), "OnFixedUpdate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(AddForce2d), "OnFixedUpdate"),
            value);
    }

    public static event ILContext.Manipulator DoAddForce
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(AddForce2d), "DoAddForce"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(AddForce2d), "DoAddForce"), value);
    }
}