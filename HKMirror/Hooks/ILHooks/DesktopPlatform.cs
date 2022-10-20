using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for DesktopPlatform.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDesktopPlatform
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.DesktopPlatform.Awake += value;
        remove => IL.DesktopPlatform.Awake -= value;
    }

    public static event ILContext.Manipulator CreateOnlineSubsystem
    {
        add => IL.DesktopPlatform.CreateOnlineSubsystem += value;
        remove => IL.DesktopPlatform.CreateOnlineSubsystem -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.DesktopPlatform.OnDestroy += value;
        remove => IL.DesktopPlatform.OnDestroy -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.DesktopPlatform.Update += value;
        remove => IL.DesktopPlatform.Update -= value;
    }

    public static event ILContext.Manipulator get_DisplayName
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(DesktopPlatform), "get_DisplayName"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(DesktopPlatform), "get_DisplayName"), value);
    }

    public static event ILContext.Manipulator IsSaveSlotInUse
    {
        add => IL.DesktopPlatform.IsSaveSlotInUse += value;
        remove => IL.DesktopPlatform.IsSaveSlotInUse -= value;
    }

    public static event ILContext.Manipulator LocalIsSaveSlotInUse
    {
        add => IL.DesktopPlatform.LocalIsSaveSlotInUse += value;
        remove => IL.DesktopPlatform.LocalIsSaveSlotInUse -= value;
    }

    public static event ILContext.Manipulator ReadSaveSlot
    {
        add => IL.DesktopPlatform.ReadSaveSlot += value;
        remove => IL.DesktopPlatform.ReadSaveSlot -= value;
    }

    public static event ILContext.Manipulator LocalReadSaveSlot
    {
        add => IL.DesktopPlatform.LocalReadSaveSlot += value;
        remove => IL.DesktopPlatform.LocalReadSaveSlot -= value;
    }

    public static event ILContext.Manipulator EnsureSaveSlotSpace
    {
        add => IL.DesktopPlatform.EnsureSaveSlotSpace += value;
        remove => IL.DesktopPlatform.EnsureSaveSlotSpace -= value;
    }

    public static event ILContext.Manipulator WriteSaveSlot
    {
        add => IL.DesktopPlatform.WriteSaveSlot += value;
        remove => IL.DesktopPlatform.WriteSaveSlot -= value;
    }

    public static event ILContext.Manipulator GetBackupNumber
    {
        add => IL.DesktopPlatform.GetBackupNumber += value;
        remove => IL.DesktopPlatform.GetBackupNumber -= value;
    }

    public static event ILContext.Manipulator ClearSaveSlot
    {
        add => IL.DesktopPlatform.ClearSaveSlot += value;
        remove => IL.DesktopPlatform.ClearSaveSlot -= value;
    }

    public static event ILContext.Manipulator IsAchievementUnlocked
    {
        add => IL.DesktopPlatform.IsAchievementUnlocked += value;
        remove => IL.DesktopPlatform.IsAchievementUnlocked -= value;
    }

    public static event ILContext.Manipulator PushAchievementUnlock
    {
        add => IL.DesktopPlatform.PushAchievementUnlock += value;
        remove => IL.DesktopPlatform.PushAchievementUnlock -= value;
    }

    public static event ILContext.Manipulator ResetAchievements
    {
        add => IL.DesktopPlatform.ResetAchievements += value;
        remove => IL.DesktopPlatform.ResetAchievements -= value;
    }

    public static event ILContext.Manipulator get_AreAchievementsFetched
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(DesktopPlatform), "get_AreAchievementsFetched"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(DesktopPlatform), "get_AreAchievementsFetched"), value);
    }

    public static event ILContext.Manipulator get_HasNativeAchievementsDialog
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(DesktopPlatform), "get_HasNativeAchievementsDialog"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(DesktopPlatform), "get_HasNativeAchievementsDialog"), value);
    }

    public static event ILContext.Manipulator IncludesPlugin
    {
        add => IL.DesktopPlatform.IncludesPlugin += value;
        remove => IL.DesktopPlatform.IncludesPlugin -= value;
    }

    public static event ILContext.Manipulator OnOnlineSubsystemAchievementsFetched
    {
        add => IL.DesktopPlatform.OnOnlineSubsystemAchievementsFetched += value;
        remove => IL.DesktopPlatform.OnOnlineSubsystemAchievementsFetched -= value;
    }

    public static event ILContext.Manipulator get_ShowLanguageSelect
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(DesktopPlatform), "get_ShowLanguageSelect"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(DesktopPlatform), "get_ShowLanguageSelect"), value);
    }

    public static event ILContext.Manipulator get_IsControllerImplicit
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(DesktopPlatform), "get_IsControllerImplicit"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(DesktopPlatform), "get_IsControllerImplicit"), value);
    }

    public static event ILContext.Manipulator get_WillPreloadSaveFiles
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(DesktopPlatform), "get_WillPreloadSaveFiles"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(DesktopPlatform), "get_WillPreloadSaveFiles"), value);
    }

    public static event ILContext.Manipulator get_EngagedDisplayName
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(DesktopPlatform), "get_EngagedDisplayName"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(DesktopPlatform), "get_EngagedDisplayName"), value);
    }

    public static event ILContext.Manipulator get_EngagedDisplayImage
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(DesktopPlatform), "get_EngagedDisplayImage"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(DesktopPlatform), "get_EngagedDisplayImage"), value);
    }

    public static event ILContext.Manipulator GetVibrationMixer
    {
        add => IL.DesktopPlatform.GetVibrationMixer += value;
        remove => IL.DesktopPlatform.GetVibrationMixer -= value;
    }
}