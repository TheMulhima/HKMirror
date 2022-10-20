using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for InControlManager.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILInControlManager
{
    public static event ILContext.Manipulator OnEnable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnEnable"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnEnable"),
            value);
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnDisable"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnDisable"),
            value);
    }

    public static event ILContext.Manipulator Update
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControlManager), "Update"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControlManager), "Update"),
            value);
    }

    public static event ILContext.Manipulator FixedUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControlManager), "FixedUpdate"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControlManager), "FixedUpdate"),
            value);
    }

    public static event ILContext.Manipulator OnApplicationFocus
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnApplicationFocus"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnApplicationFocus"), value);
    }

    public static event ILContext.Manipulator OnApplicationPause
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnApplicationPause"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnApplicationPause"), value);
    }

    public static event ILContext.Manipulator OnApplicationQuit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnApplicationQuit"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnApplicationQuit"), value);
    }

    public static event ILContext.Manipulator OnSceneWasLoaded
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnSceneWasLoaded"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlManager), "OnSceneWasLoaded"), value);
    }

    public static event ILContext.Manipulator LogMessage
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControlManager), "LogMessage", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlManager), "LogMessage", false), value);
    }
}