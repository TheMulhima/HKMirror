using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SecureplayerPrefsDemoClass.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSecureplayerPrefsDemoClass
{
    public static event ILContext.Manipulator get_playID
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SecureplayerPrefsDemoClass), "get_playID"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SecureplayerPrefsDemoClass), "get_playID"), value);
    }

    public static event ILContext.Manipulator set_playID
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SecureplayerPrefsDemoClass), "set_playID"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SecureplayerPrefsDemoClass), "set_playID"), value);
    }

    public static event ILContext.Manipulator get_type
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SecureplayerPrefsDemoClass), "get_type"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SecureplayerPrefsDemoClass), "get_type"), value);
    }

    public static event ILContext.Manipulator set_type
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SecureplayerPrefsDemoClass), "set_type"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SecureplayerPrefsDemoClass), "set_type"), value);
    }

    public static event ILContext.Manipulator get_incremental
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SecureplayerPrefsDemoClass), "get_incremental"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SecureplayerPrefsDemoClass), "get_incremental"), value);
    }

    public static event ILContext.Manipulator set_incremental
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SecureplayerPrefsDemoClass), "set_incremental"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SecureplayerPrefsDemoClass), "set_incremental"), value);
    }
}