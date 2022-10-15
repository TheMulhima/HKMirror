namespace HKMirror;

/// <summary>
///     A class that contains all (public and private) fields and methods of InputHandler allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public static class InputHandlerR
{
    public static InputHandler Instance
    {
        get => InputHandler.Instance;
        set => InputHandler.Instance = value;
    }

    public static bool verboseMode
    {
        get => ReflectionHelper.GetField<InputHandler, bool>(InputHandler.Instance, "verboseMode");
        set => ReflectionHelper.SetField(InputHandler.Instance, "verboseMode", value);
    }

    public static GameManager gm
    {
        get => ReflectionHelper.GetField<InputHandler, GameManager>(InputHandler.Instance, "gm");
        set => ReflectionHelper.SetField(InputHandler.Instance, "gm", value);
    }

    public static GameSettings gs
    {
        get => ReflectionHelper.GetField<InputHandler, GameSettings>(InputHandler.Instance, "gs");
        set => ReflectionHelper.SetField(InputHandler.Instance, "gs", value);
    }

    public static GameConfig gc
    {
        get => ReflectionHelper.GetField<InputHandler, GameConfig>(InputHandler.Instance, "gc");
        set => ReflectionHelper.SetField(InputHandler.Instance, "gc", value);
    }

    public static InputDevice gameController
    {
        get => InputHandler.Instance.gameController;
        set => InputHandler.Instance.gameController = value;
    }

    public static HeroActions inputActions
    {
        get => InputHandler.Instance.inputActions;
        set => InputHandler.Instance.inputActions = value;
    }

    public static BindingSourceType lastActiveController
    {
        get => InputHandler.Instance.lastActiveController;
        set => InputHandler.Instance.lastActiveController = value;
    }

    public static InputDeviceStyle lastInputDeviceStyle
    {
        get => InputHandler.Instance.lastInputDeviceStyle;
        set => InputHandler.Instance.lastInputDeviceStyle = value;
    }

    public static GamepadType activeGamepadType
    {
        get => InputHandler.Instance.activeGamepadType;
        set => InputHandler.Instance.activeGamepadType = value;
    }

    public static GamepadState gamepadState
    {
        get => InputHandler.Instance.gamepadState;
        set => InputHandler.Instance.gamepadState = value;
    }

    public static HeroController heroCtrl
    {
        get => ReflectionHelper.GetField<InputHandler, HeroController>(InputHandler.Instance, "heroCtrl");
        set => ReflectionHelper.SetField(InputHandler.Instance, "heroCtrl", value);
    }

    public static HeroControllerStates cState
    {
        get => ReflectionHelper.GetField<InputHandler, HeroControllerStates>(InputHandler.Instance, "cState");
        set => ReflectionHelper.SetField(InputHandler.Instance, "cState", value);
    }

    public static PlayerData playerData
    {
        get => ReflectionHelper.GetField<InputHandler, PlayerData>(InputHandler.Instance, "playerData");
        set => ReflectionHelper.SetField(InputHandler.Instance, "playerData", value);
    }

    public static OnScreenDebugInfo debugInfo
    {
        get => ReflectionHelper.GetField<InputHandler, OnScreenDebugInfo>(InputHandler.Instance, "debugInfo");
        set => ReflectionHelper.SetField(InputHandler.Instance, "debugInfo", value);
    }

    public static List<PlayerAction> nonMappableControllerActions
    {
        get => ReflectionHelper.GetField<InputHandler, List<PlayerAction>>(InputHandler.Instance,
            "nonMappableControllerActions");
        set => ReflectionHelper.SetField(InputHandler.Instance, "nonMappableControllerActions", value);
    }

    public static float inputX
    {
        get => InputHandler.Instance.inputX;
        set => InputHandler.Instance.inputX = value;
    }

    public static float inputY
    {
        get => InputHandler.Instance.inputY;
        set => InputHandler.Instance.inputY = value;
    }

    public static bool acceptingInput
    {
        get => InputHandler.Instance.acceptingInput;
        set => InputHandler.Instance.acceptingInput = value;
    }

    public static bool skippingCutscene
    {
        get => InputHandler.Instance.skippingCutscene;
        set => InputHandler.Instance.skippingCutscene = value;
    }

    public static bool readyToSkipCutscene
    {
        get => ReflectionHelper.GetField<InputHandler, bool>(InputHandler.Instance, "readyToSkipCutscene");
        set => ReflectionHelper.SetField(InputHandler.Instance, "readyToSkipCutscene", value);
    }

    public static bool controllerDetected
    {
        get => ReflectionHelper.GetField<InputHandler, bool>(InputHandler.Instance, "controllerDetected");
        set => ReflectionHelper.SetField(InputHandler.Instance, "controllerDetected", value);
    }

    public static ControllerProfile currentControllerProfile
    {
        get => ReflectionHelper.GetField<InputHandler, ControllerProfile>(InputHandler.Instance,
            "currentControllerProfile");
        set => ReflectionHelper.SetField(InputHandler.Instance, "currentControllerProfile", value);
    }

    public static bool isGameplayScene
    {
        get => ReflectionHelper.GetField<InputHandler, bool>(InputHandler.Instance, "isGameplayScene");
        set => ReflectionHelper.SetField(InputHandler.Instance, "isGameplayScene", value);
    }

    public static bool isTitleScreenScene
    {
        get => ReflectionHelper.GetField<InputHandler, bool>(InputHandler.Instance, "isTitleScreenScene");
        set => ReflectionHelper.SetField(InputHandler.Instance, "isTitleScreenScene", value);
    }

    public static bool isMenuScene
    {
        get => ReflectionHelper.GetField<InputHandler, bool>(InputHandler.Instance, "isMenuScene");
        set => ReflectionHelper.SetField(InputHandler.Instance, "isMenuScene", value);
    }

    public static bool isStagTravelScene
    {
        get => ReflectionHelper.GetField<InputHandler, bool>(InputHandler.Instance, "isStagTravelScene");
        set => ReflectionHelper.SetField(InputHandler.Instance, "isStagTravelScene", value);
    }

    public static float stagLockoutDuration
    {
        get => ReflectionHelper.GetField<InputHandler, float>(InputHandler.Instance, "stagLockoutDuration");
        set => ReflectionHelper.SetField(InputHandler.Instance, "stagLockoutDuration", value);
    }

    public static bool stagLockoutActive
    {
        get => ReflectionHelper.GetField<InputHandler, bool>(InputHandler.Instance, "stagLockoutActive");
        set => ReflectionHelper.SetField(InputHandler.Instance, "stagLockoutActive", value);
    }

    public static float skipCooldownTime
    {
        get => ReflectionHelper.GetField<InputHandler, float>(InputHandler.Instance, "skipCooldownTime");
        set => ReflectionHelper.SetField(InputHandler.Instance, "skipCooldownTime", value);
    }

    public static bool controllerPressed
    {
        get => ReflectionHelper.GetField<InputHandler, bool>(InputHandler.Instance, "controllerPressed");
        set => ReflectionHelper.SetField(InputHandler.Instance, "", value);
    }

    public static List<PlayerAction> mappableControllerActions
    {
        get => InputHandler.Instance.mappableControllerActions;
        set => ReflectionHelper.SetProperty(InputHandler.Instance, "mappableControllerActions", value);
    }

    public static List<PlayerAction> unmappedActions
    {
        get => InputHandler.Instance.unmappedActions;
        set => ReflectionHelper.SetProperty(InputHandler.Instance, "unmappedActions", value);
    }

    public static bool pauseAllowed
    {
        get => InputHandler.Instance.pauseAllowed;
        set => ReflectionHelper.SetProperty(InputHandler.Instance, "pauseAllowed", value);
    }

    public static SkipPromptMode skipMode
    {
        get => InputHandler.Instance.skipMode;
        set => ReflectionHelper.SetProperty(InputHandler.Instance, "skipMode", value);
    }

    public static void Awake()
    {
        InputHandler.Instance.Awake();
    }

    public static void Start()
    {
        InputHandler.Instance.Start();
    }

    public static void OnDestroy()
    {
        ReflectionHelper.CallMethod(InputHandler.Instance, "OnDestroy");
    }

    public static void SceneInit()
    {
        InputHandler.Instance.SceneInit();
    }

    public static void OnGUI()
    {
        ReflectionHelper.CallMethod(InputHandler.Instance, "OnGUI");
    }

    public static void SetCursorVisible(bool value)
    {
        ReflectionHelper.CallMethod(InputHandler.Instance, "SetCursorVisible", value);
    }

    public static void SetCursorEnabled(bool isEnabled)
    {
        ReflectionHelper.CallMethod(typeof(InputHandler), "SetCursorEnabled", isEnabled);
    }

    public static void Update()
    {
        ReflectionHelper.CallMethod(InputHandler.Instance, "");
    }

    public static void ControllerAttached(InputDevice inputDevice)
    {
        ReflectionHelper.CallMethod(InputHandler.Instance, "ControllerAttached", inputDevice);
    }

    public static void ControllerActivated(InputDevice inputDevice)
    {
        ReflectionHelper.CallMethod(InputHandler.Instance, "ControllerActivated", inputDevice);
    }

    public static void ControllerDetached(InputDevice inputDevice)
    {
        ReflectionHelper.CallMethod(InputHandler.Instance, "ControllerDetached", inputDevice);
    }

    public static void PlayingInput()
    {
        ReflectionHelper.CallMethod(InputHandler.Instance, "");
    }

    public static void CutsceneInput()
    {
        ReflectionHelper.CallMethod(InputHandler.Instance, "");
    }

    public static void StagCutsceneInput()
    {
        ReflectionHelper.CallMethod(InputHandler.Instance, "");
    }

    public static void BetaEndInput()
    {
        ReflectionHelper.CallMethod(InputHandler.Instance, "");
    }

    public static void AttachHeroController(HeroController heroController)
    {
        InputHandler.Instance.AttachHeroController(heroController);
    }

    public static void StopAcceptingInput()
    {
        InputHandler.Instance.StopAcceptingInput();
    }

    public static void StartAcceptingInput()
    {
        InputHandler.Instance.StartAcceptingInput();
    }

    public static void PreventPause()
    {
        InputHandler.Instance.PreventPause();
    }

    public static void AllowPause()
    {
        InputHandler.Instance.AllowPause();
    }

    public static void UpdateActiveController()
    {
        InputHandler.Instance.UpdateActiveController();
    }

    public static void StopUIInput()
    {
        InputHandler.Instance.StopUIInput();
    }

    public static void StartUIInput()
    {
        InputHandler.Instance.StartUIInput();
    }

    public static void StopMouseInput()
    {
        InputHandler.Instance.StopMouseInput();
    }

    public static void EnableMouseInput()
    {
        InputHandler.Instance.EnableMouseInput();
    }

    public static void SetSkipMode(SkipPromptMode newMode)
    {
        InputHandler.Instance.SetSkipMode(newMode);
    }

    public static void RefreshPlayerData()
    {
        InputHandler.Instance.RefreshPlayerData();
    }

    public static void ResetDefaultKeyBindings()
    {
        InputHandler.Instance.ResetDefaultKeyBindings();
    }

    public static void ResetDefaultControllerButtonBindings()
    {
        InputHandler.Instance.ResetDefaultControllerButtonBindings();
    }

    public static void ResetAllControllerButtonBindings()
    {
        InputHandler.Instance.ResetAllControllerButtonBindings();
    }

    public static void SendKeyBindingsToGameSettings()
    {
        InputHandler.Instance.SendKeyBindingsToGameSettings();
    }

    public static void SendButtonBindingsToGameSettings()
    {
        InputHandler.Instance.SendButtonBindingsToGameSettings();
    }

    public static void MapControllerButtons(GamepadType gamePadType)
    {
        InputHandler.Instance.MapControllerButtons(gamePadType);
    }

    public static void RemapUIButtons()
    {
        InputHandler.Instance.RemapUIButtons();
    }

    public static PlayerAction ActionButtonToPlayerAction(HeroActionButton actionButtonType)
    {
        return InputHandler.Instance.ActionButtonToPlayerAction(actionButtonType);
    }

    public static InputControlType GetButtonBindingForAction(PlayerAction action)
    {
        return InputHandler.Instance.GetButtonBindingForAction(action);
    }

    public static PlayerAction GetActionForMappableControllerButton(InputControlType button)
    {
        return InputHandler.Instance.GetActionForMappableControllerButton(button);
    }

    public static PlayerAction GetActionForDefaultControllerButton(InputControlType button)
    {
        return InputHandler.Instance.GetActionForDefaultControllerButton(button);
    }

    public static void PrintMappings(PlayerAction action)
    {
        InputHandler.Instance.PrintMappings(action);
    }

    public static string ActionButtonLocalizedKey(PlayerAction action)
    {
        return InputHandler.Instance.ActionButtonLocalizedKey(action);
    }

    public static string ActionButtonLocalizedKey(string actionName)
    {
        return InputHandler.Instance.ActionButtonLocalizedKey(actionName);
    }

    public static void StopCutsceneInput()
    {
        ReflectionHelper.CallMethod(InputHandler.Instance, "");
    }

    public static void UnlockStagInput()
    {
        ReflectionHelper.CallMethod(InputHandler.Instance, "");
    }

    public static IEnumerator SetupGamepadUIInputActions()
    {
        return ReflectionHelper.CallMethod<InputHandler, IEnumerator>(InputHandler.Instance,
            "SetupGamepadUIInputActions");
    }

    public static void RemoveGamepadUIInputActions()
    {
        ReflectionHelper.CallMethod(InputHandler.Instance, "");
    }

    public static void DestroyCurrentActionSet()
    {
        ReflectionHelper.CallMethod(InputHandler.Instance, "");
    }

    public static void SetActiveGamepadType(InputDevice inputDevice)
    {
        InputHandler.Instance.SetActiveGamepadType(inputDevice);
    }

    public static void MapDefaultKeyboardLayout()
    {
        ReflectionHelper.CallMethod(InputHandler.Instance, "");
    }

    public static void MapKeyboardLayoutFromGameSettings()
    {
        ReflectionHelper.CallMethod(InputHandler.Instance, "");
    }

    public static void AddKeyBinding(PlayerAction action, string savedBinding)
    {
        ReflectionHelper.CallMethod(typeof(InputHandler), "AddKeyBinding", action, savedBinding);
    }

    public static void SetupNonMappableBindings()
    {
        ReflectionHelper.CallMethod(InputHandler.Instance, "");
    }

    public static void SetupMappableControllerBindingsList()
    {
        ReflectionHelper.CallMethod(InputHandler.Instance, "");
    }
}