using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for RectTransformSetOffsetMin.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILRectTransformSetOffsetMin
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(RectTransformSetOffsetMin), "Reset"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(RectTransformSetOffsetMin), "Reset"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(RectTransformSetOffsetMin), "OnEnter"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(RectTransformSetOffsetMin), "OnEnter"), value);
    }

    public static event ILContext.Manipulator OnActionUpdate
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(RectTransformSetOffsetMin), "OnActionUpdate"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(RectTransformSetOffsetMin), "OnActionUpdate"), value);
    }

    public static event ILContext.Manipulator DoSetOffsetMin
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(RectTransformSetOffsetMin), "DoSetOffsetMin"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(RectTransformSetOffsetMin), "DoSetOffsetMin"), value);
    }
}