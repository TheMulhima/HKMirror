using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dBatchedSprite.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dBatchedSprite
{
    public static event ILContext.Manipulator get_BoxColliderOffsetZ
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_BoxColliderOffsetZ"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_BoxColliderOffsetZ"), value);
    }

    public static event ILContext.Manipulator set_BoxColliderOffsetZ
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_BoxColliderOffsetZ"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_BoxColliderOffsetZ"), value);
    }

    public static event ILContext.Manipulator get_BoxColliderExtentZ
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_BoxColliderExtentZ"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_BoxColliderExtentZ"), value);
    }

    public static event ILContext.Manipulator set_BoxColliderExtentZ
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_BoxColliderExtentZ"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_BoxColliderExtentZ"), value);
    }

    public static event ILContext.Manipulator get_FormattedText
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_FormattedText"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_FormattedText"), value);
    }

    public static event ILContext.Manipulator set_FormattedText
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_FormattedText"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_FormattedText"), value);
    }

    public static event ILContext.Manipulator get_ClippedSpriteRegionBottomLeft
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_ClippedSpriteRegionBottomLeft"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_ClippedSpriteRegionBottomLeft"), value);
    }

    public static event ILContext.Manipulator set_ClippedSpriteRegionBottomLeft
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_ClippedSpriteRegionBottomLeft"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_ClippedSpriteRegionBottomLeft"), value);
    }

    public static event ILContext.Manipulator get_ClippedSpriteRegionTopRight
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_ClippedSpriteRegionTopRight"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_ClippedSpriteRegionTopRight"), value);
    }

    public static event ILContext.Manipulator set_ClippedSpriteRegionTopRight
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_ClippedSpriteRegionTopRight"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_ClippedSpriteRegionTopRight"), value);
    }

    public static event ILContext.Manipulator get_SlicedSpriteBorderBottomLeft
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_SlicedSpriteBorderBottomLeft"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_SlicedSpriteBorderBottomLeft"), value);
    }

    public static event ILContext.Manipulator set_SlicedSpriteBorderBottomLeft
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_SlicedSpriteBorderBottomLeft"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_SlicedSpriteBorderBottomLeft"), value);
    }

    public static event ILContext.Manipulator get_SlicedSpriteBorderTopRight
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_SlicedSpriteBorderTopRight"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_SlicedSpriteBorderTopRight"), value);
    }

    public static event ILContext.Manipulator set_SlicedSpriteBorderTopRight
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_SlicedSpriteBorderTopRight"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_SlicedSpriteBorderTopRight"), value);
    }

    public static event ILContext.Manipulator get_Dimensions
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_Dimensions"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_Dimensions"), value);
    }

    public static event ILContext.Manipulator set_Dimensions
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_Dimensions"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_Dimensions"), value);
    }

    public static event ILContext.Manipulator get_IsDrawn
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_IsDrawn"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_IsDrawn"),
            value);
    }

    public static event ILContext.Manipulator get_CachedBoundsCenter
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_CachedBoundsCenter"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_CachedBoundsCenter"), value);
    }

    public static event ILContext.Manipulator set_CachedBoundsCenter
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_CachedBoundsCenter"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_CachedBoundsCenter"), value);
    }

    public static event ILContext.Manipulator get_CachedBoundsExtents
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_CachedBoundsExtents"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "get_CachedBoundsExtents"), value);
    }

    public static event ILContext.Manipulator set_CachedBoundsExtents
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_CachedBoundsExtents"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dBatchedSprite), "set_CachedBoundsExtents"), value);
    }

    public static event ILContext.Manipulator GetSpriteDefinition
    {
        add => IL.tk2dBatchedSprite.GetSpriteDefinition += value;
        remove => IL.tk2dBatchedSprite.GetSpriteDefinition -= value;
    }
}