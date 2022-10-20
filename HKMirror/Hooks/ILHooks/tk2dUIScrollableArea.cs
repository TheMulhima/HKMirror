using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dUIScrollableArea.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dUIScrollableArea
{
    public static event ILContext.Manipulator get_ContentLength
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollableArea), "get_ContentLength"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollableArea), "get_ContentLength"), value);
    }

    public static event ILContext.Manipulator set_ContentLength
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollableArea), "set_ContentLength"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollableArea), "set_ContentLength"), value);
    }

    public static event ILContext.Manipulator get_VisibleAreaLength
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollableArea), "get_VisibleAreaLength"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollableArea), "get_VisibleAreaLength"), value);
    }

    public static event ILContext.Manipulator set_VisibleAreaLength
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollableArea), "set_VisibleAreaLength"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollableArea), "set_VisibleAreaLength"), value);
    }

    public static event ILContext.Manipulator get_BackgroundLayoutItem
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollableArea), "get_BackgroundLayoutItem"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollableArea), "get_BackgroundLayoutItem"), value);
    }

    public static event ILContext.Manipulator set_BackgroundLayoutItem
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollableArea), "set_BackgroundLayoutItem"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollableArea), "set_BackgroundLayoutItem"), value);
    }

    public static event ILContext.Manipulator get_ContentLayoutContainer
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollableArea), "get_ContentLayoutContainer"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollableArea), "get_ContentLayoutContainer"), value);
    }

    public static event ILContext.Manipulator set_ContentLayoutContainer
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollableArea), "set_ContentLayoutContainer"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollableArea), "set_ContentLayoutContainer"), value);
    }

    public static event ILContext.Manipulator get_SendMessageTarget
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollableArea), "get_SendMessageTarget"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollableArea), "get_SendMessageTarget"), value);
    }

    public static event ILContext.Manipulator set_SendMessageTarget
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollableArea), "set_SendMessageTarget"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollableArea), "set_SendMessageTarget"), value);
    }

    public static event ILContext.Manipulator get_Value
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollableArea), "get_Value"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollableArea), "get_Value"), value);
    }

    public static event ILContext.Manipulator set_Value
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollableArea), "set_Value"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollableArea), "set_Value"), value);
    }

    public static event ILContext.Manipulator SetScrollPercentWithoutEvent
    {
        add => IL.tk2dUIScrollableArea.SetScrollPercentWithoutEvent += value;
        remove => IL.tk2dUIScrollableArea.SetScrollPercentWithoutEvent -= value;
    }

    public static event ILContext.Manipulator MeasureContentLength
    {
        add => IL.tk2dUIScrollableArea.MeasureContentLength += value;
        remove => IL.tk2dUIScrollableArea.MeasureContentLength -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.tk2dUIScrollableArea.OnEnable += value;
        remove => IL.tk2dUIScrollableArea.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.tk2dUIScrollableArea.OnDisable += value;
        remove => IL.tk2dUIScrollableArea.OnDisable -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.tk2dUIScrollableArea.Start += value;
        remove => IL.tk2dUIScrollableArea.Start -= value;
    }

    public static event ILContext.Manipulator BackgroundHoverOverScrollWheelChange
    {
        add => IL.tk2dUIScrollableArea.BackgroundHoverOverScrollWheelChange += value;
        remove => IL.tk2dUIScrollableArea.BackgroundHoverOverScrollWheelChange -= value;
    }

    public static event ILContext.Manipulator ScrollBarMove
    {
        add => IL.tk2dUIScrollableArea.ScrollBarMove += value;
        remove => IL.tk2dUIScrollableArea.ScrollBarMove -= value;
    }

    public static event ILContext.Manipulator get_ContentContainerOffset
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollableArea), "get_ContentContainerOffset"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollableArea), "get_ContentContainerOffset"), value);
    }

    public static event ILContext.Manipulator set_ContentContainerOffset
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollableArea), "set_ContentContainerOffset"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollableArea), "set_ContentContainerOffset"), value);
    }

    public static event ILContext.Manipulator SetContentPosition
    {
        add => IL.tk2dUIScrollableArea.SetContentPosition += value;
        remove => IL.tk2dUIScrollableArea.SetContentPosition -= value;
    }

    public static event ILContext.Manipulator BackgroundButtonDown
    {
        add => IL.tk2dUIScrollableArea.BackgroundButtonDown += value;
        remove => IL.tk2dUIScrollableArea.BackgroundButtonDown -= value;
    }

    public static event ILContext.Manipulator BackgroundOverUpdate
    {
        add => IL.tk2dUIScrollableArea.BackgroundOverUpdate += value;
        remove => IL.tk2dUIScrollableArea.BackgroundOverUpdate -= value;
    }

    public static event ILContext.Manipulator UpdateSwipeScrollDestintationPosition
    {
        add => IL.tk2dUIScrollableArea.UpdateSwipeScrollDestintationPosition += value;
        remove => IL.tk2dUIScrollableArea.UpdateSwipeScrollDestintationPosition -= value;
    }

    public static event ILContext.Manipulator BackgroundButtonRelease
    {
        add => IL.tk2dUIScrollableArea.BackgroundButtonRelease += value;
        remove => IL.tk2dUIScrollableArea.BackgroundButtonRelease -= value;
    }

    public static event ILContext.Manipulator BackgroundButtonHoverOver
    {
        add => IL.tk2dUIScrollableArea.BackgroundButtonHoverOver += value;
        remove => IL.tk2dUIScrollableArea.BackgroundButtonHoverOver -= value;
    }

    public static event ILContext.Manipulator BackgroundButtonHoverOut
    {
        add => IL.tk2dUIScrollableArea.BackgroundButtonHoverOut += value;
        remove => IL.tk2dUIScrollableArea.BackgroundButtonHoverOut -= value;
    }

    public static event ILContext.Manipulator CalculateClickWorldPos
    {
        add => IL.tk2dUIScrollableArea.CalculateClickWorldPos += value;
        remove => IL.tk2dUIScrollableArea.CalculateClickWorldPos -= value;
    }

    public static event ILContext.Manipulator UpdateScrollbarActiveState
    {
        add => IL.tk2dUIScrollableArea.UpdateScrollbarActiveState += value;
        remove => IL.tk2dUIScrollableArea.UpdateScrollbarActiveState -= value;
    }

    public static event ILContext.Manipulator ContentLengthVisibleAreaLengthChange
    {
        add => IL.tk2dUIScrollableArea.ContentLengthVisibleAreaLengthChange += value;
        remove => IL.tk2dUIScrollableArea.ContentLengthVisibleAreaLengthChange -= value;
    }

    public static event ILContext.Manipulator UnpressAllUIItemChildren
    {
        add => IL.tk2dUIScrollableArea.UnpressAllUIItemChildren += value;
        remove => IL.tk2dUIScrollableArea.UnpressAllUIItemChildren -= value;
    }

    public static event ILContext.Manipulator TargetOnScrollCallback
    {
        add => IL.tk2dUIScrollableArea.TargetOnScrollCallback += value;
        remove => IL.tk2dUIScrollableArea.TargetOnScrollCallback -= value;
    }

    public static event ILContext.Manipulator GetRendererBoundsInChildren
    {
        add => IL.tk2dUIScrollableArea.GetRendererBoundsInChildren += value;
        remove => IL.tk2dUIScrollableArea.GetRendererBoundsInChildren -= value;
    }

    public static event ILContext.Manipulator LayoutReshaped
    {
        add => IL.tk2dUIScrollableArea.LayoutReshaped += value;
        remove => IL.tk2dUIScrollableArea.LayoutReshaped -= value;
    }

    public static event ILContext.Manipulator ContentLayoutChangeCallback
    {
        add => IL.tk2dUIScrollableArea.ContentLayoutChangeCallback += value;
        remove => IL.tk2dUIScrollableArea.ContentLayoutChangeCallback -= value;
    }
}