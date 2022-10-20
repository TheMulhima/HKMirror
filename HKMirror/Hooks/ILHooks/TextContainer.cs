using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TextContainer.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTextContainer
{
    public static event ILContext.Manipulator get_hasChanged
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_hasChanged"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_hasChanged"),
            value);
    }

    public static event ILContext.Manipulator set_hasChanged
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "set_hasChanged"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "set_hasChanged"),
            value);
    }

    public static event ILContext.Manipulator get_pivot
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_pivot"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_pivot"),
            value);
    }

    public static event ILContext.Manipulator set_pivot
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "set_pivot"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "set_pivot"),
            value);
    }

    public static event ILContext.Manipulator get_anchorPosition
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_anchorPosition"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_anchorPosition"), value);
    }

    public static event ILContext.Manipulator set_anchorPosition
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "set_anchorPosition"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextContainer), "set_anchorPosition"), value);
    }

    public static event ILContext.Manipulator get_rect
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_rect"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_rect"), value);
    }

    public static event ILContext.Manipulator set_rect
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "set_rect"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "set_rect"), value);
    }

    public static event ILContext.Manipulator get_size
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_size"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_size"), value);
    }

    public static event ILContext.Manipulator set_size
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "set_size"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "set_size"), value);
    }

    public static event ILContext.Manipulator get_width
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_width"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_width"),
            value);
    }

    public static event ILContext.Manipulator set_width
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "set_width"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "set_width"),
            value);
    }

    public static event ILContext.Manipulator get_height
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_height"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_height"),
            value);
    }

    public static event ILContext.Manipulator set_height
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "set_height"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "set_height"),
            value);
    }

    public static event ILContext.Manipulator get_isDefaultWidth
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_isDefaultWidth"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_isDefaultWidth"), value);
    }

    public static event ILContext.Manipulator get_isDefaultHeight
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_isDefaultHeight"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_isDefaultHeight"), value);
    }

    public static event ILContext.Manipulator get_isAutoFitting
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_isAutoFitting"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_isAutoFitting"), value);
    }

    public static event ILContext.Manipulator set_isAutoFitting
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "set_isAutoFitting"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextContainer), "set_isAutoFitting"), value);
    }

    public static event ILContext.Manipulator get_corners
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_corners"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_corners"),
            value);
    }

    public static event ILContext.Manipulator get_worldCorners
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_worldCorners"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_worldCorners"), value);
    }

    public static event ILContext.Manipulator get_margins
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_margins"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_margins"),
            value);
    }

    public static event ILContext.Manipulator set_margins
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "set_margins"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "set_margins"),
            value);
    }

    public static event ILContext.Manipulator get_rectTransform
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_rectTransform"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_rectTransform"), value);
    }

    public static event ILContext.Manipulator get_textMeshPro
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_textMeshPro"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "get_textMeshPro"),
            value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "Awake"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "Awake"), value);
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "OnEnable"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "OnEnable"), value);
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "OnDisable"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "OnDisable"),
            value);
    }

    public static event ILContext.Manipulator OnContainerChanged
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "OnContainerChanged"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextContainer), "OnContainerChanged"), value);
    }

    public static event ILContext.Manipulator OnRectTransformDimensionsChange
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TextContainer), "OnRectTransformDimensionsChange"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextContainer), "OnRectTransformDimensionsChange"), value);
    }

    public static event ILContext.Manipulator SetRect
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "SetRect"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "SetRect"), value);
    }

    public static event ILContext.Manipulator UpdateCorners
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "UpdateCorners"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "UpdateCorners"),
            value);
    }

    public static event ILContext.Manipulator GetPivot
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "GetPivot"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "GetPivot"), value);
    }

    public static event ILContext.Manipulator GetAnchorPosition
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TextContainer), "GetAnchorPosition"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TextContainer), "GetAnchorPosition"), value);
    }
}