using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Tk2dTextMeshSetPixelPerfect.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTk2dTextMeshSetPixelPerfect
{
    public static event ILContext.Manipulator _getTextMesh
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetPixelPerfect), "_getTextMesh"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetPixelPerfect), "_getTextMesh"), value);
    }

    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetPixelPerfect), "Reset"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetPixelPerfect), "Reset"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetPixelPerfect), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetPixelPerfect), "OnEnter"), value);
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetPixelPerfect), "OnUpdate"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetPixelPerfect), "OnUpdate"), value);
    }

    public static event ILContext.Manipulator DoSetPixelPerfect
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetPixelPerfect), "DoSetPixelPerfect"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetPixelPerfect), "DoSetPixelPerfect"), value);
    }
}