using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.ILHooks;
/// <summary>
/// Contains all correct IL Hooks for SceneLoad,
/// Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
/// Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSceneLoad
{
public static event ILContext.Manipulator get_TargetSceneName
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SceneLoad), "get_TargetSceneName", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SceneLoad), "get_TargetSceneName", true), value);
}
public static event ILContext.Manipulator get_IsFetchAllowed
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SceneLoad), "get_IsFetchAllowed", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SceneLoad), "get_IsFetchAllowed", true), value);
}
public static event ILContext.Manipulator set_IsFetchAllowed
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SceneLoad), "set_IsFetchAllowed", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SceneLoad), "set_IsFetchAllowed", true), value);
}
public static event ILContext.Manipulator get_IsActivationAllowed
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SceneLoad), "get_IsActivationAllowed", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SceneLoad), "get_IsActivationAllowed", true), value);
}
public static event ILContext.Manipulator set_IsActivationAllowed
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SceneLoad), "set_IsActivationAllowed", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SceneLoad), "set_IsActivationAllowed", true), value);
}
public static event ILContext.Manipulator get_IsUnloadAssetsRequired
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SceneLoad), "get_IsUnloadAssetsRequired", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SceneLoad), "get_IsUnloadAssetsRequired", true), value);
}
public static event ILContext.Manipulator set_IsUnloadAssetsRequired
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SceneLoad), "set_IsUnloadAssetsRequired", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SceneLoad), "set_IsUnloadAssetsRequired", true), value);
}
public static event ILContext.Manipulator get_IsGarbageCollectRequired
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SceneLoad), "get_IsGarbageCollectRequired", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SceneLoad), "get_IsGarbageCollectRequired", true), value);
}
public static event ILContext.Manipulator set_IsGarbageCollectRequired
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SceneLoad), "set_IsGarbageCollectRequired", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SceneLoad), "set_IsGarbageCollectRequired", true), value);
}
public static event ILContext.Manipulator get_IsFinished
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SceneLoad), "get_IsFinished", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SceneLoad), "get_IsFinished", true), value);
}
public static event ILContext.Manipulator set_IsFinished
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SceneLoad), "set_IsFinished", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SceneLoad), "set_IsFinished", true), value);
}
public static event ILContext.Manipulator get_BeginTime
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SceneLoad), "get_BeginTime", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SceneLoad), "get_BeginTime", true), value);
}
public static event ILContext.Manipulator RecordBeginTime
{
add => IL.SceneLoad.RecordBeginTime += value;
remove => IL.SceneLoad.RecordBeginTime -= value;
}
public static event ILContext.Manipulator RecordEndTime
{
add => IL.SceneLoad.RecordEndTime += value;
remove => IL.SceneLoad.RecordEndTime -= value;
}
public static event ILContext.Manipulator GetDuration
{
add => IL.SceneLoad.GetDuration += value;
remove => IL.SceneLoad.GetDuration -= value;
}
public static event ILContext.Manipulator Begin
{
add => IL.SceneLoad.Begin += value;
remove => IL.SceneLoad.Begin -= value;
}
public static event ILContext.Manipulator BeginRoutine
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SceneLoad), "BeginRoutine", true).GetStateMachineTarget(), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SceneLoad), "BeginRoutine", true).GetStateMachineTarget(), value);
}
}
