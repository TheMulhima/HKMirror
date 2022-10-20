using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SpawnRandomObjectsOverTimeV2.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSpawnRandomObjectsOverTimeV2
{
    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SpawnRandomObjectsOverTimeV2), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SpawnRandomObjectsOverTimeV2), "OnEnter"), value);
    }

    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SpawnRandomObjectsOverTimeV2), "Reset"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SpawnRandomObjectsOverTimeV2), "Reset"), value);
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SpawnRandomObjectsOverTimeV2), "OnUpdate"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SpawnRandomObjectsOverTimeV2), "OnUpdate"), value);
    }

    public static event ILContext.Manipulator DoSpawn
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SpawnRandomObjectsOverTimeV2), "DoSpawn"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SpawnRandomObjectsOverTimeV2), "DoSpawn"), value);
    }
}