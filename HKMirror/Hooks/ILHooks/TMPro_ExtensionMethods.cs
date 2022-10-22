using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TMPro_ExtensionMethods,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTMPro_ExtensionMethods
{
    public static event ILContext.Manipulator Compare_Color32_Color32
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Compare", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Compare", false), value);
    }

    public static event ILContext.Manipulator CompareRGB_Color32_Color32
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "CompareRGB", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "CompareRGB", false), value);
    }

    public static event ILContext.Manipulator Compare_Color_Color
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Compare", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Compare", false), value);
    }

    public static event ILContext.Manipulator CompareRGB_Color_Color
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "CompareRGB", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "CompareRGB", false), value);
    }

    public static event ILContext.Manipulator Multiply
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Multiply", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Multiply", false), value);
    }

    public static event ILContext.Manipulator Tint_Color32_Color32
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Tint", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Tint", false), value);
    }

    public static event ILContext.Manipulator Tint_Color32_float
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Tint", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Tint", false), value);
    }

    public static event ILContext.Manipulator Compare_Vector3_Vector3_int
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Compare", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Compare", false), value);
    }

    public static event ILContext.Manipulator Compare_Quaternion_Quaternion_int
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Compare", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMPro_ExtensionMethods), "Compare", false), value);
    }
}