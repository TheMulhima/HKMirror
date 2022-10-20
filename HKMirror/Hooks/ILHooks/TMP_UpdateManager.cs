using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TMP_UpdateManager.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTMP_UpdateManager
{
    public static event ILContext.Manipulator get_instance
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateManager), "get_instance", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateManager), "get_instance", false), value);
    }

    public static event ILContext.Manipulator RegisterTextElementForLayoutRebuild
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateManager), "RegisterTextElementForLayoutRebuild", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateManager), "RegisterTextElementForLayoutRebuild", false),
            value);
    }

    public static event ILContext.Manipulator InternalRegisterTextElementForLayoutRebuild
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateManager), "InternalRegisterTextElementForLayoutRebuild"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateManager), "InternalRegisterTextElementForLayoutRebuild"),
            value);
    }

    public static event ILContext.Manipulator RegisterTextElementForGraphicRebuild
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateManager), "RegisterTextElementForGraphicRebuild", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateManager), "RegisterTextElementForGraphicRebuild", false),
            value);
    }

    public static event ILContext.Manipulator InternalRegisterTextElementForGraphicRebuild
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateManager), "InternalRegisterTextElementForGraphicRebuild"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateManager), "InternalRegisterTextElementForGraphicRebuild"),
            value);
    }

    public static event ILContext.Manipulator OnCameraPreRender
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateManager), "OnCameraPreRender"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateManager), "OnCameraPreRender"), value);
    }

    public static event ILContext.Manipulator UnRegisterTextElementForRebuild
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateManager), "UnRegisterTextElementForRebuild", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateManager), "UnRegisterTextElementForRebuild", false), value);
    }

    public static event ILContext.Manipulator InternalUnRegisterTextElementForGraphicRebuild
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateManager), "InternalUnRegisterTextElementForGraphicRebuild"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateManager), "InternalUnRegisterTextElementForGraphicRebuild"),
            value);
    }

    public static event ILContext.Manipulator InternalUnRegisterTextElementForLayoutRebuild
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateManager), "InternalUnRegisterTextElementForLayoutRebuild"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateManager), "InternalUnRegisterTextElementForLayoutRebuild"),
            value);
    }
}