using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TMP_TextInfo.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTMP_TextInfo
{
    public static event ILContext.Manipulator Clear
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_TextInfo), "Clear"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_TextInfo), "Clear"), value);
    }

    public static event ILContext.Manipulator ClearMeshInfo
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_TextInfo), "ClearMeshInfo"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_TextInfo), "ClearMeshInfo"),
            value);
    }

    public static event ILContext.Manipulator ClearAllMeshInfo
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_TextInfo), "ClearAllMeshInfo"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_TextInfo), "ClearAllMeshInfo"),
            value);
    }

    public static event ILContext.Manipulator ResetVertexLayout
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_TextInfo), "ResetVertexLayout"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextInfo), "ResetVertexLayout"), value);
    }

    public static event ILContext.Manipulator ClearUnusedVertices
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_TextInfo), "ClearUnusedVertices"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextInfo), "ClearUnusedVertices"), value);
    }

    public static event ILContext.Manipulator ClearLineInfo
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TMP_TextInfo), "ClearLineInfo"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TMP_TextInfo), "ClearLineInfo"),
            value);
    }

    public static event ILContext.Manipulator CopyMeshInfoVertexData
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextInfo), "CopyMeshInfoVertexData"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TMP_TextInfo), "CopyMeshInfoVertexData"), value);
    }
}