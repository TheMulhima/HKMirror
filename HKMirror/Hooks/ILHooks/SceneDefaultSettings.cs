using MonoMod.RuntimeDetour.HookGen;
using TeamCherry;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SceneDefaultSettings.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSceneDefaultSettings
{
    public static event ILContext.Manipulator OnEnable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SceneDefaultSettings), "OnEnable"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SceneDefaultSettings), "OnEnable"),
            value);
    }

    public static event ILContext.Manipulator GetMapZoneSettings
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SceneDefaultSettings), "GetMapZoneSettings"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SceneDefaultSettings), "GetMapZoneSettings"), value);
    }

    public static event ILContext.Manipulator GetCurrentMapZoneSettings
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SceneDefaultSettings), "GetCurrentMapZoneSettings"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SceneDefaultSettings), "GetCurrentMapZoneSettings"), value);
    }

    public static event ILContext.Manipulator SaveSettings
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SceneDefaultSettings), "SaveSettings"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SceneDefaultSettings), "SaveSettings"), value);
    }

    public static event ILContext.Manipulator GetCurrentSelection
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SceneDefaultSettings), "GetCurrentSelection"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SceneDefaultSettings), "GetCurrentSelection"), value);
    }
}