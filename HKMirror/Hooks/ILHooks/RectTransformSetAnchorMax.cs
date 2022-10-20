using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for RectTransformSetAnchorMax.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILRectTransformSetAnchorMax
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchorMax), "Reset"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchorMax), "Reset"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchorMax), "OnEnter"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchorMax), "OnEnter"), value);
    }

    public static event ILContext.Manipulator OnActionUpdate
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchorMax), "OnActionUpdate"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchorMax), "OnActionUpdate"), value);
    }

    public static event ILContext.Manipulator DoSetAnchorMax
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchorMax), "DoSetAnchorMax"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchorMax), "DoSetAnchorMax"), value);
    }
}