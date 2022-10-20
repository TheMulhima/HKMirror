using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MouseBindingSource.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMouseBindingSource
{
    public static event ILContext.Manipulator get_Control
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "get_Control"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "get_Control"), value);
    }

    public static event ILContext.Manipulator set_Control
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "set_Control"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "set_Control"), value);
    }

    public static event ILContext.Manipulator ButtonIsPressed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "ButtonIsPressed", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "ButtonIsPressed", false), value);
    }

    public static event ILContext.Manipulator NegativeScrollWheelIsActive
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "NegativeScrollWheelIsActive", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "NegativeScrollWheelIsActive", false), value);
    }

    public static event ILContext.Manipulator PositiveScrollWheelIsActive
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "PositiveScrollWheelIsActive", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "PositiveScrollWheelIsActive", false), value);
    }

    public static event ILContext.Manipulator GetValue_Mouse
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "GetValue", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "GetValue", false), value);
    }

    public static event ILContext.Manipulator GetValue_InputDevice
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "GetValue"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "GetValue"),
            value);
    }

    public static event ILContext.Manipulator GetState
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "GetState"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "GetState"),
            value);
    }

    public static event ILContext.Manipulator get_Name
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "get_Name"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "get_Name"),
            value);
    }

    public static event ILContext.Manipulator get_DeviceName
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "get_DeviceName"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "get_DeviceName"), value);
    }

    public static event ILContext.Manipulator get_DeviceClass
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "get_DeviceClass"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "get_DeviceClass"), value);
    }

    public static event ILContext.Manipulator get_DeviceStyle
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "get_DeviceStyle"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "get_DeviceStyle"), value);
    }

    public static event ILContext.Manipulator Equals_BindingSource
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "Equals"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "Equals"),
            value);
    }

    public static event ILContext.Manipulator Equals_Object
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "Equals"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "Equals"),
            value);
    }

    public static event ILContext.Manipulator GetHashCode
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "GetHashCode"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "GetHashCode"), value);
    }

    public static event ILContext.Manipulator get_BindingSourceType
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "get_BindingSourceType"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "get_BindingSourceType"), value);
    }

    public static event ILContext.Manipulator Save
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "Save"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "Save"),
            value);
    }

    public static event ILContext.Manipulator Load
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "Load"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MouseBindingSource), "Load"),
            value);
    }
}