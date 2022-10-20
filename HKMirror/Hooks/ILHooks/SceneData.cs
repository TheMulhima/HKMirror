using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SceneData.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSceneData
{
    public static event ILContext.Manipulator get_instance
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SceneData), "get_instance", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SceneData), "get_instance", false),
            value);
    }

    public static event ILContext.Manipulator set_instance
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SceneData), "set_instance", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SceneData), "set_instance", false),
            value);
    }

    public static event ILContext.Manipulator Reset
    {
        add => IL.SceneData.Reset += value;
        remove => IL.SceneData.Reset -= value;
    }

    public static event ILContext.Manipulator SaveMyState_GeoRockData
    {
        add => IL.SceneData.SaveMyState_GeoRockData += value;
        remove => IL.SceneData.SaveMyState_GeoRockData -= value;
    }

    public static event ILContext.Manipulator SaveMyState_PersistentBoolData
    {
        add => IL.SceneData.SaveMyState_PersistentBoolData += value;
        remove => IL.SceneData.SaveMyState_PersistentBoolData -= value;
    }

    public static event ILContext.Manipulator SaveMyState_PersistentIntData
    {
        add => IL.SceneData.SaveMyState_PersistentIntData += value;
        remove => IL.SceneData.SaveMyState_PersistentIntData -= value;
    }

    public static event ILContext.Manipulator ResetSemiPersistentItems
    {
        add => IL.SceneData.ResetSemiPersistentItems += value;
        remove => IL.SceneData.ResetSemiPersistentItems -= value;
    }

    public static event ILContext.Manipulator FindMyState_GeoRockData
    {
        add => IL.SceneData.FindMyState_GeoRockData += value;
        remove => IL.SceneData.FindMyState_GeoRockData -= value;
    }

    public static event ILContext.Manipulator FindMyState_PersistentBoolData
    {
        add => IL.SceneData.FindMyState_PersistentBoolData += value;
        remove => IL.SceneData.FindMyState_PersistentBoolData -= value;
    }

    public static event ILContext.Manipulator FindMyState_PersistentIntData
    {
        add => IL.SceneData.FindMyState_PersistentIntData += value;
        remove => IL.SceneData.FindMyState_PersistentIntData -= value;
    }

    public static event ILContext.Manipulator SetupNewSceneData
    {
        add => IL.SceneData.SetupNewSceneData += value;
        remove => IL.SceneData.SetupNewSceneData -= value;
    }

    public static event ILContext.Manipulator FindGeoRockInList
    {
        add => IL.SceneData.FindGeoRockInList += value;
        remove => IL.SceneData.FindGeoRockInList -= value;
    }

    public static event ILContext.Manipulator FindPersistentBoolItemInList
    {
        add => IL.SceneData.FindPersistentBoolItemInList += value;
        remove => IL.SceneData.FindPersistentBoolItemInList -= value;
    }

    public static event ILContext.Manipulator FindPersistentIntItemInList
    {
        add => IL.SceneData.FindPersistentIntItemInList += value;
        remove => IL.SceneData.FindPersistentIntItemInList -= value;
    }
}