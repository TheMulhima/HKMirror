using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PlayerOneAxisAction.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPlayerOneAxisAction
{
    public static event ILContext.Manipulator get_UserData
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerOneAxisAction), "get_UserData"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerOneAxisAction), "get_UserData"), value);
    }

    public static event ILContext.Manipulator set_UserData
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerOneAxisAction), "set_UserData"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerOneAxisAction), "set_UserData"), value);
    }

    public static event ILContext.Manipulator Update
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(PlayerOneAxisAction), "Update"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(PlayerOneAxisAction), "Update"),
            value);
    }

    public static event ILContext.Manipulator ProcessActionUpdate
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerOneAxisAction), "ProcessActionUpdate"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerOneAxisAction), "ProcessActionUpdate"), value);
    }

    public static event ILContext.Manipulator get_LowerDeadZone
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerOneAxisAction), "get_LowerDeadZone"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerOneAxisAction), "get_LowerDeadZone"), value);
    }

    public static event ILContext.Manipulator set_LowerDeadZone
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerOneAxisAction), "set_LowerDeadZone"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerOneAxisAction), "set_LowerDeadZone"), value);
    }

    public static event ILContext.Manipulator get_UpperDeadZone
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerOneAxisAction), "get_UpperDeadZone"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerOneAxisAction), "get_UpperDeadZone"), value);
    }

    public static event ILContext.Manipulator set_UpperDeadZone
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerOneAxisAction), "set_UpperDeadZone"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayerOneAxisAction), "set_UpperDeadZone"), value);
    }
}