using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SteamOnlineSubsystem.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSteamOnlineSubsystem
{
    public static event ILContext.Manipulator IsPackaged
    {
        add => IL.SteamOnlineSubsystem.IsPackaged += value;
        remove => IL.SteamOnlineSubsystem.IsPackaged -= value;
    }

    public static event ILContext.Manipulator Dispose
    {
        add => IL.SteamOnlineSubsystem.Dispose += value;
        remove => IL.SteamOnlineSubsystem.Dispose -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.SteamOnlineSubsystem.Update += value;
        remove => IL.SteamOnlineSubsystem.Update -= value;
    }

    public static event ILContext.Manipulator OnSteamLogMessage
    {
        add => IL.SteamOnlineSubsystem.OnSteamLogMessage += value;
        remove => IL.SteamOnlineSubsystem.OnSteamLogMessage -= value;
    }

    public static event ILContext.Manipulator OnGameOverlayActivated
    {
        add => IL.SteamOnlineSubsystem.OnGameOverlayActivated += value;
        remove => IL.SteamOnlineSubsystem.OnGameOverlayActivated -= value;
    }

    public static event ILContext.Manipulator OnStatsReceived
    {
        add => IL.SteamOnlineSubsystem.OnStatsReceived += value;
        remove => IL.SteamOnlineSubsystem.OnStatsReceived -= value;
    }

    public static event ILContext.Manipulator get_AreAchievementsFetched
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SteamOnlineSubsystem), "get_AreAchievementsFetched"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SteamOnlineSubsystem), "get_AreAchievementsFetched"), value);
    }

    public static event ILContext.Manipulator OnSteamShutdown
    {
        add => IL.SteamOnlineSubsystem.OnSteamShutdown += value;
        remove => IL.SteamOnlineSubsystem.OnSteamShutdown -= value;
    }

    public static event ILContext.Manipulator OnAchievementStored
    {
        add => IL.SteamOnlineSubsystem.OnAchievementStored += value;
        remove => IL.SteamOnlineSubsystem.OnAchievementStored -= value;
    }

    public static event ILContext.Manipulator PushAchievementUnlock
    {
        add => IL.SteamOnlineSubsystem.PushAchievementUnlock += value;
        remove => IL.SteamOnlineSubsystem.PushAchievementUnlock -= value;
    }

    public static event ILContext.Manipulator IsAchievementUnlocked
    {
        add => IL.SteamOnlineSubsystem.IsAchievementUnlocked += value;
        remove => IL.SteamOnlineSubsystem.IsAchievementUnlocked -= value;
    }

    public static event ILContext.Manipulator ResetAchievements
    {
        add => IL.SteamOnlineSubsystem.ResetAchievements += value;
        remove => IL.SteamOnlineSubsystem.ResetAchievements -= value;
    }
}