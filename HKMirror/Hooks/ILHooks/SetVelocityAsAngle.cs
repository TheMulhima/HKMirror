using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SetVelocityAsAngle.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSetVelocityAsAngle
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SetVelocityAsAngle), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SetVelocityAsAngle), "Reset"),
            value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SetVelocityAsAngle), "Awake"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SetVelocityAsAngle), "Awake"),
            value);
    }

    public static event ILContext.Manipulator OnPreprocess
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SetVelocityAsAngle), "OnPreprocess"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SetVelocityAsAngle), "OnPreprocess"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SetVelocityAsAngle), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SetVelocityAsAngle), "OnEnter"),
            value);
    }

    public static event ILContext.Manipulator OnFixedUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SetVelocityAsAngle), "OnFixedUpdate"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SetVelocityAsAngle), "OnFixedUpdate"), value);
    }

    public static event ILContext.Manipulator DoSetVelocity
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SetVelocityAsAngle), "DoSetVelocity"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SetVelocityAsAngle), "DoSetVelocity"), value);
    }
}