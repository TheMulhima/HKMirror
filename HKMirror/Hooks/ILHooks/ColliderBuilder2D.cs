using MonoMod.RuntimeDetour.HookGen;
using tk2dRuntime.TileMap;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ColliderBuilder2D,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILColliderBuilder2D
{
    public static event ILContext.Manipulator Build
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder2D), "Build", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder2D), "Build", false), value);
    }

    public static event ILContext.Manipulator BuildForChunk
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder2D), "BuildForChunk", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder2D), "BuildForChunk", false), value);
    }

    public static event ILContext.Manipulator BuildLocalMeshForChunk
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder2D), "BuildLocalMeshForChunk", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder2D), "BuildLocalMeshForChunk", false), value);
    }

    public static event ILContext.Manipulator CompareWeldVertices
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder2D), "CompareWeldVertices", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder2D), "CompareWeldVertices", false), value);
    }

    public static event ILContext.Manipulator WeldVertices
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder2D), "WeldVertices", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder2D), "WeldVertices", false), value);
    }

    public static event ILContext.Manipulator CompareDuplicateFaces
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder2D), "CompareDuplicateFaces", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder2D), "CompareDuplicateFaces", false), value);
    }

    public static event ILContext.Manipulator RemoveDuplicateEdges
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder2D), "RemoveDuplicateEdges", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder2D), "RemoveDuplicateEdges", false), value);
    }

    public static event ILContext.Manipulator MergeEdges
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder2D), "MergeEdges", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder2D), "MergeEdges", false), value);
    }
}