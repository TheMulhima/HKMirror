using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GetAngleToTarget2D.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGetAngleToTarget2D
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GetAngleToTarget2D), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GetAngleToTarget2D), "Reset"),
            value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GetAngleToTarget2D), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GetAngleToTarget2D), "OnEnter"),
            value);
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GetAngleToTarget2D), "OnUpdate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GetAngleToTarget2D), "OnUpdate"),
            value);
    }

    public static event ILContext.Manipulator DoGetAngle
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GetAngleToTarget2D), "DoGetAngle"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GetAngleToTarget2D), "DoGetAngle"),
            value);
    }
}