namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GameMap.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGameMap
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.GameMap.OnEnable += value;
        remove => IL.GameMap.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.GameMap.OnDisable += value;
        remove => IL.GameMap.OnDisable -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.GameMap.Start += value;
        remove => IL.GameMap.Start -= value;
    }

    public static event ILContext.Manipulator LevelReady
    {
        add => IL.GameMap.LevelReady += value;
        remove => IL.GameMap.LevelReady -= value;
    }

    public static event ILContext.Manipulator OnLevelWasLoaded
    {
        add => IL.GameMap.OnLevelWasLoaded += value;
        remove => IL.GameMap.OnLevelWasLoaded -= value;
    }

    public static event ILContext.Manipulator SetCompassPoint
    {
        add => IL.GameMap.SetCompassPoint += value;
        remove => IL.GameMap.SetCompassPoint -= value;
    }

    public static event ILContext.Manipulator GetDoorValues
    {
        add => IL.GameMap.GetDoorValues += value;
        remove => IL.GameMap.GetDoorValues -= value;
    }

    public static event ILContext.Manipulator SetupMap
    {
        add => IL.GameMap.SetupMap += value;
        remove => IL.GameMap.SetupMap -= value;
    }

    public static event ILContext.Manipulator GetTilemapDimensions
    {
        add => IL.GameMap.GetTilemapDimensions += value;
        remove => IL.GameMap.GetTilemapDimensions -= value;
    }

    public static event ILContext.Manipulator WorldMap
    {
        add => IL.GameMap.WorldMap += value;
        remove => IL.GameMap.WorldMap -= value;
    }

    public static event ILContext.Manipulator QuickMapAncientBasin
    {
        add => IL.GameMap.QuickMapAncientBasin += value;
        remove => IL.GameMap.QuickMapAncientBasin -= value;
    }

    public static event ILContext.Manipulator QuickMapCity
    {
        add => IL.GameMap.QuickMapCity += value;
        remove => IL.GameMap.QuickMapCity -= value;
    }

    public static event ILContext.Manipulator QuickMapCliffs
    {
        add => IL.GameMap.QuickMapCliffs += value;
        remove => IL.GameMap.QuickMapCliffs -= value;
    }

    public static event ILContext.Manipulator QuickMapCrossroads
    {
        add => IL.GameMap.QuickMapCrossroads += value;
        remove => IL.GameMap.QuickMapCrossroads -= value;
    }

    public static event ILContext.Manipulator QuickMapCrystalPeak
    {
        add => IL.GameMap.QuickMapCrystalPeak += value;
        remove => IL.GameMap.QuickMapCrystalPeak -= value;
    }

    public static event ILContext.Manipulator QuickMapDeepnest
    {
        add => IL.GameMap.QuickMapDeepnest += value;
        remove => IL.GameMap.QuickMapDeepnest -= value;
    }

    public static event ILContext.Manipulator QuickMapFogCanyon
    {
        add => IL.GameMap.QuickMapFogCanyon += value;
        remove => IL.GameMap.QuickMapFogCanyon -= value;
    }

    public static event ILContext.Manipulator QuickMapFungalWastes
    {
        add => IL.GameMap.QuickMapFungalWastes += value;
        remove => IL.GameMap.QuickMapFungalWastes -= value;
    }

    public static event ILContext.Manipulator QuickMapGreenpath
    {
        add => IL.GameMap.QuickMapGreenpath += value;
        remove => IL.GameMap.QuickMapGreenpath -= value;
    }

    public static event ILContext.Manipulator QuickMapKingdomsEdge
    {
        add => IL.GameMap.QuickMapKingdomsEdge += value;
        remove => IL.GameMap.QuickMapKingdomsEdge -= value;
    }

    public static event ILContext.Manipulator QuickMapQueensGardens
    {
        add => IL.GameMap.QuickMapQueensGardens += value;
        remove => IL.GameMap.QuickMapQueensGardens -= value;
    }

    public static event ILContext.Manipulator QuickMapRestingGrounds
    {
        add => IL.GameMap.QuickMapRestingGrounds += value;
        remove => IL.GameMap.QuickMapRestingGrounds -= value;
    }

    public static event ILContext.Manipulator QuickMapDirtmouth
    {
        add => IL.GameMap.QuickMapDirtmouth += value;
        remove => IL.GameMap.QuickMapDirtmouth -= value;
    }

    public static event ILContext.Manipulator QuickMapWaterways
    {
        add => IL.GameMap.QuickMapWaterways += value;
        remove => IL.GameMap.QuickMapWaterways -= value;
    }

    public static event ILContext.Manipulator CloseQuickMap
    {
        add => IL.GameMap.CloseQuickMap += value;
        remove => IL.GameMap.CloseQuickMap -= value;
    }

    public static event ILContext.Manipulator PositionDreamGateMarker
    {
        add => IL.GameMap.PositionDreamGateMarker += value;
        remove => IL.GameMap.PositionDreamGateMarker -= value;
    }

    public static event ILContext.Manipulator PositionCompass
    {
        add => IL.GameMap.PositionCompass += value;
        remove => IL.GameMap.PositionCompass -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.GameMap.Update += value;
        remove => IL.GameMap.Update -= value;
    }

    public static event ILContext.Manipulator DisableMarkers
    {
        add => IL.GameMap.DisableMarkers += value;
        remove => IL.GameMap.DisableMarkers -= value;
    }

    public static event ILContext.Manipulator SetManualTilemap
    {
        add => IL.GameMap.SetManualTilemap += value;
        remove => IL.GameMap.SetManualTilemap -= value;
    }

    public static event ILContext.Manipulator SetDoorValues
    {
        add => IL.GameMap.SetDoorValues += value;
        remove => IL.GameMap.SetDoorValues -= value;
    }

    public static event ILContext.Manipulator SetCustomCompassPos
    {
        add => IL.GameMap.SetCustomCompassPos += value;
        remove => IL.GameMap.SetCustomCompassPos -= value;
    }

    public static event ILContext.Manipulator SetInRoom
    {
        add => IL.GameMap.SetInRoom += value;
        remove => IL.GameMap.SetInRoom -= value;
    }

    public static event ILContext.Manipulator SetCanPan
    {
        add => IL.GameMap.SetCanPan += value;
        remove => IL.GameMap.SetCanPan -= value;
    }

    public static event ILContext.Manipulator GetDoorMapZone
    {
        add => IL.GameMap.GetDoorMapZone += value;
        remove => IL.GameMap.GetDoorMapZone -= value;
    }

    public static event ILContext.Manipulator GetInRoom
    {
        add => IL.GameMap.GetInRoom += value;
        remove => IL.GameMap.GetInRoom -= value;
    }

    public static event ILContext.Manipulator SetPanArrows
    {
        add => IL.GameMap.SetPanArrows += value;
        remove => IL.GameMap.SetPanArrows -= value;
    }

    public static event ILContext.Manipulator KeepWithinBounds
    {
        add => IL.GameMap.KeepWithinBounds += value;
        remove => IL.GameMap.KeepWithinBounds -= value;
    }

    public static event ILContext.Manipulator StopPan
    {
        add => IL.GameMap.StopPan += value;
        remove => IL.GameMap.StopPan -= value;
    }

    public static event ILContext.Manipulator StartPan
    {
        add => IL.GameMap.StartPan += value;
        remove => IL.GameMap.StartPan -= value;
    }

    public static event ILContext.Manipulator SetupMapMarkers
    {
        add => IL.GameMap.SetupMapMarkers += value;
        remove => IL.GameMap.SetupMapMarkers -= value;
    }
}