namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MapMarkerButton.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMapMarkerButton
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.MapMarkerButton.Awake += value;
        remove => IL.MapMarkerButton.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.MapMarkerButton.OnEnable += value;
        remove => IL.MapMarkerButton.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.MapMarkerButton.Update += value;
        remove => IL.MapMarkerButton.Update -= value;
    }

    public static event ILContext.Manipulator DoDisable
    {
        add => IL.MapMarkerButton.DoDisable += value;
        remove => IL.MapMarkerButton.DoDisable -= value;
    }
}