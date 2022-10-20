using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for KeyBindingSource.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILKeyBindingSource
{
    public static event ILContext.Manipulator get_Control
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KeyBindingSource), "get_Control"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(KeyBindingSource), "get_Control"),
            value);
    }

    public static event ILContext.Manipulator set_Control
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KeyBindingSource), "set_Control"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(KeyBindingSource), "set_Control"),
            value);
    }

    public static event ILContext.Manipulator GetValue
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KeyBindingSource), "GetValue"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(KeyBindingSource), "GetValue"),
            value);
    }

    public static event ILContext.Manipulator GetState
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KeyBindingSource), "GetState"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(KeyBindingSource), "GetState"),
            value);
    }

    public static event ILContext.Manipulator get_Name
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KeyBindingSource), "get_Name"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(KeyBindingSource), "get_Name"),
            value);
    }

    public static event ILContext.Manipulator get_DeviceName
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KeyBindingSource), "get_DeviceName"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(KeyBindingSource), "get_DeviceName"), value);
    }

    public static event ILContext.Manipulator get_DeviceClass
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KeyBindingSource), "get_DeviceClass"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(KeyBindingSource), "get_DeviceClass"), value);
    }

    public static event ILContext.Manipulator get_DeviceStyle
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KeyBindingSource), "get_DeviceStyle"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(KeyBindingSource), "get_DeviceStyle"), value);
    }

    public static event ILContext.Manipulator Equals_BindingSource
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KeyBindingSource), "Equals"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(KeyBindingSource), "Equals"),
            value);
    }

    public static event ILContext.Manipulator Equals_Object
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KeyBindingSource), "Equals"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(KeyBindingSource), "Equals"),
            value);
    }

    public static event ILContext.Manipulator get_BindingSourceType
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(KeyBindingSource), "get_BindingSourceType"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(KeyBindingSource), "get_BindingSourceType"), value);
    }

    public static event ILContext.Manipulator Load
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KeyBindingSource), "Load"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(KeyBindingSource), "Load"), value);
    }

    public static event ILContext.Manipulator Save
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(KeyBindingSource), "Save"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(KeyBindingSource), "Save"), value);
    }
}