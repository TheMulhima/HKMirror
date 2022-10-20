using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for InlineGraphicManager.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILInlineGraphicManager
{
    public static event ILContext.Manipulator get_spriteAsset
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "get_spriteAsset"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "get_spriteAsset"), value);
    }

    public static event ILContext.Manipulator set_spriteAsset
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "set_spriteAsset"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "set_spriteAsset"), value);
    }

    public static event ILContext.Manipulator get_inlineGraphic
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "get_inlineGraphic"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "get_inlineGraphic"), value);
    }

    public static event ILContext.Manipulator set_inlineGraphic
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "set_inlineGraphic"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "set_inlineGraphic"), value);
    }

    public static event ILContext.Manipulator get_canvasRenderer
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "get_canvasRenderer"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "get_canvasRenderer"), value);
    }

    public static event ILContext.Manipulator get_uiVertex
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "get_uiVertex"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "get_uiVertex"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "Awake"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "Awake"),
            value);
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "OnEnable"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "OnEnable"),
            value);
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "OnDisable"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "OnDisable"), value);
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "OnDestroy"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "OnDestroy"), value);
    }

    public static event ILContext.Manipulator LoadSpriteAsset
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "LoadSpriteAsset"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "LoadSpriteAsset"), value);
    }

    public static event ILContext.Manipulator AddInlineGraphicsChild
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "AddInlineGraphicsChild"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "AddInlineGraphicsChild"), value);
    }

    public static event ILContext.Manipulator AllocatedVertexBuffers
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "AllocatedVertexBuffers"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "AllocatedVertexBuffers"), value);
    }

    public static event ILContext.Manipulator UpdatePivot
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "UpdatePivot"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "UpdatePivot"), value);
    }

    public static event ILContext.Manipulator ClearUIVertex
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "ClearUIVertex"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "ClearUIVertex"), value);
    }

    public static event ILContext.Manipulator DrawSprite
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "DrawSprite"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "DrawSprite"), value);
    }

    public static event ILContext.Manipulator GetSprite
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "GetSprite"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "GetSprite"), value);
    }

    public static event ILContext.Manipulator GetSpriteIndexByHashCode
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "GetSpriteIndexByHashCode"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "GetSpriteIndexByHashCode"), value);
    }

    public static event ILContext.Manipulator GetSpriteIndexByIndex
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "GetSpriteIndexByIndex"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "GetSpriteIndexByIndex"), value);
    }

    public static event ILContext.Manipulator SetUIVertex
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "SetUIVertex"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InlineGraphicManager), "SetUIVertex"), value);
    }
}