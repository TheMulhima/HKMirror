using MonoMod.RuntimeDetour.HookGen;
using ToJ;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Mask.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMask
{
    public static event ILContext.Manipulator get_invertAxis
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Mask), "get_invertAxis"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Mask), "get_invertAxis"), value);
    }

    public static event ILContext.Manipulator set_invertAxis
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Mask), "set_invertAxis"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Mask), "set_invertAxis"), value);
    }

    public static event ILContext.Manipulator get_clampAlphaHorizontally
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Mask), "get_clampAlphaHorizontally"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Mask), "get_clampAlphaHorizontally"), value);
    }

    public static event ILContext.Manipulator set_clampAlphaHorizontally
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Mask), "set_clampAlphaHorizontally"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Mask), "set_clampAlphaHorizontally"), value);
    }

    public static event ILContext.Manipulator get_clampAlphaVertically
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Mask), "get_clampAlphaVertically"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Mask), "get_clampAlphaVertically"),
            value);
    }

    public static event ILContext.Manipulator set_clampAlphaVertically
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Mask), "set_clampAlphaVertically"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Mask), "set_clampAlphaVertically"),
            value);
    }

    public static event ILContext.Manipulator get_clampingBorder
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Mask), "get_clampingBorder"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Mask), "get_clampingBorder"),
            value);
    }

    public static event ILContext.Manipulator set_clampingBorder
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Mask), "set_clampingBorder"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Mask), "set_clampingBorder"),
            value);
    }

    public static event ILContext.Manipulator get_useMaskAlphaChannel
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Mask), "get_useMaskAlphaChannel"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Mask), "get_useMaskAlphaChannel"),
            value);
    }

    public static event ILContext.Manipulator set_useMaskAlphaChannel
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Mask), "set_useMaskAlphaChannel"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Mask), "set_useMaskAlphaChannel"),
            value);
    }

    public static event ILContext.Manipulator Start
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Mask), "Start"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Mask), "Start"), value);
    }

    public static event ILContext.Manipulator Update
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Mask), "Update"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Mask), "Update"), value);
    }

    public static event ILContext.Manipulator RotateVector
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Mask), "RotateVector"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Mask), "RotateVector"), value);
    }

    public static event ILContext.Manipulator SetMaskFloatValueInMaterials
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Mask), "SetMaskFloatValueInMaterials"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Mask), "SetMaskFloatValueInMaterials"), value);
    }

    public static event ILContext.Manipulator SetMaskBoolValueInMaterials
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Mask), "SetMaskBoolValueInMaterials"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Mask), "SetMaskBoolValueInMaterials"), value);
    }

    public static event ILContext.Manipulator SetMaskBoolValueInMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Mask), "SetMaskBoolValueInMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Mask), "SetMaskBoolValueInMaterial"), value);
    }

    public static event ILContext.Manipulator CreateAndAssignQuad
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Mask), "CreateAndAssignQuad"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Mask), "CreateAndAssignQuad"),
            value);
    }

    public static event ILContext.Manipulator SetMaskRendererActive
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Mask), "SetMaskRendererActive"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Mask), "SetMaskRendererActive"),
            value);
    }
}