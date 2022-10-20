using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Tk2dTextMeshSetAnchor.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTk2dTextMeshSetAnchor
{
    public static event ILContext.Manipulator _getTextMesh
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetAnchor), "_getTextMesh"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetAnchor), "_getTextMesh"), value);
    }

    public static event ILContext.Manipulator Reset
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetAnchor), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetAnchor), "Reset"),
            value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetAnchor), "OnEnter"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetAnchor), "OnEnter"),
            value);
    }

    public static event ILContext.Manipulator DoSetAnchor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetAnchor), "DoSetAnchor"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetAnchor), "DoSetAnchor"), value);
    }

    public static event ILContext.Manipulator ErrorCheck
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetAnchor), "ErrorCheck"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetAnchor), "ErrorCheck"), value);
    }

    public static event ILContext.Manipulator getTextAnchorFromString
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetAnchor), "getTextAnchorFromString"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dTextMeshSetAnchor), "getTextAnchorFromString"), value);
    }
}