using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for InputDeviceProfile.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILInputDeviceProfile
{
    public static event ILContext.Manipulator get_ProfileType
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_ProfileType"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_ProfileType"), value);
    }

    public static event ILContext.Manipulator set_ProfileType
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_ProfileType"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_ProfileType"), value);
    }

    public static event ILContext.Manipulator get_DeviceName
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_DeviceName"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_DeviceName"), value);
    }

    public static event ILContext.Manipulator set_DeviceName
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_DeviceName"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_DeviceName"), value);
    }

    public static event ILContext.Manipulator get_DeviceNotes
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_DeviceNotes"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_DeviceNotes"), value);
    }

    public static event ILContext.Manipulator set_DeviceNotes
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_DeviceNotes"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_DeviceNotes"), value);
    }

    public static event ILContext.Manipulator get_DeviceClass
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_DeviceClass"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_DeviceClass"), value);
    }

    public static event ILContext.Manipulator set_DeviceClass
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_DeviceClass"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_DeviceClass"), value);
    }

    public static event ILContext.Manipulator get_DeviceStyle
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_DeviceStyle"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_DeviceStyle"), value);
    }

    public static event ILContext.Manipulator set_DeviceStyle
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_DeviceStyle"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_DeviceStyle"), value);
    }

    public static event ILContext.Manipulator get_Sensitivity
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_Sensitivity"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_Sensitivity"), value);
    }

    public static event ILContext.Manipulator set_Sensitivity
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_Sensitivity"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_Sensitivity"), value);
    }

    public static event ILContext.Manipulator get_LowerDeadZone
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_LowerDeadZone"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_LowerDeadZone"), value);
    }

    public static event ILContext.Manipulator set_LowerDeadZone
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_LowerDeadZone"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_LowerDeadZone"), value);
    }

    public static event ILContext.Manipulator get_UpperDeadZone
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_UpperDeadZone"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_UpperDeadZone"), value);
    }

    public static event ILContext.Manipulator set_UpperDeadZone
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_UpperDeadZone"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_UpperDeadZone"), value);
    }

    public static event ILContext.Manipulator get_AnalogMappings
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_AnalogMappings"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_AnalogMappings"), value);
    }

    public static event ILContext.Manipulator set_AnalogMappings
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_AnalogMappings"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_AnalogMappings"), value);
    }

    public static event ILContext.Manipulator get_ButtonMappings
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_ButtonMappings"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_ButtonMappings"), value);
    }

    public static event ILContext.Manipulator set_ButtonMappings
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_ButtonMappings"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_ButtonMappings"), value);
    }

    public static event ILContext.Manipulator get_IncludePlatforms
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_IncludePlatforms"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_IncludePlatforms"), value);
    }

    public static event ILContext.Manipulator set_IncludePlatforms
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_IncludePlatforms"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_IncludePlatforms"), value);
    }

    public static event ILContext.Manipulator get_ExcludePlatforms
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_ExcludePlatforms"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_ExcludePlatforms"), value);
    }

    public static event ILContext.Manipulator set_ExcludePlatforms
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_ExcludePlatforms"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_ExcludePlatforms"), value);
    }

    public static event ILContext.Manipulator get_MinSystemBuildNumber
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_MinSystemBuildNumber"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_MinSystemBuildNumber"), value);
    }

    public static event ILContext.Manipulator set_MinSystemBuildNumber
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_MinSystemBuildNumber"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_MinSystemBuildNumber"), value);
    }

    public static event ILContext.Manipulator get_MaxSystemBuildNumber
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_MaxSystemBuildNumber"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_MaxSystemBuildNumber"), value);
    }

    public static event ILContext.Manipulator set_MaxSystemBuildNumber
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_MaxSystemBuildNumber"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_MaxSystemBuildNumber"), value);
    }

    public static event ILContext.Manipulator get_MinUnityVersion
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_MinUnityVersion"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_MinUnityVersion"), value);
    }

    public static event ILContext.Manipulator set_MinUnityVersion
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_MinUnityVersion"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_MinUnityVersion"), value);
    }

    public static event ILContext.Manipulator get_MaxUnityVersion
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_MaxUnityVersion"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_MaxUnityVersion"), value);
    }

    public static event ILContext.Manipulator set_MaxUnityVersion
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_MaxUnityVersion"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_MaxUnityVersion"), value);
    }

    public static event ILContext.Manipulator get_Matchers
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_Matchers"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_Matchers"), value);
    }

    public static event ILContext.Manipulator set_Matchers
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_Matchers"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_Matchers"), value);
    }

    public static event ILContext.Manipulator get_LastResortMatchers
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_LastResortMatchers"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_LastResortMatchers"), value);
    }

    public static event ILContext.Manipulator set_LastResortMatchers
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_LastResortMatchers"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "set_LastResortMatchers"), value);
    }

    public static event ILContext.Manipulator CreateInstanceOfType_Type
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "CreateInstanceOfType", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "CreateInstanceOfType", false), value);
    }

    public static event ILContext.Manipulator CreateInstanceOfType_string
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "CreateInstanceOfType", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "CreateInstanceOfType", false), value);
    }

    public static event ILContext.Manipulator Define
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "Define"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "Define"),
            value);
    }

    public static event ILContext.Manipulator Matches_InputDeviceInfo
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "Matches"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "Matches"),
            value);
    }

    public static event ILContext.Manipulator LastResortMatches
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "LastResortMatches"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "LastResortMatches"), value);
    }

    public static event ILContext.Manipulator Matches_InputDeviceInfo_Array
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "Matches"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "Matches"),
            value);
    }

    public static event ILContext.Manipulator get_IsSupportedOnThisPlatform
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_IsSupportedOnThisPlatform"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_IsSupportedOnThisPlatform"), value);
    }

    public static event ILContext.Manipulator Hide
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "Hide", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "Hide", false), value);
    }

    public static event ILContext.Manipulator get_IsHidden
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_IsHidden"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_IsHidden"), value);
    }

    public static event ILContext.Manipulator get_IsNotHidden
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_IsNotHidden"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_IsNotHidden"), value);
    }

    public static event ILContext.Manipulator get_AnalogCount
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_AnalogCount"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_AnalogCount"), value);
    }

    public static event ILContext.Manipulator get_ButtonCount
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_ButtonCount"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "get_ButtonCount"), value);
    }

    public static event ILContext.Manipulator Button
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "Button", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "Button", false), value);
    }

    public static event ILContext.Manipulator Analog
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "Analog", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "Analog", false), value);
    }

    public static event ILContext.Manipulator LeftStickLeftMapping
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "LeftStickLeftMapping", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "LeftStickLeftMapping", false), value);
    }

    public static event ILContext.Manipulator LeftStickRightMapping
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "LeftStickRightMapping", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "LeftStickRightMapping", false), value);
    }

    public static event ILContext.Manipulator LeftStickUpMapping
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "LeftStickUpMapping", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "LeftStickUpMapping", false), value);
    }

    public static event ILContext.Manipulator LeftStickDownMapping
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "LeftStickDownMapping", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "LeftStickDownMapping", false), value);
    }

    public static event ILContext.Manipulator LeftStickUpMapping2
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "LeftStickUpMapping2", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "LeftStickUpMapping2", false), value);
    }

    public static event ILContext.Manipulator LeftStickDownMapping2
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "LeftStickDownMapping2", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "LeftStickDownMapping2", false), value);
    }

    public static event ILContext.Manipulator RightStickLeftMapping
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "RightStickLeftMapping", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "RightStickLeftMapping", false), value);
    }

    public static event ILContext.Manipulator RightStickRightMapping
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "RightStickRightMapping", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "RightStickRightMapping", false), value);
    }

    public static event ILContext.Manipulator RightStickUpMapping
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "RightStickUpMapping", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "RightStickUpMapping", false), value);
    }

    public static event ILContext.Manipulator RightStickDownMapping
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "RightStickDownMapping", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "RightStickDownMapping", false), value);
    }

    public static event ILContext.Manipulator RightStickUpMapping2
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "RightStickUpMapping2", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "RightStickUpMapping2", false), value);
    }

    public static event ILContext.Manipulator RightStickDownMapping2
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "RightStickDownMapping2", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "RightStickDownMapping2", false), value);
    }

    public static event ILContext.Manipulator LeftTriggerMapping
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "LeftTriggerMapping", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "LeftTriggerMapping", false), value);
    }

    public static event ILContext.Manipulator RightTriggerMapping
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "RightTriggerMapping", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "RightTriggerMapping", false), value);
    }

    public static event ILContext.Manipulator DPadLeftMapping
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "DPadLeftMapping", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "DPadLeftMapping", false), value);
    }

    public static event ILContext.Manipulator DPadRightMapping
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "DPadRightMapping", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "DPadRightMapping", false), value);
    }

    public static event ILContext.Manipulator DPadUpMapping
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "DPadUpMapping", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "DPadUpMapping", false), value);
    }

    public static event ILContext.Manipulator DPadDownMapping
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "DPadDownMapping", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "DPadDownMapping", false), value);
    }

    public static event ILContext.Manipulator DPadUpMapping2
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "DPadUpMapping2", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "DPadUpMapping2", false), value);
    }

    public static event ILContext.Manipulator DPadDownMapping2
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "DPadDownMapping2", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputDeviceProfile), "DPadDownMapping2", false), value);
    }
}