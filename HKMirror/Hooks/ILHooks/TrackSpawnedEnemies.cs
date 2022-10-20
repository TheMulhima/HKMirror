using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TrackSpawnedEnemies.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTrackSpawnedEnemies
{
    public static event ILContext.Manipulator get_TotalTracked
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TrackSpawnedEnemies), "get_TotalTracked"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TrackSpawnedEnemies), "get_TotalTracked"), value);
    }

    public static event ILContext.Manipulator get_TotalAlive
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TrackSpawnedEnemies), "get_TotalAlive"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TrackSpawnedEnemies), "get_TotalAlive"), value);
    }

    public static event ILContext.Manipulator Add
    {
        add => IL.TrackSpawnedEnemies.Add += value;
        remove => IL.TrackSpawnedEnemies.Add -= value;
    }
}