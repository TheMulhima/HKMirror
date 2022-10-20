using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for UIManager.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILUIManager
{
    public static event ILContext.Manipulator get_IsFadingMenu
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UIManager), "get_IsFadingMenu"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UIManager), "get_IsFadingMenu"),
            value);
    }

    public static event ILContext.Manipulator get_IsAnimatingMenus
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UIManager), "get_IsAnimatingMenus"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "get_IsAnimatingMenus"), value);
    }

    public static event ILContext.Manipulator get_instance
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UIManager), "get_instance", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UIManager), "get_instance", false),
            value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.UIManager.Awake += value;
        remove => IL.UIManager.Awake -= value;
    }

    public static event ILContext.Manipulator SceneInit
    {
        add => IL.UIManager.SceneInit += value;
        remove => IL.UIManager.SceneInit -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.UIManager.Start += value;
        remove => IL.UIManager.Start -= value;
    }

    public static event ILContext.Manipulator SetState
    {
        add => IL.UIManager.SetState += value;
        remove => IL.UIManager.SetState -= value;
    }

    public static event ILContext.Manipulator SetMenuState
    {
        add => IL.UIManager.SetMenuState += value;
        remove => IL.UIManager.SetMenuState -= value;
    }

    public static event ILContext.Manipulator SetupRefs
    {
        add => IL.UIManager.SetupRefs += value;
        remove => IL.UIManager.SetupRefs -= value;
    }

    public static event ILContext.Manipulator SetUIStartState
    {
        add => IL.UIManager.SetUIStartState += value;
        remove => IL.UIManager.SetUIStartState -= value;
    }

    public static event ILContext.Manipulator ShowMainMenuHome
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "ShowMainMenuHome").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "ShowMainMenuHome").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator StartMenuAnimationCoroutine
    {
        add => IL.UIManager.StartMenuAnimationCoroutine += value;
        remove => IL.UIManager.StartMenuAnimationCoroutine -= value;
    }

    public static event ILContext.Manipulator StartMenuAnimationCoroutineWorker
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "StartMenuAnimationCoroutineWorker")
                .GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "StartMenuAnimationCoroutineWorker")
                .GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator UIGoToOptionsMenu
    {
        add => IL.UIManager.UIGoToOptionsMenu += value;
        remove => IL.UIManager.UIGoToOptionsMenu -= value;
    }

    public static event ILContext.Manipulator UILeaveOptionsMenu
    {
        add => IL.UIManager.UILeaveOptionsMenu += value;
        remove => IL.UIManager.UILeaveOptionsMenu -= value;
    }

    public static event ILContext.Manipulator UIExplicitSwitchUser
    {
        add => IL.UIManager.UIExplicitSwitchUser += value;
        remove => IL.UIManager.UIExplicitSwitchUser -= value;
    }

    public static event ILContext.Manipulator UIGoToEngageMenu
    {
        add => IL.UIManager.UIGoToEngageMenu += value;
        remove => IL.UIManager.UIGoToEngageMenu -= value;
    }

    public static event ILContext.Manipulator UIGoToNoSaveMenu
    {
        add => IL.UIManager.UIGoToNoSaveMenu += value;
        remove => IL.UIManager.UIGoToNoSaveMenu -= value;
    }

    public static event ILContext.Manipulator UIGoToMainMenu
    {
        add => IL.UIManager.UIGoToMainMenu += value;
        remove => IL.UIManager.UIGoToMainMenu -= value;
    }

    public static event ILContext.Manipulator UIGoToProfileMenu
    {
        add => IL.UIManager.UIGoToProfileMenu += value;
        remove => IL.UIManager.UIGoToProfileMenu -= value;
    }

    public static event ILContext.Manipulator UIReturnToProfileMenu
    {
        add => IL.UIManager.UIReturnToProfileMenu += value;
        remove => IL.UIManager.UIReturnToProfileMenu -= value;
    }

    public static event ILContext.Manipulator UIMainStartGame
    {
        add => IL.UIManager.UIMainStartGame += value;
        remove => IL.UIManager.UIMainStartGame -= value;
    }

    public static event ILContext.Manipulator UIGoToControllerMenu
    {
        add => IL.UIManager.UIGoToControllerMenu += value;
        remove => IL.UIManager.UIGoToControllerMenu -= value;
    }

    public static event ILContext.Manipulator UIGoToRemapControllerMenu
    {
        add => IL.UIManager.UIGoToRemapControllerMenu += value;
        remove => IL.UIManager.UIGoToRemapControllerMenu -= value;
    }

    public static event ILContext.Manipulator UIGoToKeyboardMenu
    {
        add => IL.UIManager.UIGoToKeyboardMenu += value;
        remove => IL.UIManager.UIGoToKeyboardMenu -= value;
    }

    public static event ILContext.Manipulator UIGoToAudioMenu
    {
        add => IL.UIManager.UIGoToAudioMenu += value;
        remove => IL.UIManager.UIGoToAudioMenu -= value;
    }

    public static event ILContext.Manipulator UIGoToVideoMenu
    {
        add => IL.UIManager.UIGoToVideoMenu += value;
        remove => IL.UIManager.UIGoToVideoMenu -= value;
    }

    public static event ILContext.Manipulator UIGoToPauseMenu
    {
        add => IL.UIManager.UIGoToPauseMenu += value;
        remove => IL.UIManager.UIGoToPauseMenu -= value;
    }

    public static event ILContext.Manipulator UIClosePauseMenu
    {
        add => IL.UIManager.UIClosePauseMenu += value;
        remove => IL.UIManager.UIClosePauseMenu -= value;
    }

    public static event ILContext.Manipulator UIClearPauseMenu
    {
        add => IL.UIManager.UIClearPauseMenu += value;
        remove => IL.UIManager.UIClearPauseMenu -= value;
    }

    public static event ILContext.Manipulator UnClearPauseMenu
    {
        add => IL.UIManager.UnClearPauseMenu += value;
        remove => IL.UIManager.UnClearPauseMenu -= value;
    }

    public static event ILContext.Manipulator UIGoToOverscanMenu
    {
        add => IL.UIManager.UIGoToOverscanMenu += value;
        remove => IL.UIManager.UIGoToOverscanMenu -= value;
    }

    public static event ILContext.Manipulator UIGoToBrightnessMenu
    {
        add => IL.UIManager.UIGoToBrightnessMenu += value;
        remove => IL.UIManager.UIGoToBrightnessMenu -= value;
    }

    public static event ILContext.Manipulator UIGoToGameOptionsMenu
    {
        add => IL.UIManager.UIGoToGameOptionsMenu += value;
        remove => IL.UIManager.UIGoToGameOptionsMenu -= value;
    }

    public static event ILContext.Manipulator UIGoToAchievementsMenu
    {
        add => IL.UIManager.UIGoToAchievementsMenu += value;
        remove => IL.UIManager.UIGoToAchievementsMenu -= value;
    }

    public static event ILContext.Manipulator UIGoToExtrasMenu
    {
        add => IL.UIManager.UIGoToExtrasMenu += value;
        remove => IL.UIManager.UIGoToExtrasMenu -= value;
    }

    public static event ILContext.Manipulator UIGoToExtrasContentMenu
    {
        add => IL.UIManager.UIGoToExtrasContentMenu += value;
        remove => IL.UIManager.UIGoToExtrasContentMenu -= value;
    }

    public static event ILContext.Manipulator UIShowQuitGamePrompt
    {
        add => IL.UIManager.UIShowQuitGamePrompt += value;
        remove => IL.UIManager.UIShowQuitGamePrompt -= value;
    }

    public static event ILContext.Manipulator UIShowReturnMenuPrompt
    {
        add => IL.UIManager.UIShowReturnMenuPrompt += value;
        remove => IL.UIManager.UIShowReturnMenuPrompt -= value;
    }

    public static event ILContext.Manipulator UIShowResolutionPrompt
    {
        add => IL.UIManager.UIShowResolutionPrompt += value;
        remove => IL.UIManager.UIShowResolutionPrompt -= value;
    }

    public static event ILContext.Manipulator UILeaveExitToMenuPrompt
    {
        add => IL.UIManager.UILeaveExitToMenuPrompt += value;
        remove => IL.UIManager.UILeaveExitToMenuPrompt -= value;
    }

    public static event ILContext.Manipulator UIGoToPlayModeMenu
    {
        add => IL.UIManager.UIGoToPlayModeMenu += value;
        remove => IL.UIManager.UIGoToPlayModeMenu -= value;
    }

    public static event ILContext.Manipulator UIReturnToMainMenu
    {
        add => IL.UIManager.UIReturnToMainMenu += value;
        remove => IL.UIManager.UIReturnToMainMenu -= value;
    }

    public static event ILContext.Manipulator UIGoToMenuCredits
    {
        add => IL.UIManager.UIGoToMenuCredits += value;
        remove => IL.UIManager.UIGoToMenuCredits -= value;
    }

    public static event ILContext.Manipulator UIStartNewGame
    {
        add => IL.UIManager.UIStartNewGame += value;
        remove => IL.UIManager.UIStartNewGame -= value;
    }

    public static event ILContext.Manipulator UIStartNewGameContinue
    {
        add => IL.UIManager.UIStartNewGameContinue += value;
        remove => IL.UIManager.UIStartNewGameContinue -= value;
    }

    public static event ILContext.Manipulator StartNewGame
    {
        add => IL.UIManager.StartNewGame += value;
        remove => IL.UIManager.StartNewGame -= value;
    }

    public static event ILContext.Manipulator ContinueGame
    {
        add => IL.UIManager.ContinueGame += value;
        remove => IL.UIManager.ContinueGame -= value;
    }

    public static event ILContext.Manipulator GoToEngageMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToEngageMenu").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToEngageMenu").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator GoToNoSaveMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToNoSaveMenu").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToNoSaveMenu").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator GoToMainMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToMainMenu").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToMainMenu").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator GoToProfileMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToProfileMenu").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToProfileMenu").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator PrepareSaveFilesInOrder
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "PrepareSaveFilesInOrder").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "PrepareSaveFilesInOrder").GetStateMachineTarget(),
            value);
    }

    public static event ILContext.Manipulator GoToOptionsMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToOptionsMenu").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToOptionsMenu").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator GoToControllerMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToControllerMenu").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToControllerMenu").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator GoToRemapControllerMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToRemapControllerMenu").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToRemapControllerMenu").GetStateMachineTarget(),
            value);
    }

    public static event ILContext.Manipulator GoToKeyboardMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToKeyboardMenu").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToKeyboardMenu").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator GoToAudioMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToAudioMenu").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToAudioMenu").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator GoToVideoMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToVideoMenu").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToVideoMenu").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator GoToOverscanMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToOverscanMenu").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToOverscanMenu").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator GoToBrightnessMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToBrightnessMenu").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToBrightnessMenu").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator GoToGameOptionsMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToGameOptionsMenu").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToGameOptionsMenu").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator GoToAchievementsMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToAchievementsMenu").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToAchievementsMenu").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator GoToExtrasMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToExtrasMenu").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToExtrasMenu").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator GoToExtrasContentMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToExtrasContentMenu").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToExtrasContentMenu").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator GoToQuitGamePrompt
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToQuitGamePrompt").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToQuitGamePrompt").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator GoToReturnMenuPrompt
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToReturnMenuPrompt").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToReturnMenuPrompt").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator GoToResolutionPrompt
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToResolutionPrompt").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToResolutionPrompt").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator LeaveOptionsMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "LeaveOptionsMenu").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "LeaveOptionsMenu").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator LeaveExitToMenuPrompt
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "LeaveExitToMenuPrompt").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "LeaveExitToMenuPrompt").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator GoToPlayModeMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToPlayModeMenu").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToPlayModeMenu").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator ReturnToMainMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "ReturnToMainMenu").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "ReturnToMainMenu").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator GoToPauseMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToPauseMenu").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToPauseMenu").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator GoToMenuCredits
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToMenuCredits").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToMenuCredits").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator HideCutscenePrompt
    {
        add => IL.UIManager.HideCutscenePrompt += value;
        remove => IL.UIManager.HideCutscenePrompt -= value;
    }

    public static event ILContext.Manipulator ApplyAudioMenuSettings
    {
        add => IL.UIManager.ApplyAudioMenuSettings += value;
        remove => IL.UIManager.ApplyAudioMenuSettings -= value;
    }

    public static event ILContext.Manipulator ApplyVideoMenuSettings
    {
        add => IL.UIManager.ApplyVideoMenuSettings += value;
        remove => IL.UIManager.ApplyVideoMenuSettings -= value;
    }

    public static event ILContext.Manipulator ApplyControllerMenuSettings
    {
        add => IL.UIManager.ApplyControllerMenuSettings += value;
        remove => IL.UIManager.ApplyControllerMenuSettings -= value;
    }

    public static event ILContext.Manipulator ApplyRemapGamepadMenuSettings
    {
        add => IL.UIManager.ApplyRemapGamepadMenuSettings += value;
        remove => IL.UIManager.ApplyRemapGamepadMenuSettings -= value;
    }

    public static event ILContext.Manipulator ApplyKeyboardMenuSettings
    {
        add => IL.UIManager.ApplyKeyboardMenuSettings += value;
        remove => IL.UIManager.ApplyKeyboardMenuSettings -= value;
    }

    public static event ILContext.Manipulator ApplyOverscanSettings
    {
        add => IL.UIManager.ApplyOverscanSettings += value;
        remove => IL.UIManager.ApplyOverscanSettings -= value;
    }

    public static event ILContext.Manipulator ApplyBrightnessSettings
    {
        add => IL.UIManager.ApplyBrightnessSettings += value;
        remove => IL.UIManager.ApplyBrightnessSettings -= value;
    }

    public static event ILContext.Manipulator ApplyGameMenuSettings
    {
        add => IL.UIManager.ApplyGameMenuSettings += value;
        remove => IL.UIManager.ApplyGameMenuSettings -= value;
    }

    public static event ILContext.Manipulator SaveOverscanSettings
    {
        add => IL.UIManager.SaveOverscanSettings += value;
        remove => IL.UIManager.SaveOverscanSettings -= value;
    }

    public static event ILContext.Manipulator SaveBrightnessSettings
    {
        add => IL.UIManager.SaveBrightnessSettings += value;
        remove => IL.UIManager.SaveBrightnessSettings -= value;
    }

    public static event ILContext.Manipulator DefaultAudioMenuSettings
    {
        add => IL.UIManager.DefaultAudioMenuSettings += value;
        remove => IL.UIManager.DefaultAudioMenuSettings -= value;
    }

    public static event ILContext.Manipulator DefaultVideoMenuSettings
    {
        add => IL.UIManager.DefaultVideoMenuSettings += value;
        remove => IL.UIManager.DefaultVideoMenuSettings -= value;
    }

    public static event ILContext.Manipulator DefaultGamepadMenuSettings
    {
        add => IL.UIManager.DefaultGamepadMenuSettings += value;
        remove => IL.UIManager.DefaultGamepadMenuSettings -= value;
    }

    public static event ILContext.Manipulator DefaultKeyboardMenuSettings
    {
        add => IL.UIManager.DefaultKeyboardMenuSettings += value;
        remove => IL.UIManager.DefaultKeyboardMenuSettings -= value;
    }

    public static event ILContext.Manipulator DefaultGameMenuSettings
    {
        add => IL.UIManager.DefaultGameMenuSettings += value;
        remove => IL.UIManager.DefaultGameMenuSettings -= value;
    }

    public static event ILContext.Manipulator LoadStoredSettings
    {
        add => IL.UIManager.LoadStoredSettings += value;
        remove => IL.UIManager.LoadStoredSettings -= value;
    }

    public static event ILContext.Manipulator LoadAudioSettings
    {
        add => IL.UIManager.LoadAudioSettings += value;
        remove => IL.UIManager.LoadAudioSettings -= value;
    }

    public static event ILContext.Manipulator LoadVideoSettings
    {
        add => IL.UIManager.LoadVideoSettings += value;
        remove => IL.UIManager.LoadVideoSettings -= value;
    }

    public static event ILContext.Manipulator LoadGameOptionsSettings
    {
        add => IL.UIManager.LoadGameOptionsSettings += value;
        remove => IL.UIManager.LoadGameOptionsSettings -= value;
    }

    public static event ILContext.Manipulator LoadControllerSettings
    {
        add => IL.UIManager.LoadControllerSettings += value;
        remove => IL.UIManager.LoadControllerSettings -= value;
    }

    public static event ILContext.Manipulator RefreshAudioControls
    {
        add => IL.UIManager.RefreshAudioControls += value;
        remove => IL.UIManager.RefreshAudioControls -= value;
    }

    public static event ILContext.Manipulator RefreshVideoControls
    {
        add => IL.UIManager.RefreshVideoControls += value;
        remove => IL.UIManager.RefreshVideoControls -= value;
    }

    public static event ILContext.Manipulator DisableFrameCapSetting
    {
        add => IL.UIManager.DisableFrameCapSetting += value;
        remove => IL.UIManager.DisableFrameCapSetting -= value;
    }

    public static event ILContext.Manipulator DisableVsyncSetting
    {
        add => IL.UIManager.DisableVsyncSetting += value;
        remove => IL.UIManager.DisableVsyncSetting -= value;
    }

    public static event ILContext.Manipulator RefreshKeyboardControls
    {
        add => IL.UIManager.RefreshKeyboardControls += value;
        remove => IL.UIManager.RefreshKeyboardControls -= value;
    }

    public static event ILContext.Manipulator RefreshGameOptionsControls
    {
        add => IL.UIManager.RefreshGameOptionsControls += value;
        remove => IL.UIManager.RefreshGameOptionsControls -= value;
    }

    public static event ILContext.Manipulator RefreshAchievementsList
    {
        add => IL.UIManager.RefreshAchievementsList += value;
        remove => IL.UIManager.RefreshAchievementsList -= value;
    }

    public static event ILContext.Manipulator UpdateMenuAchievementStatus
    {
        add => IL.UIManager.UpdateMenuAchievementStatus += value;
        remove => IL.UIManager.UpdateMenuAchievementStatus -= value;
    }

    public static event ILContext.Manipulator TogglePauseGame
    {
        add => IL.UIManager.TogglePauseGame += value;
        remove => IL.UIManager.TogglePauseGame -= value;
    }

    public static event ILContext.Manipulator QuitGame
    {
        add => IL.UIManager.QuitGame += value;
        remove => IL.UIManager.QuitGame -= value;
    }

    public static event ILContext.Manipulator FadeOutMenuAudio
    {
        add => IL.UIManager.FadeOutMenuAudio += value;
        remove => IL.UIManager.FadeOutMenuAudio -= value;
    }

    public static event ILContext.Manipulator AudioGoToPauseMenu
    {
        add => IL.UIManager.AudioGoToPauseMenu += value;
        remove => IL.UIManager.AudioGoToPauseMenu -= value;
    }

    public static event ILContext.Manipulator AudioGoToGameplay
    {
        add => IL.UIManager.AudioGoToGameplay += value;
        remove => IL.UIManager.AudioGoToGameplay -= value;
    }

    public static event ILContext.Manipulator ConfigureMenu
    {
        add => IL.UIManager.ConfigureMenu += value;
        remove => IL.UIManager.ConfigureMenu -= value;
    }

    public static event ILContext.Manipulator HideCurrentMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "HideCurrentMenu").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "HideCurrentMenu").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator ShowMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "ShowMenu").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "ShowMenu").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator HideMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "HideMenu").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "HideMenu").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator HideMenuInstant
    {
        add => IL.UIManager.HideMenuInstant += value;
        remove => IL.UIManager.HideMenuInstant -= value;
    }

    public static event ILContext.Manipulator HideSaveProfileMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "HideSaveProfileMenu").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "HideSaveProfileMenu").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator DisableScreens
    {
        add => IL.UIManager.DisableScreens += value;
        remove => IL.UIManager.DisableScreens -= value;
    }

    public static event ILContext.Manipulator ShowCanvas
    {
        add => IL.UIManager.ShowCanvas += value;
        remove => IL.UIManager.ShowCanvas -= value;
    }

    public static event ILContext.Manipulator HideCanvas
    {
        add => IL.UIManager.HideCanvas += value;
        remove => IL.UIManager.HideCanvas -= value;
    }

    public static event ILContext.Manipulator ShowCanvasGroup
    {
        add => IL.UIManager.ShowCanvasGroup += value;
        remove => IL.UIManager.ShowCanvasGroup -= value;
    }

    public static event ILContext.Manipulator HideCanvasGroup
    {
        add => IL.UIManager.HideCanvasGroup += value;
        remove => IL.UIManager.HideCanvasGroup -= value;
    }

    public static event ILContext.Manipulator FadeInCanvasGroup
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "FadeInCanvasGroup").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "FadeInCanvasGroup").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator FadeInCanvasGroupAlpha
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "FadeInCanvasGroupAlpha").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "FadeInCanvasGroupAlpha").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator FadeOutCanvasGroup
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "FadeOutCanvasGroup").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "FadeOutCanvasGroup").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator FadeInSprite
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "FadeInSprite").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "FadeInSprite").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator FadeOutSprite
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "FadeOutSprite").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "FadeOutSprite").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator EnableChildren_RectTransform
    {
        add => IL.UIManager.EnableChildren_RectTransform += value;
        remove => IL.UIManager.EnableChildren_RectTransform -= value;
    }

    public static event ILContext.Manipulator EnableChildren_Canvas
    {
        add => IL.UIManager.EnableChildren_Canvas += value;
        remove => IL.UIManager.EnableChildren_Canvas -= value;
    }

    public static event ILContext.Manipulator DisableChildren
    {
        add => IL.UIManager.DisableChildren += value;
        remove => IL.UIManager.DisableChildren -= value;
    }

    public static event ILContext.Manipulator GetAnimationClipLength
    {
        add => IL.UIManager.GetAnimationClipLength += value;
        remove => IL.UIManager.GetAnimationClipLength -= value;
    }

    public static event ILContext.Manipulator MakeMenuLean
    {
        add => IL.UIManager.MakeMenuLean += value;
        remove => IL.UIManager.MakeMenuLean -= value;
    }

    public static event ILContext.Manipulator get_currentDynamicMenu
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UIManager), "get_currentDynamicMenu"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "get_currentDynamicMenu"), value);
    }

    public static event ILContext.Manipulator set_currentDynamicMenu
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UIManager), "set_currentDynamicMenu"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "set_currentDynamicMenu"), value);
    }

    public static event ILContext.Manipulator orig_get_instance
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UIManager), "orig_get_instance", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "orig_get_instance", false), value);
    }

    public static event ILContext.Manipulator LoadImage
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UIManager), "LoadImage"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UIManager), "LoadImage"), value);
    }

    public static event ILContext.Manipulator orig_Awake
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UIManager), "orig_Awake"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UIManager), "orig_Awake"), value);
    }

    public static event ILContext.Manipulator orig_Start
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UIManager), "orig_Start"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UIManager), "orig_Start"), value);
    }

    public static event ILContext.Manipulator orig_HideCurrentMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "orig_HideCurrentMenu").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "orig_HideCurrentMenu").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator UIGoToDynamicMenu
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UIManager), "UIGoToDynamicMenu"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UIManager), "UIGoToDynamicMenu"),
            value);
    }

    public static event ILContext.Manipulator GoToDynamicMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToDynamicMenu").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "GoToDynamicMenu").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator UILeaveDynamicMenu
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UIManager), "UILeaveDynamicMenu"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UIManager), "UILeaveDynamicMenu"),
            value);
    }

    public static event ILContext.Manipulator LeaveDynamicMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "LeaveDynamicMenu").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "LeaveDynamicMenu").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator UIPauseToDynamicMenu
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UIManager), "UIPauseToDynamicMenu"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "UIPauseToDynamicMenu"), value);
    }

    public static event ILContext.Manipulator PauseToDynamicMenu
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "PauseToDynamicMenu").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(UIManager), "PauseToDynamicMenu").GetStateMachineTarget(), value);
    }
}