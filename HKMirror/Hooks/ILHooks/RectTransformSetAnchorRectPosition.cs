using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for RectTransformSetAnchorRectPosition.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILRectTransformSetAnchorRectPosition
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchorRectPosition), "Reset"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchorRectPosition), "Reset"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchorRectPosition), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchorRectPosition), "OnEnter"), value);
    }

    public static event ILContext.Manipulator OnActionUpdate
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchorRectPosition), "OnActionUpdate"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchorRectPosition), "OnActionUpdate"), value);
    }

    public static event ILContext.Manipulator DoSetAnchor
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchorRectPosition), "DoSetAnchor"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchorRectPosition), "DoSetAnchor"), value);
    }
}