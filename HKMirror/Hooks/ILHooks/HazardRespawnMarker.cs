namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for HazardRespawnMarker.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILHazardRespawnMarker
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.HazardRespawnMarker.Awake += value;
        remove => IL.HazardRespawnMarker.Awake -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.HazardRespawnMarker.Update += value;
        remove => IL.HazardRespawnMarker.Update -= value;
    }
}