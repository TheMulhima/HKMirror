using MonoMod.RuntimeDetour.HookGen;
using tk2dRuntime.TileMap;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Layer.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILLayer
{
    public static event ILContext.Manipulator Init
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Layer), "Init"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Layer), "Init"), value);
    }

    public static event ILContext.Manipulator get_IsEmpty
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Layer), "get_IsEmpty"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Layer), "get_IsEmpty"), value);
    }

    public static event ILContext.Manipulator Create
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Layer), "Create"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Layer), "Create"), value);
    }

    public static event ILContext.Manipulator GetChunkData
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Layer), "GetChunkData"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Layer), "GetChunkData"), value);
    }

    public static event ILContext.Manipulator GetChunk
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Layer), "GetChunk"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Layer), "GetChunk"), value);
    }

    public static event ILContext.Manipulator FindChunkAndCoordinate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Layer), "FindChunkAndCoordinate"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Layer), "FindChunkAndCoordinate"),
            value);
    }

    public static event ILContext.Manipulator GetRawTileValue
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Layer), "GetRawTileValue"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Layer), "GetRawTileValue"), value);
    }

    public static event ILContext.Manipulator SetRawTileValue
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Layer), "SetRawTileValue"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Layer), "SetRawTileValue"), value);
    }

    public static event ILContext.Manipulator DestroyGameData
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Layer), "DestroyGameData"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Layer), "DestroyGameData"), value);
    }

    public static event ILContext.Manipulator GetTile
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Layer), "GetTile"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Layer), "GetTile"), value);
    }

    public static event ILContext.Manipulator GetTileFlags
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Layer), "GetTileFlags"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Layer), "GetTileFlags"), value);
    }

    public static event ILContext.Manipulator GetRawTile
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Layer), "GetRawTile"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Layer), "GetRawTile"), value);
    }

    public static event ILContext.Manipulator SetTile
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Layer), "SetTile"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Layer), "SetTile"), value);
    }

    public static event ILContext.Manipulator SetTileFlags
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Layer), "SetTileFlags"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Layer), "SetTileFlags"), value);
    }

    public static event ILContext.Manipulator ClearTile
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Layer), "ClearTile"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Layer), "ClearTile"), value);
    }

    public static event ILContext.Manipulator SetRawTile
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Layer), "SetRawTile"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Layer), "SetRawTile"), value);
    }

    public static event ILContext.Manipulator CreateChunk
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Layer), "CreateChunk"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Layer), "CreateChunk"), value);
    }

    public static event ILContext.Manipulator Optimize_SpriteChunk
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Layer), "Optimize"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Layer), "Optimize"), value);
    }

    public static event ILContext.Manipulator Optimize
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Layer), "Optimize"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Layer), "Optimize"), value);
    }

    public static event ILContext.Manipulator OptimizeIncremental
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Layer), "OptimizeIncremental"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Layer), "OptimizeIncremental"),
            value);
    }

    public static event ILContext.Manipulator ClearDirtyFlag
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Layer), "ClearDirtyFlag"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Layer), "ClearDirtyFlag"), value);
    }

    public static event ILContext.Manipulator get_NumActiveChunks
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Layer), "get_NumActiveChunks"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Layer), "get_NumActiveChunks"),
            value);
    }
}