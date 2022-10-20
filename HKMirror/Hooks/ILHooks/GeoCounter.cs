namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GeoCounter.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGeoCounter
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.GeoCounter.Awake += value;
        remove => IL.GeoCounter.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.GeoCounter.Start += value;
        remove => IL.GeoCounter.Start -= value;
    }

    public static event ILContext.Manipulator UpdateGeo
    {
        add => IL.GeoCounter.UpdateGeo += value;
        remove => IL.GeoCounter.UpdateGeo -= value;
    }

    public static event ILContext.Manipulator NewSceneRefresh
    {
        add => IL.GeoCounter.NewSceneRefresh += value;
        remove => IL.GeoCounter.NewSceneRefresh -= value;
    }

    public static event ILContext.Manipulator AddGeo
    {
        add => IL.GeoCounter.AddGeo += value;
        remove => IL.GeoCounter.AddGeo -= value;
    }

    public static event ILContext.Manipulator TakeGeo
    {
        add => IL.GeoCounter.TakeGeo += value;
        remove => IL.GeoCounter.TakeGeo -= value;
    }

    public static event ILContext.Manipulator ToZero
    {
        add => IL.GeoCounter.ToZero += value;
        remove => IL.GeoCounter.ToZero -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.GeoCounter.Update += value;
        remove => IL.GeoCounter.Update -= value;
    }
}