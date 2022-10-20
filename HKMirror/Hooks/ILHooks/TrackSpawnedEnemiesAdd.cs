namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TrackSpawnedEnemiesAdd.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTrackSpawnedEnemiesAdd
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.TrackSpawnedEnemiesAdd.Reset += value;
        remove => IL.TrackSpawnedEnemiesAdd.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.TrackSpawnedEnemiesAdd.OnEnter += value;
        remove => IL.TrackSpawnedEnemiesAdd.OnEnter -= value;
    }

    public static event ILContext.Manipulator AddTracked
    {
        add => IL.TrackSpawnedEnemiesAdd.AddTracked += value;
        remove => IL.TrackSpawnedEnemiesAdd.AddTracked -= value;
    }
}