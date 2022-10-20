using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TMP_UpdateRegistry.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTMP_UpdateRegistry
{
    public static event ILContext.Manipulator get_instance
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateRegistry), "get_instance", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateRegistry), "get_instance", false), value);
    }

    public static event ILContext.Manipulator RegisterCanvasElementForLayoutRebuild
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateRegistry), "RegisterCanvasElementForLayoutRebuild", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateRegistry), "RegisterCanvasElementForLayoutRebuild", false),
            value);
    }

    public static event ILContext.Manipulator InternalRegisterCanvasElementForLayoutRebuild
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateRegistry), "InternalRegisterCanvasElementForLayoutRebuild"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateRegistry), "InternalRegisterCanvasElementForLayoutRebuild"),
            value);
    }

    public static event ILContext.Manipulator RegisterCanvasElementForGraphicRebuild
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateRegistry), "RegisterCanvasElementForGraphicRebuild", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateRegistry), "RegisterCanvasElementForGraphicRebuild", false),
            value);
    }

    public static event ILContext.Manipulator InternalRegisterCanvasElementForGraphicRebuild
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateRegistry),
                "InternalRegisterCanvasElementForGraphicRebuild"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateRegistry),
                "InternalRegisterCanvasElementForGraphicRebuild"), value);
    }

    public static event ILContext.Manipulator PerformUpdateForCanvasRendererObjects
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateRegistry), "PerformUpdateForCanvasRendererObjects"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateRegistry), "PerformUpdateForCanvasRendererObjects"), value);
    }

    public static event ILContext.Manipulator PerformUpdateForMeshRendererObjects
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateRegistry), "PerformUpdateForMeshRendererObjects"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateRegistry), "PerformUpdateForMeshRendererObjects"), value);
    }

    public static event ILContext.Manipulator UnRegisterCanvasElementForRebuild
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateRegistry), "UnRegisterCanvasElementForRebuild", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateRegistry), "UnRegisterCanvasElementForRebuild", false),
            value);
    }

    public static event ILContext.Manipulator InternalUnRegisterCanvasElementForLayoutRebuild
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateRegistry),
                "InternalUnRegisterCanvasElementForLayoutRebuild"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateRegistry),
                "InternalUnRegisterCanvasElementForLayoutRebuild"), value);
    }

    public static event ILContext.Manipulator InternalUnRegisterCanvasElementForGraphicRebuild
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateRegistry),
                "InternalUnRegisterCanvasElementForGraphicRebuild"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_UpdateRegistry),
                "InternalUnRegisterCanvasElementForGraphicRebuild"), value);
    }
}