using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ScaleTo.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILScaleTo
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "Reset"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "OnEnter"), value);
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "OnUpdate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "OnUpdate"), value);
    }

    public static event ILContext.Manipulator UpdateScaling
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "UpdateScaling"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "UpdateScaling"), value);
    }

    public static event ILContext.Manipulator GetCurved
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "GetCurved", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "GetCurved", false),
            value);
    }

    public static event ILContext.Manipulator Linear
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "Linear", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "Linear", false), value);
    }

    public static event ILContext.Manipulator QuadraticOut
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "QuadraticOut", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "QuadraticOut", false),
            value);
    }

    public static event ILContext.Manipulator SinusoidalOut
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "SinusoidalOut", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ScaleTo), "SinusoidalOut", false),
            value);
    }
}