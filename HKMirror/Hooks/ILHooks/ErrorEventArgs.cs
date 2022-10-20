using Microsoft.Xbox;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ErrorEventArgs.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILErrorEventArgs
{
    public static event ILContext.Manipulator get_ErrorCode
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ErrorEventArgs), "get_ErrorCode"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ErrorEventArgs), "get_ErrorCode"),
            value);
    }

    public static event ILContext.Manipulator set_ErrorCode
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ErrorEventArgs), "set_ErrorCode"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ErrorEventArgs), "set_ErrorCode"),
            value);
    }

    public static event ILContext.Manipulator get_ErrorMessage
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ErrorEventArgs), "get_ErrorMessage"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ErrorEventArgs), "get_ErrorMessage"), value);
    }

    public static event ILContext.Manipulator set_ErrorMessage
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ErrorEventArgs), "set_ErrorMessage"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ErrorEventArgs), "set_ErrorMessage"), value);
    }
}