using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.ILHooks;
/// <summary>
/// Contains all correct IL Hooks for tk2dBatchedSprite,
/// Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
/// Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dBatchedSprite
{
public static event ILContext.Manipulator get_BoxColliderOffsetZ
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_BoxColliderOffsetZ", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_BoxColliderOffsetZ", true), value);
}
public static event ILContext.Manipulator set_BoxColliderOffsetZ
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_BoxColliderOffsetZ", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_BoxColliderOffsetZ", true), value);
}
public static event ILContext.Manipulator get_BoxColliderExtentZ
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_BoxColliderExtentZ", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_BoxColliderExtentZ", true), value);
}
public static event ILContext.Manipulator set_BoxColliderExtentZ
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_BoxColliderExtentZ", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_BoxColliderExtentZ", true), value);
}
public static event ILContext.Manipulator get_FormattedText
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_FormattedText", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_FormattedText", true), value);
}
public static event ILContext.Manipulator set_FormattedText
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_FormattedText", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_FormattedText", true), value);
}
public static event ILContext.Manipulator get_ClippedSpriteRegionBottomLeft
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_ClippedSpriteRegionBottomLeft", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_ClippedSpriteRegionBottomLeft", true), value);
}
public static event ILContext.Manipulator set_ClippedSpriteRegionBottomLeft
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_ClippedSpriteRegionBottomLeft", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_ClippedSpriteRegionBottomLeft", true), value);
}
public static event ILContext.Manipulator get_ClippedSpriteRegionTopRight
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_ClippedSpriteRegionTopRight", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_ClippedSpriteRegionTopRight", true), value);
}
public static event ILContext.Manipulator set_ClippedSpriteRegionTopRight
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_ClippedSpriteRegionTopRight", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_ClippedSpriteRegionTopRight", true), value);
}
public static event ILContext.Manipulator get_SlicedSpriteBorderBottomLeft
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_SlicedSpriteBorderBottomLeft", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_SlicedSpriteBorderBottomLeft", true), value);
}
public static event ILContext.Manipulator set_SlicedSpriteBorderBottomLeft
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_SlicedSpriteBorderBottomLeft", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_SlicedSpriteBorderBottomLeft", true), value);
}
public static event ILContext.Manipulator get_SlicedSpriteBorderTopRight
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_SlicedSpriteBorderTopRight", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_SlicedSpriteBorderTopRight", true), value);
}
public static event ILContext.Manipulator set_SlicedSpriteBorderTopRight
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_SlicedSpriteBorderTopRight", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_SlicedSpriteBorderTopRight", true), value);
}
public static event ILContext.Manipulator get_Dimensions
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_Dimensions", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_Dimensions", true), value);
}
public static event ILContext.Manipulator set_Dimensions
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_Dimensions", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_Dimensions", true), value);
}
public static event ILContext.Manipulator get_IsDrawn
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_IsDrawn", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_IsDrawn", true), value);
}
public static event ILContext.Manipulator CheckFlag
{
add => IL.tk2dBatchedSprite.CheckFlag += value;
remove => IL.tk2dBatchedSprite.CheckFlag -= value;
}
public static event ILContext.Manipulator SetFlag
{
add => IL.tk2dBatchedSprite.SetFlag += value;
remove => IL.tk2dBatchedSprite.SetFlag -= value;
}
public static event ILContext.Manipulator get_CachedBoundsCenter
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_CachedBoundsCenter", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_CachedBoundsCenter", true), value);
}
public static event ILContext.Manipulator set_CachedBoundsCenter
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_CachedBoundsCenter", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_CachedBoundsCenter", true), value);
}
public static event ILContext.Manipulator get_CachedBoundsExtents
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_CachedBoundsExtents", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_CachedBoundsExtents", true), value);
}
public static event ILContext.Manipulator set_CachedBoundsExtents
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_CachedBoundsExtents", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_CachedBoundsExtents", true), value);
}
public static event ILContext.Manipulator GetSpriteDefinition
{
add => IL.tk2dBatchedSprite.GetSpriteDefinition += value;
remove => IL.tk2dBatchedSprite.GetSpriteDefinition -= value;
}
}
