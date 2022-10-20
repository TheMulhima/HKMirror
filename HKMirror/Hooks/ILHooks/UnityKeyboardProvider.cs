using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for UnityKeyboardProvider.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILUnityKeyboardProvider
{
    public static event ILContext.Manipulator Setup
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityKeyboardProvider), "Setup"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityKeyboardProvider), "Setup"),
            value);
    }

    public static event ILContext.Manipulator Reset
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityKeyboardProvider), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityKeyboardProvider), "Reset"),
            value);
    }

    public static event ILContext.Manipulator Update
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityKeyboardProvider), "Update"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityKeyboardProvider), "Update"),
            value);
    }

    public static event ILContext.Manipulator AnyKeyIsPressed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnityKeyboardProvider), "AnyKeyIsPressed"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityKeyboardProvider), "AnyKeyIsPressed"), value);
    }

    public static event ILContext.Manipulator GetKeyIsPressed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnityKeyboardProvider), "GetKeyIsPressed"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityKeyboardProvider), "GetKeyIsPressed"), value);
    }

    public static event ILContext.Manipulator GetNameForKey
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnityKeyboardProvider), "GetNameForKey"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityKeyboardProvider), "GetNameForKey"), value);
    }
}