using MonoMod.RuntimeDetour.HookGen;
using Touch = InControl.Touch;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Touch.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTouch
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Touch), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Touch), "Reset"), value);
    }

    public static event ILContext.Manipulator get_normalizedPressure
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Touch), "get_normalizedPressure"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Touch), "get_normalizedPressure"),
            value);
    }

    public static event ILContext.Manipulator get_NormalizedPressure
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Touch), "get_NormalizedPressure"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Touch), "get_NormalizedPressure"),
            value);
    }

    public static event ILContext.Manipulator get_IsMouse
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Touch), "get_IsMouse"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Touch), "get_IsMouse"), value);
    }

    public static event ILContext.Manipulator SetWithTouchData
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Touch), "SetWithTouchData"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Touch), "SetWithTouchData"), value);
    }

    public static event ILContext.Manipulator SetWithMouseData
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Touch), "SetWithMouseData"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Touch), "SetWithMouseData"), value);
    }
}