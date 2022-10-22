using MonoMod.RuntimeDetour.HookGen;
using tk2dRuntime.TileMap;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BuilderUtil,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBuilderUtil
{
    public static event ILContext.Manipulator InitDataStore
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BuilderUtil), "InitDataStore", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BuilderUtil), "InitDataStore", false), value);
    }

    public static event ILContext.Manipulator GetExistingTilePrefabInstance
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BuilderUtil), "GetExistingTilePrefabInstance", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BuilderUtil), "GetExistingTilePrefabInstance", false), value);
    }

    public static event ILContext.Manipulator SpawnPrefabsForChunk
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BuilderUtil), "SpawnPrefabsForChunk", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BuilderUtil), "SpawnPrefabsForChunk", false), value);
    }

    public static event ILContext.Manipulator SpawnPrefabs
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BuilderUtil), "SpawnPrefabs", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BuilderUtil), "SpawnPrefabs", false), value);
    }

    public static event ILContext.Manipulator HideTileMapPrefabs
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BuilderUtil), "HideTileMapPrefabs", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BuilderUtil), "HideTileMapPrefabs", false), value);
    }

    public static event ILContext.Manipulator GetTilePosition
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BuilderUtil), "GetTilePosition", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BuilderUtil), "GetTilePosition", false), value);
    }

    public static event ILContext.Manipulator CreateRenderData
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BuilderUtil), "CreateRenderData", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BuilderUtil), "CreateRenderData", false), value);
    }

    public static event ILContext.Manipulator GetTileFromRawTile
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BuilderUtil), "GetTileFromRawTile", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BuilderUtil), "GetTileFromRawTile", false), value);
    }

    public static event ILContext.Manipulator IsRawTileFlagSet
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BuilderUtil), "IsRawTileFlagSet", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BuilderUtil), "IsRawTileFlagSet", false), value);
    }

    public static event ILContext.Manipulator SetRawTileFlag
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BuilderUtil), "SetRawTileFlag", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BuilderUtil), "SetRawTileFlag", false), value);
    }

    public static event ILContext.Manipulator InvertRawTileFlag
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BuilderUtil), "InvertRawTileFlag", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BuilderUtil), "InvertRawTileFlag", false), value);
    }

    public static event ILContext.Manipulator
        ApplySpriteVertexTileFlags_tk2dTileMap_tk2dSpriteDefinition_Vector3_bool_bool_bool
        {
            add => HookEndpointManager.Modify(
                ReflectionHelper.GetMethodInfo(typeof(BuilderUtil), "ApplySpriteVertexTileFlags", false), value);
            remove => HookEndpointManager.Unmodify(
                ReflectionHelper.GetMethodInfo(typeof(BuilderUtil), "ApplySpriteVertexTileFlags", false), value);
        }

    public static event ILContext.Manipulator
        ApplySpriteVertexTileFlags_tk2dTileMap_tk2dSpriteDefinition_Vector2_bool_bool_bool
        {
            add => HookEndpointManager.Modify(
                ReflectionHelper.GetMethodInfo(typeof(BuilderUtil), "ApplySpriteVertexTileFlags", false), value);
            remove => HookEndpointManager.Unmodify(
                ReflectionHelper.GetMethodInfo(typeof(BuilderUtil), "ApplySpriteVertexTileFlags", false), value);
        }
}