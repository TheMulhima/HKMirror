using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GOGGalaxyOnlineSubsystem.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGOGGalaxyOnlineSubsystem
{
    public static event ILContext.Manipulator IsPackaged
    {
        add => IL.GOGGalaxyOnlineSubsystem.IsPackaged += value;
        remove => IL.GOGGalaxyOnlineSubsystem.IsPackaged -= value;
    }

    public static event ILContext.Manipulator get_DidInitialize
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GOGGalaxyOnlineSubsystem), "get_DidInitialize"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GOGGalaxyOnlineSubsystem), "get_DidInitialize"), value);
    }

    public static event ILContext.Manipulator Dispose
    {
        add => IL.GOGGalaxyOnlineSubsystem.Dispose += value;
        remove => IL.GOGGalaxyOnlineSubsystem.Dispose -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.GOGGalaxyOnlineSubsystem.Update += value;
        remove => IL.GOGGalaxyOnlineSubsystem.Update -= value;
    }

    public static event ILContext.Manipulator OnAuthorized
    {
        add => IL.GOGGalaxyOnlineSubsystem.OnAuthorized += value;
        remove => IL.GOGGalaxyOnlineSubsystem.OnAuthorized -= value;
    }

    public static event ILContext.Manipulator get_AreAchievementsFetched
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GOGGalaxyOnlineSubsystem), "get_AreAchievementsFetched"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GOGGalaxyOnlineSubsystem), "get_AreAchievementsFetched"), value);
    }

    public static event ILContext.Manipulator OnStatisticsReceived
    {
        add => IL.GOGGalaxyOnlineSubsystem.OnStatisticsReceived += value;
        remove => IL.GOGGalaxyOnlineSubsystem.OnStatisticsReceived -= value;
    }

    public static event ILContext.Manipulator IsAchievementUnlocked
    {
        add => IL.GOGGalaxyOnlineSubsystem.IsAchievementUnlocked += value;
        remove => IL.GOGGalaxyOnlineSubsystem.IsAchievementUnlocked -= value;
    }

    public static event ILContext.Manipulator PushAchievementUnlock
    {
        add => IL.GOGGalaxyOnlineSubsystem.PushAchievementUnlock += value;
        remove => IL.GOGGalaxyOnlineSubsystem.PushAchievementUnlock -= value;
    }

    public static event ILContext.Manipulator ResetAchievements
    {
        add => IL.GOGGalaxyOnlineSubsystem.ResetAchievements += value;
        remove => IL.GOGGalaxyOnlineSubsystem.ResetAchievements -= value;
    }
}