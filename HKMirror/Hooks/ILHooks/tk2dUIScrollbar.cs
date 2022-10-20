using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dUIScrollbar.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dUIScrollbar
{
    public static event ILContext.Manipulator get_BarLayoutItem
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollbar), "get_BarLayoutItem"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollbar), "get_BarLayoutItem"), value);
    }

    public static event ILContext.Manipulator set_BarLayoutItem
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollbar), "set_BarLayoutItem"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollbar), "set_BarLayoutItem"), value);
    }

    public static event ILContext.Manipulator get_SendMessageTarget
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollbar), "get_SendMessageTarget"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollbar), "get_SendMessageTarget"), value);
    }

    public static event ILContext.Manipulator set_SendMessageTarget
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollbar), "set_SendMessageTarget"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollbar), "set_SendMessageTarget"), value);
    }

    public static event ILContext.Manipulator get_Value
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollbar), "get_Value"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollbar), "get_Value"),
            value);
    }

    public static event ILContext.Manipulator set_Value
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollbar), "set_Value"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIScrollbar), "set_Value"),
            value);
    }

    public static event ILContext.Manipulator SetScrollPercentWithoutEvent
    {
        add => IL.tk2dUIScrollbar.SetScrollPercentWithoutEvent += value;
        remove => IL.tk2dUIScrollbar.SetScrollPercentWithoutEvent -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.tk2dUIScrollbar.OnEnable += value;
        remove => IL.tk2dUIScrollbar.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.tk2dUIScrollbar.OnDisable += value;
        remove => IL.tk2dUIScrollbar.OnDisable -= value;
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.tk2dUIScrollbar.Awake += value;
        remove => IL.tk2dUIScrollbar.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.tk2dUIScrollbar.Start += value;
        remove => IL.tk2dUIScrollbar.Start -= value;
    }

    public static event ILContext.Manipulator TrackHoverScrollWheelChange
    {
        add => IL.tk2dUIScrollbar.TrackHoverScrollWheelChange += value;
        remove => IL.tk2dUIScrollbar.TrackHoverScrollWheelChange -= value;
    }

    public static event ILContext.Manipulator SetScrollThumbPosition
    {
        add => IL.tk2dUIScrollbar.SetScrollThumbPosition += value;
        remove => IL.tk2dUIScrollbar.SetScrollThumbPosition -= value;
    }

    public static event ILContext.Manipulator MoveScrollThumbButton
    {
        add => IL.tk2dUIScrollbar.MoveScrollThumbButton += value;
        remove => IL.tk2dUIScrollbar.MoveScrollThumbButton -= value;
    }

    public static event ILContext.Manipulator CalculateClickWorldPos
    {
        add => IL.tk2dUIScrollbar.CalculateClickWorldPos += value;
        remove => IL.tk2dUIScrollbar.CalculateClickWorldPos -= value;
    }

    public static event ILContext.Manipulator ScrollToPosition
    {
        add => IL.tk2dUIScrollbar.ScrollToPosition += value;
        remove => IL.tk2dUIScrollbar.ScrollToPosition -= value;
    }

    public static event ILContext.Manipulator ScrollTrackButtonDown
    {
        add => IL.tk2dUIScrollbar.ScrollTrackButtonDown += value;
        remove => IL.tk2dUIScrollbar.ScrollTrackButtonDown -= value;
    }

    public static event ILContext.Manipulator ScrollTrackButtonHoverOver
    {
        add => IL.tk2dUIScrollbar.ScrollTrackButtonHoverOver += value;
        remove => IL.tk2dUIScrollbar.ScrollTrackButtonHoverOver -= value;
    }

    public static event ILContext.Manipulator ScrollTrackButtonHoverOut
    {
        add => IL.tk2dUIScrollbar.ScrollTrackButtonHoverOut += value;
        remove => IL.tk2dUIScrollbar.ScrollTrackButtonHoverOut -= value;
    }

    public static event ILContext.Manipulator ScrollThumbButtonDown
    {
        add => IL.tk2dUIScrollbar.ScrollThumbButtonDown += value;
        remove => IL.tk2dUIScrollbar.ScrollThumbButtonDown -= value;
    }

    public static event ILContext.Manipulator ScrollThumbButtonRelease
    {
        add => IL.tk2dUIScrollbar.ScrollThumbButtonRelease += value;
        remove => IL.tk2dUIScrollbar.ScrollThumbButtonRelease -= value;
    }

    public static event ILContext.Manipulator ScrollUpButtonDown
    {
        add => IL.tk2dUIScrollbar.ScrollUpButtonDown += value;
        remove => IL.tk2dUIScrollbar.ScrollUpButtonDown -= value;
    }

    public static event ILContext.Manipulator ScrollUpButtonUp
    {
        add => IL.tk2dUIScrollbar.ScrollUpButtonUp += value;
        remove => IL.tk2dUIScrollbar.ScrollUpButtonUp -= value;
    }

    public static event ILContext.Manipulator ScrollDownButtonDown
    {
        add => IL.tk2dUIScrollbar.ScrollDownButtonDown += value;
        remove => IL.tk2dUIScrollbar.ScrollDownButtonDown -= value;
    }

    public static event ILContext.Manipulator ScrollDownButtonUp
    {
        add => IL.tk2dUIScrollbar.ScrollDownButtonUp += value;
        remove => IL.tk2dUIScrollbar.ScrollDownButtonUp -= value;
    }

    public static event ILContext.Manipulator ScrollUpFixed
    {
        add => IL.tk2dUIScrollbar.ScrollUpFixed += value;
        remove => IL.tk2dUIScrollbar.ScrollUpFixed -= value;
    }

    public static event ILContext.Manipulator ScrollDownFixed
    {
        add => IL.tk2dUIScrollbar.ScrollDownFixed += value;
        remove => IL.tk2dUIScrollbar.ScrollDownFixed -= value;
    }

    public static event ILContext.Manipulator CheckRepeatScrollUpDownButton
    {
        add => IL.tk2dUIScrollbar.CheckRepeatScrollUpDownButton += value;
        remove => IL.tk2dUIScrollbar.CheckRepeatScrollUpDownButton -= value;
    }

    public static event ILContext.Manipulator ScrollDirection
    {
        add => IL.tk2dUIScrollbar.ScrollDirection += value;
        remove => IL.tk2dUIScrollbar.ScrollDirection -= value;
    }

    public static event ILContext.Manipulator CalcScrollPercentOffsetButtonScrollDistance
    {
        add => IL.tk2dUIScrollbar.CalcScrollPercentOffsetButtonScrollDistance += value;
        remove => IL.tk2dUIScrollbar.CalcScrollPercentOffsetButtonScrollDistance -= value;
    }

    public static event ILContext.Manipulator LayoutReshaped
    {
        add => IL.tk2dUIScrollbar.LayoutReshaped += value;
        remove => IL.tk2dUIScrollbar.LayoutReshaped -= value;
    }
}