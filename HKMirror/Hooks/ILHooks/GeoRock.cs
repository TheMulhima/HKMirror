namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GeoRock.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGeoRock
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.GeoRock.OnEnable += value;
        remove => IL.GeoRock.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.GeoRock.OnDisable += value;
        remove => IL.GeoRock.OnDisable -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.GeoRock.Start += value;
        remove => IL.GeoRock.Start -= value;
    }

    public static event ILContext.Manipulator LevelActivated
    {
        add => IL.GeoRock.LevelActivated += value;
        remove => IL.GeoRock.LevelActivated -= value;
    }

    public static event ILContext.Manipulator SaveState
    {
        add => IL.GeoRock.SaveState += value;
        remove => IL.GeoRock.SaveState -= value;
    }

    public static event ILContext.Manipulator SetMyID
    {
        add => IL.GeoRock.SetMyID += value;
        remove => IL.GeoRock.SetMyID -= value;
    }

    public static event ILContext.Manipulator UpdateHitsLeftFromFSM
    {
        add => IL.GeoRock.UpdateHitsLeftFromFSM += value;
        remove => IL.GeoRock.UpdateHitsLeftFromFSM -= value;
    }
}