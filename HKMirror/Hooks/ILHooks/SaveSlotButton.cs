using MonoMod.RuntimeDetour.HookGen;
using UnityEngine.UI;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SaveSlotButton,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSaveSlotButton
{
    public static event ILContext.Manipulator set_state
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "set_state"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "set_state"),
            value);
    }

    public static event ILContext.Manipulator get_SaveSlotIndex
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "get_SaveSlotIndex"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "get_SaveSlotIndex"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "Awake"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "Awake"), value);
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "OnEnable"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "OnEnable"),
            value);
    }

    public static event ILContext.Manipulator Start
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "Start"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "Start"), value);
    }

    public static event ILContext.Manipulator Prepare
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "Prepare"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "Prepare"), value);
    }

    public static event ILContext.Manipulator ClearCache
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "ClearCache"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "ClearCache"),
            value);
    }

    public static event ILContext.Manipulator ChangeSaveFileState
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "ChangeSaveFileState"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "ChangeSaveFileState"), value);
    }

    public static event ILContext.Manipulator OnSubmit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "OnSubmit"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "OnSubmit"),
            value);
    }

    public static event ILContext.Manipulator ReloadCorrupted
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "ReloadCorrupted").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "ReloadCorrupted").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator OnPointerClick
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "OnPointerClick"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "OnPointerClick"),
            value);
    }

    public static event ILContext.Manipulator OnSelect
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "OnSelect"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "OnSelect"),
            value);
    }

    public static event ILContext.Manipulator OnDeselect
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "OnDeselect"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "OnDeselect"),
            value);
    }

    public static event ILContext.Manipulator ShowRelevantModeForSaveFileState
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "ShowRelevantModeForSaveFileState"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "ShowRelevantModeForSaveFileState"), value);
    }

    public static event ILContext.Manipulator HideSaveSlot
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "HideSaveSlot"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "HideSaveSlot"),
            value);
    }

    public static event ILContext.Manipulator ClearSavePrompt
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "ClearSavePrompt"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "ClearSavePrompt"), value);
    }

    public static event ILContext.Manipulator CancelClearSave
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "CancelClearSave"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "CancelClearSave"), value);
    }

    public static event ILContext.Manipulator ClearSaveFile
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "ClearSaveFile"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "ClearSaveFile"),
            value);
    }

    public static event ILContext.Manipulator FadeInCanvasGroupAfterDelay
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "FadeInCanvasGroupAfterDelay")
                .GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "FadeInCanvasGroupAfterDelay")
                .GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator AnimateToSlotState
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "AnimateToSlotState").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "AnimateToSlotState").GetStateMachineTarget(),
            value);
    }

    public static event ILContext.Manipulator PresentSaveSlot
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "PresentSaveSlot"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "PresentSaveSlot"), value);
    }

    public static event ILContext.Manipulator SetupNavs
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "SetupNavs"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "SetupNavs"),
            value);
    }

    public static event ILContext.Manipulator ValidateDeselect
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "ValidateDeselect").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SaveSlotButton), "ValidateDeselect").GetStateMachineTarget(), value);
    }
}