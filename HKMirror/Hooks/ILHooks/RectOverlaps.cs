using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for RectOverlaps.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILRectOverlaps
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(RectOverlaps), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(RectOverlaps), "Reset"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(RectOverlaps), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(RectOverlaps), "OnEnter"), value);
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(RectOverlaps), "OnUpdate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(RectOverlaps), "OnUpdate"), value);
    }

    public static event ILContext.Manipulator DoRectOverlap
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(RectOverlaps), "DoRectOverlap"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(RectOverlaps), "DoRectOverlap"),
            value);
    }

    public static event ILContext.Manipulator Intersect
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(RectOverlaps), "Intersect", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(RectOverlaps), "Intersect", false),
            value);
    }

    public static event ILContext.Manipulator FlipNegative
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(RectOverlaps), "FlipNegative", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(RectOverlaps), "FlipNegative", false), value);
    }
}