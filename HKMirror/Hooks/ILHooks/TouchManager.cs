using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TouchManager.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTouchManager
{
    public static event ILContext.Manipulator OnEnable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "OnEnable"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "OnEnable"), value);
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "OnDisable"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "OnDisable"), value);
    }

    public static event ILContext.Manipulator Setup
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "Setup"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "Setup"), value);
    }

    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "Reset"), value);
    }

    public static event ILContext.Manipulator UpdateScreenSizeAtEndOfFrame
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "UpdateScreenSizeAtEndOfFrame")
                .GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "UpdateScreenSizeAtEndOfFrame")
                .GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Update
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "Update"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "Update"), value);
    }

    public static event ILContext.Manipulator CreateDevice
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "CreateDevice"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "CreateDevice"),
            value);
    }

    public static event ILContext.Manipulator UpdateDevice
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "UpdateDevice"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "UpdateDevice"),
            value);
    }

    public static event ILContext.Manipulator CommitDevice
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "CommitDevice"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "CommitDevice"),
            value);
    }

    public static event ILContext.Manipulator SubmitControlStates
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "SubmitControlStates"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "SubmitControlStates"), value);
    }

    public static event ILContext.Manipulator CommitControlStates
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "CommitControlStates"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "CommitControlStates"), value);
    }

    public static event ILContext.Manipulator UpdateScreenSize
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "UpdateScreenSize"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "UpdateScreenSize"),
            value);
    }

    public static event ILContext.Manipulator CreateTouches
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "CreateTouches"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "CreateTouches"),
            value);
    }

    public static event ILContext.Manipulator UpdateTouches
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "UpdateTouches"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "UpdateTouches"),
            value);
    }

    public static event ILContext.Manipulator SendTouchBegan
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "SendTouchBegan"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "SendTouchBegan"),
            value);
    }

    public static event ILContext.Manipulator SendTouchMoved
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "SendTouchMoved"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "SendTouchMoved"),
            value);
    }

    public static event ILContext.Manipulator SendTouchEnded
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "SendTouchEnded"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "SendTouchEnded"),
            value);
    }

    public static event ILContext.Manipulator InvokeTouchEvents
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "InvokeTouchEvents"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "InvokeTouchEvents"), value);
    }

    public static event ILContext.Manipulator TouchCameraIsValid
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "TouchCameraIsValid"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "TouchCameraIsValid"), value);
    }

    public static event ILContext.Manipulator ConvertScreenToWorldPoint
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "ConvertScreenToWorldPoint"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "ConvertScreenToWorldPoint"), value);
    }

    public static event ILContext.Manipulator ConvertViewToWorldPoint
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "ConvertViewToWorldPoint"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "ConvertViewToWorldPoint"), value);
    }

    public static event ILContext.Manipulator ConvertScreenToViewPoint
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "ConvertScreenToViewPoint"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "ConvertScreenToViewPoint"), value);
    }

    public static event ILContext.Manipulator GetCurrentScreenSize
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "GetCurrentScreenSize"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "GetCurrentScreenSize"), value);
    }

    public static event ILContext.Manipulator get_controlsEnabled
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "get_controlsEnabled"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "get_controlsEnabled"), value);
    }

    public static event ILContext.Manipulator set_controlsEnabled
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "set_controlsEnabled"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "set_controlsEnabled"), value);
    }

    public static event ILContext.Manipulator get_Touches
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "get_Touches", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "get_Touches", false), value);
    }

    public static event ILContext.Manipulator get_TouchCount
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "get_TouchCount", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "get_TouchCount", false), value);
    }

    public static event ILContext.Manipulator GetTouch
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "GetTouch", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "GetTouch", false),
            value);
    }

    public static event ILContext.Manipulator GetTouchByFingerId
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "GetTouchByFingerId", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "GetTouchByFingerId", false), value);
    }

    public static event ILContext.Manipulator ScreenToWorldPoint
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "ScreenToWorldPoint", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "ScreenToWorldPoint", false), value);
    }

    public static event ILContext.Manipulator ViewToWorldPoint
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "ViewToWorldPoint", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "ViewToWorldPoint", false), value);
    }

    public static event ILContext.Manipulator ScreenToViewPoint
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "ScreenToViewPoint", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "ScreenToViewPoint", false), value);
    }

    public static event ILContext.Manipulator ConvertToWorld_float_TouchUnitType
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "ConvertToWorld", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "ConvertToWorld", false), value);
    }

    public static event ILContext.Manipulator PercentToWorldRect
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "PercentToWorldRect", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "PercentToWorldRect", false), value);
    }

    public static event ILContext.Manipulator PixelToWorldRect
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "PixelToWorldRect", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "PixelToWorldRect", false), value);
    }

    public static event ILContext.Manipulator ConvertToWorld_Rect_TouchUnitType
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "ConvertToWorld", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "ConvertToWorld", false), value);
    }

    public static event ILContext.Manipulator get_Camera
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "get_Camera", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "get_Camera", false), value);
    }

    public static event ILContext.Manipulator get_Device
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "get_Device", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "get_Device", false), value);
    }

    public static event ILContext.Manipulator get_ViewSize
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "get_ViewSize", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "get_ViewSize", false), value);
    }

    public static event ILContext.Manipulator get_PercentToWorld
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "get_PercentToWorld", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "get_PercentToWorld", false), value);
    }

    public static event ILContext.Manipulator get_HalfPercentToWorld
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "get_HalfPercentToWorld", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "get_HalfPercentToWorld", false), value);
    }

    public static event ILContext.Manipulator get_PixelToWorld
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "get_PixelToWorld", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "get_PixelToWorld", false), value);
    }

    public static event ILContext.Manipulator get_HalfPixelToWorld
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "get_HalfPixelToWorld", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "get_HalfPixelToWorld", false), value);
    }

    public static event ILContext.Manipulator get_ScreenSize
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "get_ScreenSize", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "get_ScreenSize", false), value);
    }

    public static event ILContext.Manipulator get_HalfScreenSize
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "get_HalfScreenSize", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "get_HalfScreenSize", false), value);
    }

    public static event ILContext.Manipulator get_ControlsEnabled
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "get_ControlsEnabled", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "get_ControlsEnabled", false), value);
    }

    public static event ILContext.Manipulator set_ControlsEnabled
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "set_ControlsEnabled", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "set_ControlsEnabled", false), value);
    }

    public static event ILContext.Manipulator op_Implicit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TouchManager), "op_Implicit", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TouchManager), "op_Implicit", false), value);
    }
}