using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SaveStats.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSaveStats
{
    public static event ILContext.Manipulator get_maxHealth
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "get_maxHealth"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "get_maxHealth"),
            value);
    }

    public static event ILContext.Manipulator set_maxHealth
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "set_maxHealth"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "set_maxHealth"),
            value);
    }

    public static event ILContext.Manipulator get_geo
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "get_geo"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "get_geo"), value);
    }

    public static event ILContext.Manipulator set_geo
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "set_geo"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "set_geo"), value);
    }

    public static event ILContext.Manipulator get_mapZone
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "get_mapZone"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "get_mapZone"), value);
    }

    public static event ILContext.Manipulator set_mapZone
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "set_mapZone"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "set_mapZone"), value);
    }

    public static event ILContext.Manipulator get_playTime
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "get_playTime"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "get_playTime"), value);
    }

    public static event ILContext.Manipulator set_playTime
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "set_playTime"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "set_playTime"), value);
    }

    public static event ILContext.Manipulator get_maxMPReserve
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "get_maxMPReserve"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "get_maxMPReserve"),
            value);
    }

    public static event ILContext.Manipulator set_maxMPReserve
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "set_maxMPReserve"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "set_maxMPReserve"),
            value);
    }

    public static event ILContext.Manipulator get_permadeathMode
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "get_permadeathMode"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "get_permadeathMode"),
            value);
    }

    public static event ILContext.Manipulator set_permadeathMode
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "set_permadeathMode"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "set_permadeathMode"),
            value);
    }

    public static event ILContext.Manipulator get_bossRushMode
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "get_bossRushMode"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "get_bossRushMode"),
            value);
    }

    public static event ILContext.Manipulator set_bossRushMode
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "set_bossRushMode"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "set_bossRushMode"),
            value);
    }

    public static event ILContext.Manipulator get_completionPercentage
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "get_completionPercentage"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SaveStats), "get_completionPercentage"), value);
    }

    public static event ILContext.Manipulator set_completionPercentage
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "set_completionPercentage"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SaveStats), "set_completionPercentage"), value);
    }

    public static event ILContext.Manipulator get_unlockedCompletionRate
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SaveStats), "get_unlockedCompletionRate"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SaveStats), "get_unlockedCompletionRate"), value);
    }

    public static event ILContext.Manipulator set_unlockedCompletionRate
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SaveStats), "set_unlockedCompletionRate"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SaveStats), "set_unlockedCompletionRate"), value);
    }

    public static event ILContext.Manipulator GetPlaytimeHHMM
    {
        add => IL.SaveStats.GetPlaytimeHHMM += value;
        remove => IL.SaveStats.GetPlaytimeHHMM -= value;
    }

    public static event ILContext.Manipulator GetPlaytimeHHMMSS
    {
        add => IL.SaveStats.GetPlaytimeHHMMSS += value;
        remove => IL.SaveStats.GetPlaytimeHHMMSS -= value;
    }

    public static event ILContext.Manipulator GetCompletionPercentage
    {
        add => IL.SaveStats.GetCompletionPercentage += value;
        remove => IL.SaveStats.GetCompletionPercentage -= value;
    }

    public static event ILContext.Manipulator GetMPSlotsVisible
    {
        add => IL.SaveStats.GetMPSlotsVisible += value;
        remove => IL.SaveStats.GetMPSlotsVisible -= value;
    }

    public static event ILContext.Manipulator get_LoadedMods
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "get_LoadedMods"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "get_LoadedMods"),
            value);
    }

    public static event ILContext.Manipulator set_LoadedMods
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "set_LoadedMods"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "set_LoadedMods"),
            value);
    }

    public static event ILContext.Manipulator get_Name
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "get_Name"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "get_Name"), value);
    }

    public static event ILContext.Manipulator set_Name
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "set_Name"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveStats), "set_Name"), value);
    }
}