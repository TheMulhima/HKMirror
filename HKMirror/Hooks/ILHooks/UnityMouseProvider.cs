using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for UnityMouseProvider.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILUnityMouseProvider
{
    public static event ILContext.Manipulator Setup
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityMouseProvider), "Setup"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityMouseProvider), "Setup"),
            value);
    }

    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityMouseProvider), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityMouseProvider), "Reset"),
            value);
    }

    public static event ILContext.Manipulator Update
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityMouseProvider), "Update"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityMouseProvider), "Update"),
            value);
    }

    public static event ILContext.Manipulator SafeGetMouseButton
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnityMouseProvider), "SafeGetMouseButton", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityMouseProvider), "SafeGetMouseButton", false), value);
    }

    public static event ILContext.Manipulator ClearState
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityMouseProvider), "ClearState"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityMouseProvider), "ClearState"),
            value);
    }

    public static event ILContext.Manipulator GetPosition
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityMouseProvider), "GetPosition"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityMouseProvider), "GetPosition"), value);
    }

    public static event ILContext.Manipulator GetDeltaX
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityMouseProvider), "GetDeltaX"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityMouseProvider), "GetDeltaX"),
            value);
    }

    public static event ILContext.Manipulator GetDeltaY
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityMouseProvider), "GetDeltaY"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityMouseProvider), "GetDeltaY"),
            value);
    }

    public static event ILContext.Manipulator GetDeltaScroll
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityMouseProvider), "GetDeltaScroll"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityMouseProvider), "GetDeltaScroll"), value);
    }

    public static event ILContext.Manipulator GetButtonIsPressed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnityMouseProvider), "GetButtonIsPressed"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityMouseProvider), "GetButtonIsPressed"), value);
    }

    public static event ILContext.Manipulator GetButtonWasPressed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnityMouseProvider), "GetButtonWasPressed"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityMouseProvider), "GetButtonWasPressed"), value);
    }

    public static event ILContext.Manipulator GetButtonWasReleased
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UnityMouseProvider), "GetButtonWasReleased"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityMouseProvider), "GetButtonWasReleased"), value);
    }

    public static event ILContext.Manipulator HasMousePresent
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityMouseProvider), "HasMousePresent"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UnityMouseProvider), "HasMousePresent"), value);
    }
}