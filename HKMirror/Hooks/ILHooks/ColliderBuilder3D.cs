using MonoMod.RuntimeDetour.HookGen;
using tk2dRuntime.TileMap;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ColliderBuilder3D,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILColliderBuilder3D
{
    public static event ILContext.Manipulator Build
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder3D), "Build", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder3D), "Build", false), value);
    }

    public static event ILContext.Manipulator BuildForChunk
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder3D), "BuildForChunk", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder3D), "BuildForChunk", false), value);
    }

    public static event ILContext.Manipulator BuildLocalMeshForChunk
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder3D), "BuildLocalMeshForChunk", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder3D), "BuildLocalMeshForChunk", false), value);
    }

    public static event ILContext.Manipulator CompareWeldVertices
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder3D), "CompareWeldVertices", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder3D), "CompareWeldVertices", false), value);
    }

    public static event ILContext.Manipulator WeldVertices
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder3D), "WeldVertices", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder3D), "WeldVertices", false), value);
    }

    public static event ILContext.Manipulator CompareDuplicateFaces
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder3D), "CompareDuplicateFaces", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder3D), "CompareDuplicateFaces", false), value);
    }

    public static event ILContext.Manipulator RemoveDuplicateFaces
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder3D), "RemoveDuplicateFaces", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ColliderBuilder3D), "RemoveDuplicateFaces", false), value);
    }
}