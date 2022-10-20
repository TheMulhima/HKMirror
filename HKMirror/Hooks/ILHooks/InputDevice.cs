using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for InputDevice.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILInputDevice
{
    public static event ILContext.Manipulator get_Name
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_Name"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_Name"), value);
    }

    public static event ILContext.Manipulator set_Name
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_Name"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_Name"), value);
    }

    public static event ILContext.Manipulator get_Meta
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_Meta"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_Meta"), value);
    }

    public static event ILContext.Manipulator set_Meta
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_Meta"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_Meta"), value);
    }

    public static event ILContext.Manipulator get_SortOrder
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_SortOrder"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_SortOrder"),
            value);
    }

    public static event ILContext.Manipulator set_SortOrder
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_SortOrder"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_SortOrder"),
            value);
    }

    public static event ILContext.Manipulator get_DeviceClass
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_DeviceClass"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_DeviceClass"),
            value);
    }

    public static event ILContext.Manipulator set_DeviceClass
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_DeviceClass"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_DeviceClass"),
            value);
    }

    public static event ILContext.Manipulator get_DeviceStyle
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_DeviceStyle"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_DeviceStyle"),
            value);
    }

    public static event ILContext.Manipulator set_DeviceStyle
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_DeviceStyle"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_DeviceStyle"),
            value);
    }

    public static event ILContext.Manipulator get_GUID
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_GUID"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_GUID"), value);
    }

    public static event ILContext.Manipulator set_GUID
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_GUID"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_GUID"), value);
    }

    public static event ILContext.Manipulator get_LastInputTick
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_LastInputTick"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_LastInputTick"),
            value);
    }

    public static event ILContext.Manipulator set_LastInputTick
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_LastInputTick"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_LastInputTick"),
            value);
    }

    public static event ILContext.Manipulator get_IsActive
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_IsActive"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_IsActive"),
            value);
    }

    public static event ILContext.Manipulator set_IsActive
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_IsActive"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_IsActive"),
            value);
    }

    public static event ILContext.Manipulator get_IsAttached
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_IsAttached"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_IsAttached"),
            value);
    }

    public static event ILContext.Manipulator set_IsAttached
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_IsAttached"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_IsAttached"),
            value);
    }

    public static event ILContext.Manipulator get_RawSticks
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_RawSticks"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_RawSticks"),
            value);
    }

    public static event ILContext.Manipulator set_RawSticks
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_RawSticks"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_RawSticks"),
            value);
    }

    public static event ILContext.Manipulator get_Controls
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_Controls"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_Controls"),
            value);
    }

    public static event ILContext.Manipulator set_Controls
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_Controls"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_Controls"),
            value);
    }

    public static event ILContext.Manipulator get_ControlsByTarget
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_ControlsByTarget"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_ControlsByTarget"), value);
    }

    public static event ILContext.Manipulator set_ControlsByTarget
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_ControlsByTarget"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_ControlsByTarget"), value);
    }

    public static event ILContext.Manipulator get_LeftStick
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_LeftStick"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_LeftStick"),
            value);
    }

    public static event ILContext.Manipulator set_LeftStick
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_LeftStick"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_LeftStick"),
            value);
    }

    public static event ILContext.Manipulator get_RightStick
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_RightStick"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_RightStick"),
            value);
    }

    public static event ILContext.Manipulator set_RightStick
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_RightStick"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_RightStick"),
            value);
    }

    public static event ILContext.Manipulator get_DPad
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_DPad"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_DPad"), value);
    }

    public static event ILContext.Manipulator set_DPad
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_DPad"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_DPad"), value);
    }

    public static event ILContext.Manipulator get_LeftCommandControl
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_LeftCommandControl"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_LeftCommandControl"), value);
    }

    public static event ILContext.Manipulator set_LeftCommandControl
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_LeftCommandControl"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_LeftCommandControl"), value);
    }

    public static event ILContext.Manipulator get_RightCommandControl
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_RightCommandControl"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_RightCommandControl"), value);
    }

    public static event ILContext.Manipulator set_RightCommandControl
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_RightCommandControl"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_RightCommandControl"), value);
    }

    public static event ILContext.Manipulator get_AnalogSnapshot
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_AnalogSnapshot"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_AnalogSnapshot"), value);
    }

    public static event ILContext.Manipulator set_AnalogSnapshot
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_AnalogSnapshot"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "set_AnalogSnapshot"), value);
    }

    public static event ILContext.Manipulator OnAttached
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "OnAttached"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "OnAttached"), value);
    }

    public static event ILContext.Manipulator OnDetached
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "OnDetached"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "OnDetached"), value);
    }

    public static event ILContext.Manipulator AddAliasControls
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "AddAliasControls"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "AddAliasControls"),
            value);
    }

    public static event ILContext.Manipulator RemoveAliasControls
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "RemoveAliasControls"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "RemoveAliasControls"), value);
    }

    public static event ILContext.Manipulator ClearControls
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "ClearControls"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "ClearControls"),
            value);
    }

    public static event ILContext.Manipulator HasControl
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "HasControl"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "HasControl"), value);
    }

    public static event ILContext.Manipulator GetControl
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "GetControl"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "GetControl"), value);
    }

    public static event ILContext.Manipulator get_Item
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_Item"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_Item"), value);
    }

    public static event ILContext.Manipulator GetInputControlTypeByName
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "GetInputControlTypeByName", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "GetInputControlTypeByName", false), value);
    }

    public static event ILContext.Manipulator GetControlByName
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "GetControlByName"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "GetControlByName"),
            value);
    }

    public static event ILContext.Manipulator AddControl_InputControlType_string
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "AddControl"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "AddControl"), value);
    }

    public static event ILContext.Manipulator AddControl_InputControlType_string_float_float
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "AddControl"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "AddControl"), value);
    }

    public static event ILContext.Manipulator RemoveControl
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "RemoveControl"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "RemoveControl"),
            value);
    }

    public static event ILContext.Manipulator ClearInputState
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "ClearInputState"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "ClearInputState"),
            value);
    }

    public static event ILContext.Manipulator UpdateWithState
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "UpdateWithState"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "UpdateWithState"),
            value);
    }

    public static event ILContext.Manipulator UpdateWithValue
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "UpdateWithValue"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "UpdateWithValue"),
            value);
    }

    public static event ILContext.Manipulator UpdateLeftStickWithValue
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "UpdateLeftStickWithValue"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "UpdateLeftStickWithValue"), value);
    }

    public static event ILContext.Manipulator UpdateLeftStickWithRawValue
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "UpdateLeftStickWithRawValue"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "UpdateLeftStickWithRawValue"), value);
    }

    public static event ILContext.Manipulator CommitLeftStick
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "CommitLeftStick"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "CommitLeftStick"),
            value);
    }

    public static event ILContext.Manipulator UpdateRightStickWithValue
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "UpdateRightStickWithValue"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "UpdateRightStickWithValue"), value);
    }

    public static event ILContext.Manipulator UpdateRightStickWithRawValue
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "UpdateRightStickWithRawValue"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "UpdateRightStickWithRawValue"), value);
    }

    public static event ILContext.Manipulator CommitRightStick
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "CommitRightStick"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "CommitRightStick"),
            value);
    }

    public static event ILContext.Manipulator Update
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "Update"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "Update"), value);
    }

    public static event ILContext.Manipulator ProcessLeftStick
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "ProcessLeftStick"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "ProcessLeftStick"),
            value);
    }

    public static event ILContext.Manipulator ProcessRightStick
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "ProcessRightStick"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "ProcessRightStick"),
            value);
    }

    public static event ILContext.Manipulator ProcessDPad
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "ProcessDPad"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "ProcessDPad"),
            value);
    }

    public static event ILContext.Manipulator Commit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "Commit"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "Commit"), value);
    }

    public static event ILContext.Manipulator LastInputAfter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "LastInputAfter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "LastInputAfter"),
            value);
    }

    public static event ILContext.Manipulator RequestActivation
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "RequestActivation"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "RequestActivation"),
            value);
    }

    public static event ILContext.Manipulator Vibrate_float_float
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "Vibrate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "Vibrate"), value);
    }

    public static event ILContext.Manipulator Vibrate_float
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "Vibrate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "Vibrate"), value);
    }

    public static event ILContext.Manipulator StopVibration
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "StopVibration"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "StopVibration"),
            value);
    }

    public static event ILContext.Manipulator SetLightColor_float_float_float
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "SetLightColor"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "SetLightColor"),
            value);
    }

    public static event ILContext.Manipulator SetLightColor_Color
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "SetLightColor"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "SetLightColor"),
            value);
    }

    public static event ILContext.Manipulator SetLightFlash
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "SetLightFlash"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "SetLightFlash"),
            value);
    }

    public static event ILContext.Manipulator StopLightFlash
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "StopLightFlash"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "StopLightFlash"),
            value);
    }

    public static event ILContext.Manipulator get_IsSupportedOnThisPlatform
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_IsSupportedOnThisPlatform"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_IsSupportedOnThisPlatform"), value);
    }

    public static event ILContext.Manipulator get_IsKnown
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_IsKnown"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_IsKnown"),
            value);
    }

    public static event ILContext.Manipulator get_IsUnknown
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_IsUnknown"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_IsUnknown"),
            value);
    }

    public static event ILContext.Manipulator get_MenuIsPressed
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_MenuIsPressed"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_MenuIsPressed"),
            value);
    }

    public static event ILContext.Manipulator get_MenuWasPressed
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_MenuWasPressed"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_MenuWasPressed"), value);
    }

    public static event ILContext.Manipulator get_MenuWasReleased
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_MenuWasReleased"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_MenuWasReleased"), value);
    }

    public static event ILContext.Manipulator get_CommandIsPressed
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_CommandIsPressed"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_CommandIsPressed"), value);
    }

    public static event ILContext.Manipulator get_CommandWasPressed
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_CommandWasPressed"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_CommandWasPressed"), value);
    }

    public static event ILContext.Manipulator get_CommandWasReleased
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_CommandWasReleased"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_CommandWasReleased"), value);
    }

    public static event ILContext.Manipulator get_AnyButton
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_AnyButton"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_AnyButton"),
            value);
    }

    public static event ILContext.Manipulator get_AnyButtonIsPressed
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_AnyButtonIsPressed"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_AnyButtonIsPressed"), value);
    }

    public static event ILContext.Manipulator get_AnyButtonWasPressed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_AnyButtonWasPressed"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_AnyButtonWasPressed"), value);
    }

    public static event ILContext.Manipulator get_AnyButtonWasReleased
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_AnyButtonWasReleased"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_AnyButtonWasReleased"), value);
    }

    public static event ILContext.Manipulator get_Direction
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_Direction"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_Direction"),
            value);
    }

    public static event ILContext.Manipulator get_LeftStickUp
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_LeftStickUp"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_LeftStickUp"),
            value);
    }

    public static event ILContext.Manipulator get_LeftStickDown
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_LeftStickDown"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_LeftStickDown"),
            value);
    }

    public static event ILContext.Manipulator get_LeftStickLeft
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_LeftStickLeft"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_LeftStickLeft"),
            value);
    }

    public static event ILContext.Manipulator get_LeftStickRight
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_LeftStickRight"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_LeftStickRight"), value);
    }

    public static event ILContext.Manipulator get_RightStickUp
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_RightStickUp"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_RightStickUp"),
            value);
    }

    public static event ILContext.Manipulator get_RightStickDown
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_RightStickDown"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_RightStickDown"), value);
    }

    public static event ILContext.Manipulator get_RightStickLeft
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_RightStickLeft"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_RightStickLeft"), value);
    }

    public static event ILContext.Manipulator get_RightStickRight
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_RightStickRight"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_RightStickRight"), value);
    }

    public static event ILContext.Manipulator get_DPadUp
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_DPadUp"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_DPadUp"), value);
    }

    public static event ILContext.Manipulator get_DPadDown
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_DPadDown"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_DPadDown"),
            value);
    }

    public static event ILContext.Manipulator get_DPadLeft
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_DPadLeft"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_DPadLeft"),
            value);
    }

    public static event ILContext.Manipulator get_DPadRight
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_DPadRight"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_DPadRight"),
            value);
    }

    public static event ILContext.Manipulator get_Action1
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_Action1"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_Action1"),
            value);
    }

    public static event ILContext.Manipulator get_Action2
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_Action2"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_Action2"),
            value);
    }

    public static event ILContext.Manipulator get_Action3
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_Action3"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_Action3"),
            value);
    }

    public static event ILContext.Manipulator get_Action4
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_Action4"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_Action4"),
            value);
    }

    public static event ILContext.Manipulator get_LeftTrigger
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_LeftTrigger"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_LeftTrigger"),
            value);
    }

    public static event ILContext.Manipulator get_RightTrigger
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_RightTrigger"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_RightTrigger"),
            value);
    }

    public static event ILContext.Manipulator get_LeftBumper
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_LeftBumper"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_LeftBumper"),
            value);
    }

    public static event ILContext.Manipulator get_RightBumper
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_RightBumper"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_RightBumper"),
            value);
    }

    public static event ILContext.Manipulator get_LeftStickButton
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_LeftStickButton"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_LeftStickButton"), value);
    }

    public static event ILContext.Manipulator get_RightStickButton
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_RightStickButton"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_RightStickButton"), value);
    }

    public static event ILContext.Manipulator get_LeftStickX
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_LeftStickX"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_LeftStickX"),
            value);
    }

    public static event ILContext.Manipulator get_LeftStickY
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_LeftStickY"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_LeftStickY"),
            value);
    }

    public static event ILContext.Manipulator get_RightStickX
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_RightStickX"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_RightStickX"),
            value);
    }

    public static event ILContext.Manipulator get_RightStickY
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_RightStickY"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_RightStickY"),
            value);
    }

    public static event ILContext.Manipulator get_DPadX
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_DPadX"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_DPadX"), value);
    }

    public static event ILContext.Manipulator get_DPadY
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_DPadY"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_DPadY"), value);
    }

    public static event ILContext.Manipulator get_Command
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_Command"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_Command"),
            value);
    }

    public static event ILContext.Manipulator get_LeftCommand
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_LeftCommand"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_LeftCommand"),
            value);
    }

    public static event ILContext.Manipulator get_RightCommand
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_RightCommand"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_RightCommand"),
            value);
    }

    public static event ILContext.Manipulator ExpireControlCache
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "ExpireControlCache"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "ExpireControlCache"), value);
    }

    public static event ILContext.Manipulator get_NumUnknownAnalogs
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_NumUnknownAnalogs"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_NumUnknownAnalogs"), value);
    }

    public static event ILContext.Manipulator get_NumUnknownButtons
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_NumUnknownButtons"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "get_NumUnknownButtons"), value);
    }

    public static event ILContext.Manipulator ReadRawButtonState
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "ReadRawButtonState"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "ReadRawButtonState"), value);
    }

    public static event ILContext.Manipulator ReadRawAnalogValue
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "ReadRawAnalogValue"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "ReadRawAnalogValue"), value);
    }

    public static event ILContext.Manipulator TakeSnapshot
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "TakeSnapshot"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "TakeSnapshot"),
            value);
    }

    public static event ILContext.Manipulator GetFirstPressedAnalog
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "GetFirstPressedAnalog"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "GetFirstPressedAnalog"), value);
    }

    public static event ILContext.Manipulator GetFirstPressedButton
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDevice), "GetFirstPressedButton"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDevice), "GetFirstPressedButton"), value);
    }
}