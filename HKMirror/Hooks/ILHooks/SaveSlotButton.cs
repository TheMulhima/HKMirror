using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.ILHooks;
/// <summary>
/// Contains all correct IL Hooks for SaveSlotButton,
/// Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
/// Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSaveSlotButton
{
public static event ILContext.Manipulator set_state
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "set_state", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "set_state", true), value);
}
public static event ILContext.Manipulator get_SaveSlotIndex
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "get_SaveSlotIndex", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "get_SaveSlotIndex", true), value);
}
public static event ILContext.Manipulator Awake
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "Awake", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "Awake", true), value);
}
public static event ILContext.Manipulator OnEnable
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "OnEnable", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "OnEnable", true), value);
}
public static event ILContext.Manipulator Start
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "Start", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "Start", true), value);
}
public static event ILContext.Manipulator Prepare
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "Prepare", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "Prepare", true), value);
}
public static event ILContext.Manipulator ClearCache
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "ClearCache", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "ClearCache", true), value);
}
public static event ILContext.Manipulator ChangeSaveFileState
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "ChangeSaveFileState", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "ChangeSaveFileState", true), value);
}
public static event ILContext.Manipulator OnSubmit
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "OnSubmit", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "OnSubmit", true), value);
}
public static event ILContext.Manipulator ReloadCorrupted
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "ReloadCorrupted", true).GetStateMachineTarget(), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "ReloadCorrupted", true).GetStateMachineTarget(), value);
}
public static event ILContext.Manipulator OnPointerClick
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "OnPointerClick", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "OnPointerClick", true), value);
}
public static event ILContext.Manipulator OnSelect
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "OnSelect", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "OnSelect", true), value);
}
public static event ILContext.Manipulator OnDeselect
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "OnDeselect", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "OnDeselect", true), value);
}
public static event ILContext.Manipulator ShowRelevantModeForSaveFileState
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "ShowRelevantModeForSaveFileState", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "ShowRelevantModeForSaveFileState", true), value);
}
public static event ILContext.Manipulator HideSaveSlot
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "HideSaveSlot", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "HideSaveSlot", true), value);
}
public static event ILContext.Manipulator ClearSavePrompt
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "ClearSavePrompt", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "ClearSavePrompt", true), value);
}
public static event ILContext.Manipulator CancelClearSave
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "CancelClearSave", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "CancelClearSave", true), value);
}
public static event ILContext.Manipulator ClearSaveFile
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "ClearSaveFile", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "ClearSaveFile", true), value);
}
public static event ILContext.Manipulator FadeInCanvasGroupAfterDelay
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "FadeInCanvasGroupAfterDelay", true).GetStateMachineTarget(), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "FadeInCanvasGroupAfterDelay", true).GetStateMachineTarget(), value);
}
public static event ILContext.Manipulator AnimateToSlotState
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "AnimateToSlotState", true).GetStateMachineTarget(), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "AnimateToSlotState", true).GetStateMachineTarget(), value);
}
public static event ILContext.Manipulator PresentSaveSlot
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "PresentSaveSlot", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "PresentSaveSlot", true), value);
}
public static event ILContext.Manipulator SetupNavs
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "SetupNavs", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "SetupNavs", true), value);
}
public static event ILContext.Manipulator ValidateDeselect
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "ValidateDeselect", true).GetStateMachineTarget(), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(UnityEngine.UI.SaveSlotButton), "ValidateDeselect", true).GetStateMachineTarget(), value);
}
}
