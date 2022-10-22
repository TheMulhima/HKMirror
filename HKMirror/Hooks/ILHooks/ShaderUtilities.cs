using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ShaderUtilities,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILShaderUtilities
{
    public static event ILContext.Manipulator GetShaderPropertyIDs
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ShaderUtilities), "GetShaderPropertyIDs", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ShaderUtilities), "GetShaderPropertyIDs", false), value);
    }

    public static event ILContext.Manipulator UpdateShaderRatios
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ShaderUtilities), "UpdateShaderRatios", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ShaderUtilities), "UpdateShaderRatios", false), value);
    }

    public static event ILContext.Manipulator GetFontExtent
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ShaderUtilities), "GetFontExtent", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ShaderUtilities), "GetFontExtent", false), value);
    }

    public static event ILContext.Manipulator IsMaskingEnabled
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ShaderUtilities), "IsMaskingEnabled", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ShaderUtilities), "IsMaskingEnabled", false), value);
    }

    public static event ILContext.Manipulator GetPadding_Material_bool_bool
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ShaderUtilities), "GetPadding", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ShaderUtilities), "GetPadding", false), value);
    }

    public static event ILContext.Manipulator GetPadding_Array_bool_bool
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ShaderUtilities), "GetPadding", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ShaderUtilities), "GetPadding", false), value);
    }
}