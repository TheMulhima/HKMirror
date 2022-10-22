using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.ILHooks;
/// <summary>
/// Contains all correct IL Hooks for tk2dTileMap,
/// Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
/// Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dTileMap
{
public static event ILContext.Manipulator get_Editor__SpriteCollection
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTileMap), "get_Editor__SpriteCollection", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTileMap), "get_Editor__SpriteCollection", true), value);
}
public static event ILContext.Manipulator set_Editor__SpriteCollection
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTileMap), "set_Editor__SpriteCollection", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTileMap), "set_Editor__SpriteCollection", true), value);
}
public static event ILContext.Manipulator get_SpriteCollectionInst
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTileMap), "get_SpriteCollectionInst", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTileMap), "get_SpriteCollectionInst", true), value);
}
public static event ILContext.Manipulator get_AllowEdit
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTileMap), "get_AllowEdit", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTileMap), "get_AllowEdit", true), value);
}
public static event ILContext.Manipulator Awake
{
add => IL.tk2dTileMap.Awake += value;
remove => IL.tk2dTileMap.Awake -= value;
}
public static event ILContext.Manipulator OnDestroy
{
add => IL.tk2dTileMap.OnDestroy += value;
remove => IL.tk2dTileMap.OnDestroy -= value;
}
public static event ILContext.Manipulator Build
{
add => IL.tk2dTileMap.Build += value;
remove => IL.tk2dTileMap.Build -= value;
}
public static event ILContext.Manipulator ForceBuild
{
add => IL.tk2dTileMap.ForceBuild += value;
remove => IL.tk2dTileMap.ForceBuild -= value;
}
public static event ILContext.Manipulator ClearSpawnedInstances
{
add => IL.tk2dTileMap.ClearSpawnedInstances += value;
remove => IL.tk2dTileMap.ClearSpawnedInstances -= value;
}
public static event ILContext.Manipulator SetPrefabsRootActive
{
add => IL.tk2dTileMap.SetPrefabsRootActive += value;
remove => IL.tk2dTileMap.SetPrefabsRootActive -= value;
}
public static event ILContext.Manipulator Build_BuildFlags
{
add => IL.tk2dTileMap.Build_BuildFlags += value;
remove => IL.tk2dTileMap.Build_BuildFlags -= value;
}
public static event ILContext.Manipulator GetTileAtPosition
{
add => IL.tk2dTileMap.GetTileAtPosition += value;
remove => IL.tk2dTileMap.GetTileAtPosition -= value;
}
public static event ILContext.Manipulator GetTileFracAtPosition
{
add => IL.tk2dTileMap.GetTileFracAtPosition += value;
remove => IL.tk2dTileMap.GetTileFracAtPosition -= value;
}
public static event ILContext.Manipulator GetTilePosition
{
add => IL.tk2dTileMap.GetTilePosition += value;
remove => IL.tk2dTileMap.GetTilePosition -= value;
}
public static event ILContext.Manipulator GetTileIdAtPosition
{
add => IL.tk2dTileMap.GetTileIdAtPosition += value;
remove => IL.tk2dTileMap.GetTileIdAtPosition -= value;
}
public static event ILContext.Manipulator GetTileInfoForTileId
{
add => IL.tk2dTileMap.GetTileInfoForTileId += value;
remove => IL.tk2dTileMap.GetTileInfoForTileId -= value;
}
public static event ILContext.Manipulator GetInterpolatedColorAtPosition
{
add => IL.tk2dTileMap.GetInterpolatedColorAtPosition += value;
remove => IL.tk2dTileMap.GetInterpolatedColorAtPosition -= value;
}
public static event ILContext.Manipulator UsesSpriteCollection
{
add => IL.tk2dTileMap.UsesSpriteCollection += value;
remove => IL.tk2dTileMap.UsesSpriteCollection -= value;
}
public static event ILContext.Manipulator EndEditMode
{
add => IL.tk2dTileMap.EndEditMode += value;
remove => IL.tk2dTileMap.EndEditMode -= value;
}
public static event ILContext.Manipulator TouchMesh
{
add => IL.tk2dTileMap.TouchMesh += value;
remove => IL.tk2dTileMap.TouchMesh -= value;
}
public static event ILContext.Manipulator DestroyMesh
{
add => IL.tk2dTileMap.DestroyMesh += value;
remove => IL.tk2dTileMap.DestroyMesh -= value;
}
public static event ILContext.Manipulator GetTilePrefabsListCount
{
add => IL.tk2dTileMap.GetTilePrefabsListCount += value;
remove => IL.tk2dTileMap.GetTilePrefabsListCount -= value;
}
public static event ILContext.Manipulator get_TilePrefabsList
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTileMap), "get_TilePrefabsList", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTileMap), "get_TilePrefabsList", true), value);
}
public static event ILContext.Manipulator GetTilePrefabsListItem
{
add => IL.tk2dTileMap.GetTilePrefabsListItem += value;
remove => IL.tk2dTileMap.GetTilePrefabsListItem -= value;
}
public static event ILContext.Manipulator SetTilePrefabsList
{
add => IL.tk2dTileMap.SetTilePrefabsList += value;
remove => IL.tk2dTileMap.SetTilePrefabsList -= value;
}
public static event ILContext.Manipulator get_Layers
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTileMap), "get_Layers", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTileMap), "get_Layers", true), value);
}
public static event ILContext.Manipulator set_Layers
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTileMap), "set_Layers", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTileMap), "set_Layers", true), value);
}
public static event ILContext.Manipulator get_ColorChannel
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTileMap), "get_ColorChannel", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTileMap), "get_ColorChannel", true), value);
}
public static event ILContext.Manipulator set_ColorChannel
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTileMap), "set_ColorChannel", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTileMap), "set_ColorChannel", true), value);
}
public static event ILContext.Manipulator get_PrefabsRoot
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTileMap), "get_PrefabsRoot", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTileMap), "get_PrefabsRoot", true), value);
}
public static event ILContext.Manipulator set_PrefabsRoot
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dTileMap), "set_PrefabsRoot", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dTileMap), "set_PrefabsRoot", true), value);
}
public static event ILContext.Manipulator GetTile
{
add => IL.tk2dTileMap.GetTile += value;
remove => IL.tk2dTileMap.GetTile -= value;
}
public static event ILContext.Manipulator GetTileFlags
{
add => IL.tk2dTileMap.GetTileFlags += value;
remove => IL.tk2dTileMap.GetTileFlags -= value;
}
public static event ILContext.Manipulator SetTile
{
add => IL.tk2dTileMap.SetTile += value;
remove => IL.tk2dTileMap.SetTile -= value;
}
public static event ILContext.Manipulator SetTileFlags
{
add => IL.tk2dTileMap.SetTileFlags += value;
remove => IL.tk2dTileMap.SetTileFlags -= value;
}
public static event ILContext.Manipulator ClearTile
{
add => IL.tk2dTileMap.ClearTile += value;
remove => IL.tk2dTileMap.ClearTile -= value;
}
}
