using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ReflectionHelper,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILReflectionHelper
{
    public static event ILContext.Manipulator PreloadCommonTypes
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "PreloadCommonTypes", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "PreloadCommonTypes", false), value);
    }

    public static event ILContext.Manipulator GetFieldInfo
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "GetFieldInfo", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "GetFieldInfo", false), value);
    }

    public static event ILContext.Manipulator GetPropertyInfo
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "GetPropertyInfo", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "GetPropertyInfo", false), value);
    }

    public static event ILContext.Manipulator GetMethodInfo
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "GetMethodInfo", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "GetMethodInfo", false), value);
    }

    public static event ILContext.Manipulator GetFastReflectionDelegate
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "GetFastReflectionDelegate", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "GetFastReflectionDelegate", false), value);
    }

    public static event ILContext.Manipulator CallMethod
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "CallMethod", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ReflectionHelper), "CallMethod", false), value);
    }
}