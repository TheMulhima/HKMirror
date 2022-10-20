using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GameCoreOnlineSubsystem.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGameCoreOnlineSubsystem
{
    public static event ILContext.Manipulator IsPackaged
    {
        add => IL.GameCoreOnlineSubsystem.IsPackaged += value;
        remove => IL.GameCoreOnlineSubsystem.IsPackaged -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.GameCoreOnlineSubsystem.Update += value;
        remove => IL.GameCoreOnlineSubsystem.Update -= value;
    }

    public static event ILContext.Manipulator get_EngagedDisplayName
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameCoreOnlineSubsystem), "get_EngagedDisplayName"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameCoreOnlineSubsystem), "get_EngagedDisplayName"), value);
    }

    public static event ILContext.Manipulator get_EngagedDisplayImage
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameCoreOnlineSubsystem), "get_EngagedDisplayImage"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameCoreOnlineSubsystem), "get_EngagedDisplayImage"), value);
    }

    public static event ILContext.Manipulator get_AreAchievementsFetched
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameCoreOnlineSubsystem), "get_AreAchievementsFetched"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameCoreOnlineSubsystem), "get_AreAchievementsFetched"), value);
    }

    public static event ILContext.Manipulator get_HasNativeAchievementsDialog
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameCoreOnlineSubsystem), "get_HasNativeAchievementsDialog"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameCoreOnlineSubsystem), "get_HasNativeAchievementsDialog"), value);
    }

    public static event ILContext.Manipulator PushAchievementUnlock
    {
        add => IL.GameCoreOnlineSubsystem.PushAchievementUnlock += value;
        remove => IL.GameCoreOnlineSubsystem.PushAchievementUnlock -= value;
    }

    public static event ILContext.Manipulator IsAchievementUnlocked
    {
        add => IL.GameCoreOnlineSubsystem.IsAchievementUnlocked += value;
        remove => IL.GameCoreOnlineSubsystem.IsAchievementUnlocked -= value;
    }

    public static event ILContext.Manipulator ResetAchievements
    {
        add => IL.GameCoreOnlineSubsystem.ResetAchievements += value;
        remove => IL.GameCoreOnlineSubsystem.ResetAchievements -= value;
    }

    public static event ILContext.Manipulator GetSaveContainerName
    {
        add => IL.GameCoreOnlineSubsystem.GetSaveContainerName += value;
        remove => IL.GameCoreOnlineSubsystem.GetSaveContainerName -= value;
    }

    public static event ILContext.Manipulator GetSaveFileName
    {
        add => IL.GameCoreOnlineSubsystem.GetSaveFileName += value;
        remove => IL.GameCoreOnlineSubsystem.GetSaveFileName -= value;
    }

    public static event ILContext.Manipulator get_HandlesGameSaves
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameCoreOnlineSubsystem), "get_HandlesGameSaves"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameCoreOnlineSubsystem), "get_HandlesGameSaves"), value);
    }

    public static event ILContext.Manipulator get_WillPreloadSaveFiles
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameCoreOnlineSubsystem), "get_WillPreloadSaveFiles"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameCoreOnlineSubsystem), "get_WillPreloadSaveFiles"), value);
    }

    public static event ILContext.Manipulator IsSaveSlotInUse
    {
        add => IL.GameCoreOnlineSubsystem.IsSaveSlotInUse += value;
        remove => IL.GameCoreOnlineSubsystem.IsSaveSlotInUse -= value;
    }

    public static event ILContext.Manipulator ReadSaveSlot
    {
        add => IL.GameCoreOnlineSubsystem.ReadSaveSlot += value;
        remove => IL.GameCoreOnlineSubsystem.ReadSaveSlot -= value;
    }

    public static event ILContext.Manipulator WriteSaveSlot
    {
        add => IL.GameCoreOnlineSubsystem.WriteSaveSlot += value;
        remove => IL.GameCoreOnlineSubsystem.WriteSaveSlot -= value;
    }

    public static event ILContext.Manipulator ClearSaveSlot
    {
        add => IL.GameCoreOnlineSubsystem.ClearSaveSlot += value;
        remove => IL.GameCoreOnlineSubsystem.ClearSaveSlot -= value;
    }

    public static event ILContext.Manipulator Succeeded
    {
        add => IL.GameCoreOnlineSubsystem.Succeeded += value;
        remove => IL.GameCoreOnlineSubsystem.Succeeded -= value;
    }

    public static event ILContext.Manipulator AddUserComplete
    {
        add => IL.GameCoreOnlineSubsystem.AddUserComplete += value;
        remove => IL.GameCoreOnlineSubsystem.AddUserComplete -= value;
    }

    public static event ILContext.Manipulator CompletePostSignInInitialization
    {
        add => IL.GameCoreOnlineSubsystem.CompletePostSignInInitialization += value;
        remove => IL.GameCoreOnlineSubsystem.CompletePostSignInInitialization -= value;
    }

    public static event ILContext.Manipulator MigrateLocalSaves
    {
        add => IL.GameCoreOnlineSubsystem.MigrateLocalSaves += value;
        remove => IL.GameCoreOnlineSubsystem.MigrateLocalSaves -= value;
    }
}