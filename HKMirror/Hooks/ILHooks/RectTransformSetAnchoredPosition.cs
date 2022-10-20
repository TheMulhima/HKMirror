using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for RectTransformSetAnchoredPosition.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILRectTransformSetAnchoredPosition
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchoredPosition), "Reset"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchoredPosition), "Reset"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchoredPosition), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchoredPosition), "OnEnter"), value);
    }

    public static event ILContext.Manipulator OnActionUpdate
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchoredPosition), "OnActionUpdate"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchoredPosition), "OnActionUpdate"), value);
    }

    public static event ILContext.Manipulator DoSetAnchoredPosition
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchoredPosition), "DoSetAnchoredPosition"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(RectTransformSetAnchoredPosition), "DoSetAnchoredPosition"), value);
    }
}