namespace HKMirror.Reflection;

/// <summary>
///     A class that contains all (public and private) fields and methods of SceneData allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public static class SceneDataR
{
    public static List<GeoRockData> geoRocks
    {
        get => SceneData.instance.geoRocks;
        set => SceneData.instance.geoRocks = value;
    }

    public static List<PersistentBoolData> persistentBoolItems
    {
        get => SceneData.instance.persistentBoolItems;
        set => SceneData.instance.persistentBoolItems = value;
    }

    public static List<PersistentIntData> persistentIntItems
    {
        get => SceneData.instance.persistentIntItems;
        set => SceneData.instance.persistentIntItems = value;
    }

    public static SceneData instance
    {
        get => SceneData.instance;
        set => SceneData.instance = value;
    }

    public static void Reset()
    {
        SceneData.instance.Reset();
    }

    public static void SaveMyState(GeoRockData geoRockData)
    {
        SceneData.instance.SaveMyState(geoRockData);
    }

    public static void SaveMyState(PersistentBoolData persistentBoolData)
    {
        SceneData.instance.SaveMyState(persistentBoolData);
    }

    public static void SaveMyState(PersistentIntData persistentIntData)
    {
        SceneData.instance.SaveMyState(persistentIntData);
    }

    public static void ResetSemiPersistentItems()
    {
        SceneData.instance.ResetSemiPersistentItems();
    }

    public static GeoRockData FindMyState(GeoRockData grd)
    {
        return SceneData.instance.FindMyState(grd);
    }

    public static PersistentBoolData FindMyState(PersistentBoolData persistentBoolData)
    {
        return SceneData.instance.FindMyState(persistentBoolData);
    }

    public static PersistentIntData FindMyState(PersistentIntData persistentIntData)
    {
        return SceneData.instance.FindMyState(persistentIntData);
    }

    public static void SetupNewSceneData()
    {
        ReflectionHelper.CallMethod(SceneData.instance, "SetupNewSceneData");
    }

    public static int FindGeoRockInList(GeoRockData grd)
    {
        return ReflectionHelper.CallMethod<SceneData, int>(SceneData.instance, "FindGeoRockInList", grd);
    }

    public static int FindPersistentBoolItemInList(PersistentBoolData pbd)
    {
        return ReflectionHelper.CallMethod<SceneData, int>(SceneData.instance, "FindPersistentBoolItemInList", pbd);
    }

    public static int FindPersistentIntItemInList(PersistentIntData pid)
    {
        return ReflectionHelper.CallMethod<SceneData, int>(SceneData.instance, "FindPersistentIntItemInList", pid);
    }
}