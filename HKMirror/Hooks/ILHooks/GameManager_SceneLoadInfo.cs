using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.ILHooks;
/// <summary>
/// Contains all correct IL Hooks for GameManager_SceneLoadInfo,
/// Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
/// Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGameManager_SceneLoadInfo
{
public static event ILContext.Manipulator NotifyFetchComplete
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager.SceneLoadInfo), "NotifyFetchComplete", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameManager.SceneLoadInfo), "NotifyFetchComplete", true), value);
}
public static event ILContext.Manipulator IsReadyToActivate
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager.SceneLoadInfo), "IsReadyToActivate", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameManager.SceneLoadInfo), "IsReadyToActivate", true), value);
}
public static event ILContext.Manipulator NotifyFinished
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameManager.SceneLoadInfo), "NotifyFinished", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GameManager.SceneLoadInfo), "NotifyFinished", true), value);
}
}
