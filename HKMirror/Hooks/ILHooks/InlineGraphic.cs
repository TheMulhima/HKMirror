using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for InlineGraphic.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILInlineGraphic
{
    public static event ILContext.Manipulator get_mainTexture
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InlineGraphic), "get_mainTexture"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InlineGraphic), "get_mainTexture"),
            value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InlineGraphic), "Awake"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InlineGraphic), "Awake"), value);
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InlineGraphic), "OnEnable"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InlineGraphic), "OnEnable"), value);
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InlineGraphic), "OnDisable"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InlineGraphic), "OnDisable"),
            value);
    }

    public static event ILContext.Manipulator OnTransformParentChanged
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphic), "OnTransformParentChanged"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphic), "OnTransformParentChanged"), value);
    }

    public static event ILContext.Manipulator OnRectTransformDimensionsChange
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphic), "OnRectTransformDimensionsChange"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphic), "OnRectTransformDimensionsChange"), value);
    }

    public static event ILContext.Manipulator UpdateMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InlineGraphic), "UpdateMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InlineGraphic), "UpdateMaterial"),
            value);
    }

    public static event ILContext.Manipulator UpdateGeometry
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InlineGraphic), "UpdateGeometry"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InlineGraphic), "UpdateGeometry"),
            value);
    }
}