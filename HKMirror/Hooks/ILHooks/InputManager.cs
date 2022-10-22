using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for InputManager,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILInputManager
{
    public static event ILContext.Manipulator get_CommandWasPressed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_CommandWasPressed", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_CommandWasPressed", false), value);
    }

    public static event ILContext.Manipulator set_CommandWasPressed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_CommandWasPressed", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_CommandWasPressed", false), value);
    }

    public static event ILContext.Manipulator get_InvertYAxis
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_InvertYAxis", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_InvertYAxis", false), value);
    }

    public static event ILContext.Manipulator set_InvertYAxis
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_InvertYAxis", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_InvertYAxis", false), value);
    }

    public static event ILContext.Manipulator get_IsSetup
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_IsSetup", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_IsSetup", false), value);
    }

    public static event ILContext.Manipulator set_IsSetup
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_IsSetup", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_IsSetup", false), value);
    }

    public static event ILContext.Manipulator get_MouseProvider
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_MouseProvider", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_MouseProvider", false), value);
    }

    public static event ILContext.Manipulator set_MouseProvider
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_MouseProvider", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_MouseProvider", false), value);
    }

    public static event ILContext.Manipulator get_KeyboardProvider
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_KeyboardProvider", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_KeyboardProvider", false), value);
    }

    public static event ILContext.Manipulator set_KeyboardProvider
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_KeyboardProvider", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_KeyboardProvider", false), value);
    }

    public static event ILContext.Manipulator get_Platform
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_Platform", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_Platform", false), value);
    }

    public static event ILContext.Manipulator set_Platform
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_Platform", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_Platform", false), value);
    }

    public static event ILContext.Manipulator get_MenuWasPressed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_MenuWasPressed", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_MenuWasPressed", false), value);
    }

    public static event ILContext.Manipulator SetupInternal
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputManager), "SetupInternal", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "SetupInternal", false), value);
    }

    public static event ILContext.Manipulator ResetInternal
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputManager), "ResetInternal", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "ResetInternal", false), value);
    }

    public static event ILContext.Manipulator Update
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputManager), "Update", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputManager), "Update", false),
            value);
    }

    public static event ILContext.Manipulator UpdateInternal
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputManager), "UpdateInternal", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "UpdateInternal", false), value);
    }

    public static event ILContext.Manipulator Reload
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputManager), "Reload", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputManager), "Reload", false),
            value);
    }

    public static event ILContext.Manipulator AssertIsSetup
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputManager), "AssertIsSetup", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "AssertIsSetup", false), value);
    }

    public static event ILContext.Manipulator SetZeroTickOnAllControls
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "SetZeroTickOnAllControls", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "SetZeroTickOnAllControls", false), value);
    }

    public static event ILContext.Manipulator ClearInputState
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "ClearInputState", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "ClearInputState", false), value);
    }

    public static event ILContext.Manipulator OnApplicationFocus
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "OnApplicationFocus", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "OnApplicationFocus", false), value);
    }

    public static event ILContext.Manipulator OnApplicationPause
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "OnApplicationPause", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "OnApplicationPause", false), value);
    }

    public static event ILContext.Manipulator OnApplicationQuit
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "OnApplicationQuit", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "OnApplicationQuit", false), value);
    }

    public static event ILContext.Manipulator OnLevelWasLoaded
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "OnLevelWasLoaded", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "OnLevelWasLoaded", false), value);
    }

    public static event ILContext.Manipulator AddDeviceManager
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "AddDeviceManager", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "AddDeviceManager", false), value);
    }

    public static event ILContext.Manipulator UpdateCurrentTime
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "UpdateCurrentTime", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "UpdateCurrentTime", false), value);
    }

    public static event ILContext.Manipulator UpdateDeviceManagers
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "UpdateDeviceManagers", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "UpdateDeviceManagers", false), value);
    }

    public static event ILContext.Manipulator DestroyDeviceManagers
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "DestroyDeviceManagers", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "DestroyDeviceManagers", false), value);
    }

    public static event ILContext.Manipulator DestroyDevices
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputManager), "DestroyDevices", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "DestroyDevices", false), value);
    }

    public static event ILContext.Manipulator UpdateDevices
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputManager), "UpdateDevices", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "UpdateDevices", false), value);
    }

    public static event ILContext.Manipulator CommitDevices
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputManager), "CommitDevices", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "CommitDevices", false), value);
    }

    public static event ILContext.Manipulator UpdateActiveDevice
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "UpdateActiveDevice", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "UpdateActiveDevice", false), value);
    }

    public static event ILContext.Manipulator AttachDevice
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputManager), "AttachDevice", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "AttachDevice", false), value);
    }

    public static event ILContext.Manipulator DetachDevice
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputManager), "DetachDevice", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "DetachDevice", false), value);
    }

    public static event ILContext.Manipulator HideDevicesWithProfile
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "HideDevicesWithProfile", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "HideDevicesWithProfile", false), value);
    }

    public static event ILContext.Manipulator AttachPlayerActionSet
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "AttachPlayerActionSet", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "AttachPlayerActionSet", false), value);
    }

    public static event ILContext.Manipulator DetachPlayerActionSet
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "DetachPlayerActionSet", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "DetachPlayerActionSet", false), value);
    }

    public static event ILContext.Manipulator UpdatePlayerActionSets
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "UpdatePlayerActionSets", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "UpdatePlayerActionSets", false), value);
    }

    public static event ILContext.Manipulator get_AnyKeyIsPressed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_AnyKeyIsPressed", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_AnyKeyIsPressed", false), value);
    }

    public static event ILContext.Manipulator get_ActiveDevice
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_ActiveDevice", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_ActiveDevice", false), value);
    }

    public static event ILContext.Manipulator set_ActiveDevice
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_ActiveDevice", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_ActiveDevice", false), value);
    }

    public static event ILContext.Manipulator get_Enabled
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_Enabled", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_Enabled", false), value);
    }

    public static event ILContext.Manipulator set_Enabled
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_Enabled", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_Enabled", false), value);
    }

    public static event ILContext.Manipulator get_SuspendInBackground
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_SuspendInBackground", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_SuspendInBackground", false), value);
    }

    public static event ILContext.Manipulator set_SuspendInBackground
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_SuspendInBackground", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_SuspendInBackground", false), value);
    }

    public static event ILContext.Manipulator get_EnableNativeInput
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_EnableNativeInput", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_EnableNativeInput", false), value);
    }

    public static event ILContext.Manipulator set_EnableNativeInput
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_EnableNativeInput", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_EnableNativeInput", false), value);
    }

    public static event ILContext.Manipulator get_EnableXInput
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_EnableXInput", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_EnableXInput", false), value);
    }

    public static event ILContext.Manipulator set_EnableXInput
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_EnableXInput", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_EnableXInput", false), value);
    }

    public static event ILContext.Manipulator get_XInputUpdateRate
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_XInputUpdateRate", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_XInputUpdateRate", false), value);
    }

    public static event ILContext.Manipulator set_XInputUpdateRate
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_XInputUpdateRate", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_XInputUpdateRate", false), value);
    }

    public static event ILContext.Manipulator get_XInputBufferSize
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_XInputBufferSize", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_XInputBufferSize", false), value);
    }

    public static event ILContext.Manipulator set_XInputBufferSize
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_XInputBufferSize", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_XInputBufferSize", false), value);
    }

    public static event ILContext.Manipulator get_NativeInputEnableXInput
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_NativeInputEnableXInput", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_NativeInputEnableXInput", false), value);
    }

    public static event ILContext.Manipulator set_NativeInputEnableXInput
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_NativeInputEnableXInput", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_NativeInputEnableXInput", false), value);
    }

    public static event ILContext.Manipulator get_NativeInputEnableMFi
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_NativeInputEnableMFi", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_NativeInputEnableMFi", false), value);
    }

    public static event ILContext.Manipulator set_NativeInputEnableMFi
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_NativeInputEnableMFi", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_NativeInputEnableMFi", false), value);
    }

    public static event ILContext.Manipulator get_NativeInputPreventSleep
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_NativeInputPreventSleep", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_NativeInputPreventSleep", false), value);
    }

    public static event ILContext.Manipulator set_NativeInputPreventSleep
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_NativeInputPreventSleep", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_NativeInputPreventSleep", false), value);
    }

    public static event ILContext.Manipulator get_NativeInputUpdateRate
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_NativeInputUpdateRate", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_NativeInputUpdateRate", false), value);
    }

    public static event ILContext.Manipulator set_NativeInputUpdateRate
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_NativeInputUpdateRate", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_NativeInputUpdateRate", false), value);
    }

    public static event ILContext.Manipulator get_EnableICade
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_EnableICade", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_EnableICade", false), value);
    }

    public static event ILContext.Manipulator set_EnableICade
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_EnableICade", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "set_EnableICade", false), value);
    }

    public static event ILContext.Manipulator get_UnityVersion
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_UnityVersion", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_UnityVersion", false), value);
    }

    public static event ILContext.Manipulator get_CurrentTick
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_CurrentTick", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputManager), "get_CurrentTick", false), value);
    }
}