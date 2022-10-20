using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for InputHandler.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILInputHandler
{
    public static event ILContext.Manipulator get_mappableControllerActions
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputHandler), "get_mappableControllerActions"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputHandler), "get_mappableControllerActions"), value);
    }

    public static event ILContext.Manipulator set_mappableControllerActions
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputHandler), "set_mappableControllerActions"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputHandler), "set_mappableControllerActions"), value);
    }

    public static event ILContext.Manipulator get_unmappedActions
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputHandler), "get_unmappedActions"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputHandler), "get_unmappedActions"), value);
    }

    public static event ILContext.Manipulator set_unmappedActions
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputHandler), "set_unmappedActions"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputHandler), "set_unmappedActions"), value);
    }

    public static event ILContext.Manipulator get_pauseAllowed
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputHandler), "get_pauseAllowed"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputHandler), "get_pauseAllowed"),
            value);
    }

    public static event ILContext.Manipulator set_pauseAllowed
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputHandler), "set_pauseAllowed"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputHandler), "set_pauseAllowed"),
            value);
    }

    public static event ILContext.Manipulator get_skipMode
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputHandler), "get_skipMode"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputHandler), "get_skipMode"),
            value);
    }

    public static event ILContext.Manipulator set_skipMode
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputHandler), "set_skipMode"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputHandler), "set_skipMode"),
            value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.InputHandler.Awake += value;
        remove => IL.InputHandler.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.InputHandler.Start += value;
        remove => IL.InputHandler.Start -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.InputHandler.OnDestroy += value;
        remove => IL.InputHandler.OnDestroy -= value;
    }

    public static event ILContext.Manipulator SceneInit
    {
        add => IL.InputHandler.SceneInit += value;
        remove => IL.InputHandler.SceneInit -= value;
    }

    public static event ILContext.Manipulator OnGUI
    {
        add => IL.InputHandler.OnGUI += value;
        remove => IL.InputHandler.OnGUI -= value;
    }

    public static event ILContext.Manipulator SetCursorVisible
    {
        add => IL.InputHandler.SetCursorVisible += value;
        remove => IL.InputHandler.SetCursorVisible -= value;
    }

    public static event ILContext.Manipulator SetCursorEnabled
    {
        add => IL.InputHandler.SetCursorEnabled += value;
        remove => IL.InputHandler.SetCursorEnabled -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.InputHandler.Update += value;
        remove => IL.InputHandler.Update -= value;
    }

    public static event ILContext.Manipulator ControllerAttached
    {
        add => IL.InputHandler.ControllerAttached += value;
        remove => IL.InputHandler.ControllerAttached -= value;
    }

    public static event ILContext.Manipulator ControllerActivated
    {
        add => IL.InputHandler.ControllerActivated += value;
        remove => IL.InputHandler.ControllerActivated -= value;
    }

    public static event ILContext.Manipulator ControllerDetached
    {
        add => IL.InputHandler.ControllerDetached += value;
        remove => IL.InputHandler.ControllerDetached -= value;
    }

    public static event ILContext.Manipulator PlayingInput
    {
        add => IL.InputHandler.PlayingInput += value;
        remove => IL.InputHandler.PlayingInput -= value;
    }

    public static event ILContext.Manipulator CutsceneInput
    {
        add => IL.InputHandler.CutsceneInput += value;
        remove => IL.InputHandler.CutsceneInput -= value;
    }

    public static event ILContext.Manipulator StagCutsceneInput
    {
        add => IL.InputHandler.StagCutsceneInput += value;
        remove => IL.InputHandler.StagCutsceneInput -= value;
    }

    public static event ILContext.Manipulator BetaEndInput
    {
        add => IL.InputHandler.BetaEndInput += value;
        remove => IL.InputHandler.BetaEndInput -= value;
    }

    public static event ILContext.Manipulator AttachHeroController
    {
        add => IL.InputHandler.AttachHeroController += value;
        remove => IL.InputHandler.AttachHeroController -= value;
    }

    public static event ILContext.Manipulator StopAcceptingInput
    {
        add => IL.InputHandler.StopAcceptingInput += value;
        remove => IL.InputHandler.StopAcceptingInput -= value;
    }

    public static event ILContext.Manipulator StartAcceptingInput
    {
        add => IL.InputHandler.StartAcceptingInput += value;
        remove => IL.InputHandler.StartAcceptingInput -= value;
    }

    public static event ILContext.Manipulator PreventPause
    {
        add => IL.InputHandler.PreventPause += value;
        remove => IL.InputHandler.PreventPause -= value;
    }

    public static event ILContext.Manipulator AllowPause
    {
        add => IL.InputHandler.AllowPause += value;
        remove => IL.InputHandler.AllowPause -= value;
    }

    public static event ILContext.Manipulator UpdateActiveController
    {
        add => IL.InputHandler.UpdateActiveController += value;
        remove => IL.InputHandler.UpdateActiveController -= value;
    }

    public static event ILContext.Manipulator StopUIInput
    {
        add => IL.InputHandler.StopUIInput += value;
        remove => IL.InputHandler.StopUIInput -= value;
    }

    public static event ILContext.Manipulator StartUIInput
    {
        add => IL.InputHandler.StartUIInput += value;
        remove => IL.InputHandler.StartUIInput -= value;
    }

    public static event ILContext.Manipulator StopMouseInput
    {
        add => IL.InputHandler.StopMouseInput += value;
        remove => IL.InputHandler.StopMouseInput -= value;
    }

    public static event ILContext.Manipulator EnableMouseInput
    {
        add => IL.InputHandler.EnableMouseInput += value;
        remove => IL.InputHandler.EnableMouseInput -= value;
    }

    public static event ILContext.Manipulator SetSkipMode
    {
        add => IL.InputHandler.SetSkipMode += value;
        remove => IL.InputHandler.SetSkipMode -= value;
    }

    public static event ILContext.Manipulator RefreshPlayerData
    {
        add => IL.InputHandler.RefreshPlayerData += value;
        remove => IL.InputHandler.RefreshPlayerData -= value;
    }

    public static event ILContext.Manipulator ResetDefaultKeyBindings
    {
        add => IL.InputHandler.ResetDefaultKeyBindings += value;
        remove => IL.InputHandler.ResetDefaultKeyBindings -= value;
    }

    public static event ILContext.Manipulator ResetDefaultControllerButtonBindings
    {
        add => IL.InputHandler.ResetDefaultControllerButtonBindings += value;
        remove => IL.InputHandler.ResetDefaultControllerButtonBindings -= value;
    }

    public static event ILContext.Manipulator ResetAllControllerButtonBindings
    {
        add => IL.InputHandler.ResetAllControllerButtonBindings += value;
        remove => IL.InputHandler.ResetAllControllerButtonBindings -= value;
    }

    public static event ILContext.Manipulator SendKeyBindingsToGameSettings
    {
        add => IL.InputHandler.SendKeyBindingsToGameSettings += value;
        remove => IL.InputHandler.SendKeyBindingsToGameSettings -= value;
    }

    public static event ILContext.Manipulator SendButtonBindingsToGameSettings
    {
        add => IL.InputHandler.SendButtonBindingsToGameSettings += value;
        remove => IL.InputHandler.SendButtonBindingsToGameSettings -= value;
    }

    public static event ILContext.Manipulator MapControllerButtons
    {
        add => IL.InputHandler.MapControllerButtons += value;
        remove => IL.InputHandler.MapControllerButtons -= value;
    }

    public static event ILContext.Manipulator RemapUIButtons
    {
        add => IL.InputHandler.RemapUIButtons += value;
        remove => IL.InputHandler.RemapUIButtons -= value;
    }

    public static event ILContext.Manipulator ActionButtonToPlayerAction
    {
        add => IL.InputHandler.ActionButtonToPlayerAction += value;
        remove => IL.InputHandler.ActionButtonToPlayerAction -= value;
    }

    public static event ILContext.Manipulator GetButtonBindingForAction
    {
        add => IL.InputHandler.GetButtonBindingForAction += value;
        remove => IL.InputHandler.GetButtonBindingForAction -= value;
    }

    public static event ILContext.Manipulator GetActionForMappableControllerButton
    {
        add => IL.InputHandler.GetActionForMappableControllerButton += value;
        remove => IL.InputHandler.GetActionForMappableControllerButton -= value;
    }

    public static event ILContext.Manipulator GetActionForDefaultControllerButton
    {
        add => IL.InputHandler.GetActionForDefaultControllerButton += value;
        remove => IL.InputHandler.GetActionForDefaultControllerButton -= value;
    }

    public static event ILContext.Manipulator PrintMappings
    {
        add => IL.InputHandler.PrintMappings += value;
        remove => IL.InputHandler.PrintMappings -= value;
    }

    public static event ILContext.Manipulator ActionButtonLocalizedKey_PlayerAction
    {
        add => IL.InputHandler.ActionButtonLocalizedKey_PlayerAction += value;
        remove => IL.InputHandler.ActionButtonLocalizedKey_PlayerAction -= value;
    }

    public static event ILContext.Manipulator ActionButtonLocalizedKey_string
    {
        add => IL.InputHandler.ActionButtonLocalizedKey_string += value;
        remove => IL.InputHandler.ActionButtonLocalizedKey_string -= value;
    }

    public static event ILContext.Manipulator StopCutsceneInput
    {
        add => IL.InputHandler.StopCutsceneInput += value;
        remove => IL.InputHandler.StopCutsceneInput -= value;
    }

    public static event ILContext.Manipulator UnlockStagInput
    {
        add => IL.InputHandler.UnlockStagInput += value;
        remove => IL.InputHandler.UnlockStagInput -= value;
    }

    public static event ILContext.Manipulator SetupGamepadUIInputActions
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputHandler), "SetupGamepadUIInputActions").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputHandler), "SetupGamepadUIInputActions").GetStateMachineTarget(),
            value);
    }

    public static event ILContext.Manipulator RemoveGamepadUIInputActions
    {
        add => IL.InputHandler.RemoveGamepadUIInputActions += value;
        remove => IL.InputHandler.RemoveGamepadUIInputActions -= value;
    }

    public static event ILContext.Manipulator DestroyCurrentActionSet
    {
        add => IL.InputHandler.DestroyCurrentActionSet += value;
        remove => IL.InputHandler.DestroyCurrentActionSet -= value;
    }

    public static event ILContext.Manipulator SetActiveGamepadType
    {
        add => IL.InputHandler.SetActiveGamepadType += value;
        remove => IL.InputHandler.SetActiveGamepadType -= value;
    }

    public static event ILContext.Manipulator MapDefaultKeyboardLayout
    {
        add => IL.InputHandler.MapDefaultKeyboardLayout += value;
        remove => IL.InputHandler.MapDefaultKeyboardLayout -= value;
    }

    public static event ILContext.Manipulator MapKeyboardLayoutFromGameSettings
    {
        add => IL.InputHandler.MapKeyboardLayoutFromGameSettings += value;
        remove => IL.InputHandler.MapKeyboardLayoutFromGameSettings -= value;
    }

    public static event ILContext.Manipulator AddKeyBinding
    {
        add => IL.InputHandler.AddKeyBinding += value;
        remove => IL.InputHandler.AddKeyBinding -= value;
    }

    public static event ILContext.Manipulator SetupNonMappableBindings
    {
        add => IL.InputHandler.SetupNonMappableBindings += value;
        remove => IL.InputHandler.SetupNonMappableBindings -= value;
    }

    public static event ILContext.Manipulator SetupMappableControllerBindingsList
    {
        add => IL.InputHandler.SetupMappableControllerBindingsList += value;
        remove => IL.InputHandler.SetupMappableControllerBindingsList -= value;
    }
}