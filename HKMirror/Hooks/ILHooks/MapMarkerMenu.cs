namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MapMarkerMenu.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMapMarkerMenu
{
    public static event ILContext.Manipulator Update
    {
        add => IL.MapMarkerMenu.Update += value;
        remove => IL.MapMarkerMenu.Update -= value;
    }

    public static event ILContext.Manipulator Open
    {
        add => IL.MapMarkerMenu.Open += value;
        remove => IL.MapMarkerMenu.Open -= value;
    }

    public static event ILContext.Manipulator Close
    {
        add => IL.MapMarkerMenu.Close += value;
        remove => IL.MapMarkerMenu.Close -= value;
    }

    public static event ILContext.Manipulator StartMarkerPlacement
    {
        add => IL.MapMarkerMenu.StartMarkerPlacement += value;
        remove => IL.MapMarkerMenu.StartMarkerPlacement -= value;
    }

    public static event ILContext.Manipulator PanMap
    {
        add => IL.MapMarkerMenu.PanMap += value;
        remove => IL.MapMarkerMenu.PanMap -= value;
    }

    public static event ILContext.Manipulator MarkerSelect
    {
        add => IL.MapMarkerMenu.MarkerSelect += value;
        remove => IL.MapMarkerMenu.MarkerSelect -= value;
    }

    public static event ILContext.Manipulator PlaceMarker
    {
        add => IL.MapMarkerMenu.PlaceMarker += value;
        remove => IL.MapMarkerMenu.PlaceMarker -= value;
    }

    public static event ILContext.Manipulator RemoveMarker
    {
        add => IL.MapMarkerMenu.RemoveMarker += value;
        remove => IL.MapMarkerMenu.RemoveMarker -= value;
    }

    public static event ILContext.Manipulator MarkerSelectLeft
    {
        add => IL.MapMarkerMenu.MarkerSelectLeft += value;
        remove => IL.MapMarkerMenu.MarkerSelectLeft -= value;
    }

    public static event ILContext.Manipulator MarkerSelectRight
    {
        add => IL.MapMarkerMenu.MarkerSelectRight += value;
        remove => IL.MapMarkerMenu.MarkerSelectRight -= value;
    }

    public static event ILContext.Manipulator UpdateAmounts
    {
        add => IL.MapMarkerMenu.UpdateAmounts += value;
        remove => IL.MapMarkerMenu.UpdateAmounts -= value;
    }

    public static event ILContext.Manipulator AddToCollidingList
    {
        add => IL.MapMarkerMenu.AddToCollidingList += value;
        remove => IL.MapMarkerMenu.AddToCollidingList -= value;
    }

    public static event ILContext.Manipulator RemoveFromCollidingList
    {
        add => IL.MapMarkerMenu.RemoveFromCollidingList += value;
        remove => IL.MapMarkerMenu.RemoveFromCollidingList -= value;
    }

    public static event ILContext.Manipulator IsColliding
    {
        add => IL.MapMarkerMenu.IsColliding += value;
        remove => IL.MapMarkerMenu.IsColliding -= value;
    }

    public static event ILContext.Manipulator IsNotColliding
    {
        add => IL.MapMarkerMenu.IsNotColliding += value;
        remove => IL.MapMarkerMenu.IsNotColliding -= value;
    }
}