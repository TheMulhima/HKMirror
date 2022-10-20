using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for DeviceBindingSource.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDeviceBindingSource
{
    public static event ILContext.Manipulator get_Control
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "get_Control"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "get_Control"), value);
    }

    public static event ILContext.Manipulator set_Control
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "set_Control"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "set_Control"), value);
    }

    public static event ILContext.Manipulator GetValue
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "GetValue"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "GetValue"),
            value);
    }

    public static event ILContext.Manipulator GetState
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "GetState"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "GetState"),
            value);
    }

    public static event ILContext.Manipulator get_Name
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "get_Name"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "get_Name"),
            value);
    }

    public static event ILContext.Manipulator get_DeviceName
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "get_DeviceName"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "get_DeviceName"), value);
    }

    public static event ILContext.Manipulator get_DeviceClass
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "get_DeviceClass"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "get_DeviceClass"), value);
    }

    public static event ILContext.Manipulator get_DeviceStyle
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "get_DeviceStyle"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "get_DeviceStyle"), value);
    }

    public static event ILContext.Manipulator Equals_BindingSource
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "Equals"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "Equals"),
            value);
    }

    public static event ILContext.Manipulator Equals_Object
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "Equals"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "Equals"),
            value);
    }

    public static event ILContext.Manipulator GetHashCode
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "GetHashCode"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "GetHashCode"), value);
    }

    public static event ILContext.Manipulator get_BindingSourceType
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "get_BindingSourceType"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "get_BindingSourceType"), value);
    }

    public static event ILContext.Manipulator Save
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "Save"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "Save"),
            value);
    }

    public static event ILContext.Manipulator Load
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "Load"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "Load"),
            value);
    }

    public static event ILContext.Manipulator get_IsValid
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "get_IsValid"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(DeviceBindingSource), "get_IsValid"), value);
    }
}