using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for OuyaEverywhereDevice.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILOuyaEverywhereDevice
{
    public static event ILContext.Manipulator get_DeviceIndex
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OuyaEverywhereDevice), "get_DeviceIndex"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OuyaEverywhereDevice), "get_DeviceIndex"), value);
    }

    public static event ILContext.Manipulator set_DeviceIndex
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OuyaEverywhereDevice), "set_DeviceIndex"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OuyaEverywhereDevice), "set_DeviceIndex"), value);
    }

    public static event ILContext.Manipulator BeforeAttach
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(OuyaEverywhereDevice), "BeforeAttach"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OuyaEverywhereDevice), "BeforeAttach"), value);
    }

    public static event ILContext.Manipulator Update
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(OuyaEverywhereDevice), "Update"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(OuyaEverywhereDevice), "Update"),
            value);
    }

    public static event ILContext.Manipulator get_IsConnected
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OuyaEverywhereDevice), "get_IsConnected"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OuyaEverywhereDevice), "get_IsConnected"), value);
    }
}