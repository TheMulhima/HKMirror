using MonoMod.RuntimeDetour.HookGen;
namespace HKMirror.Hooks.ILHooks;
/// <summary>
/// Contains all correct IL Hooks for InControlInputModule,
/// Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
/// Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILInControlInputModule
{
public static event ILContext.Manipulator get_SubmitAction
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_SubmitAction", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_SubmitAction", true), value);
}
public static event ILContext.Manipulator set_SubmitAction
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "set_SubmitAction", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "set_SubmitAction", true), value);
}
public static event ILContext.Manipulator get_CancelAction
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_CancelAction", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_CancelAction", true), value);
}
public static event ILContext.Manipulator set_CancelAction
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "set_CancelAction", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "set_CancelAction", true), value);
}
public static event ILContext.Manipulator get_MoveAction
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_MoveAction", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_MoveAction", true), value);
}
public static event ILContext.Manipulator set_MoveAction
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "set_MoveAction", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "set_MoveAction", true), value);
}
public static event ILContext.Manipulator UpdateModule
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "UpdateModule", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "UpdateModule", true), value);
}
public static event ILContext.Manipulator IsModuleSupported
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "IsModuleSupported", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "IsModuleSupported", true), value);
}
public static event ILContext.Manipulator ShouldActivateModule
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "ShouldActivateModule", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "ShouldActivateModule", true), value);
}
public static event ILContext.Manipulator ActivateModule
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "ActivateModule", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "ActivateModule", true), value);
}
public static event ILContext.Manipulator Process
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "Process", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "Process", true), value);
}
public static event ILContext.Manipulator ProcessTouchEvents
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "ProcessTouchEvents", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "ProcessTouchEvents", true), value);
}
public static event ILContext.Manipulator SendButtonEventToSelectedObject
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "SendButtonEventToSelectedObject", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "SendButtonEventToSelectedObject", true), value);
}
public static event ILContext.Manipulator SendVectorEventToSelectedObject
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "SendVectorEventToSelectedObject", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "SendVectorEventToSelectedObject", true), value);
}
public static event ILContext.Manipulator ProcessMove
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "ProcessMove", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "ProcessMove", true), value);
}
public static event ILContext.Manipulator Update
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "Update", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "Update", true), value);
}
public static event ILContext.Manipulator UpdateInputState
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "UpdateInputState", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "UpdateInputState", true), value);
}
public static event ILContext.Manipulator set_Device
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "set_Device", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "set_Device", true), value);
}
public static event ILContext.Manipulator get_Device
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_Device", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_Device", true), value);
}
public static event ILContext.Manipulator get_SubmitButton
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_SubmitButton", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_SubmitButton", true), value);
}
public static event ILContext.Manipulator get_CancelButton
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_CancelButton", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_CancelButton", true), value);
}
public static event ILContext.Manipulator SetVectorRepeatTimer
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "SetVectorRepeatTimer", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "SetVectorRepeatTimer", true), value);
}
public static event ILContext.Manipulator get_VectorIsPressed
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_VectorIsPressed", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_VectorIsPressed", true), value);
}
public static event ILContext.Manipulator get_VectorIsReleased
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_VectorIsReleased", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_VectorIsReleased", true), value);
}
public static event ILContext.Manipulator get_VectorHasChanged
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_VectorHasChanged", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_VectorHasChanged", true), value);
}
public static event ILContext.Manipulator get_VectorWasPressed
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_VectorWasPressed", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_VectorWasPressed", true), value);
}
public static event ILContext.Manipulator get_SubmitWasPressed
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_SubmitWasPressed", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_SubmitWasPressed", true), value);
}
public static event ILContext.Manipulator get_SubmitWasReleased
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_SubmitWasReleased", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_SubmitWasReleased", true), value);
}
public static event ILContext.Manipulator get_CancelWasPressed
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_CancelWasPressed", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_CancelWasPressed", true), value);
}
public static event ILContext.Manipulator get_MouseHasMoved
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_MouseHasMoved", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_MouseHasMoved", true), value);
}
public static event ILContext.Manipulator get_MouseButtonWasPressed
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_MouseButtonWasPressed", false), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "get_MouseButtonWasPressed", false), value);
}
public static event ILContext.Manipulator SendUpdateEventToSelectedObject
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "SendUpdateEventToSelectedObject", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "SendUpdateEventToSelectedObject", true), value);
}
public static event ILContext.Manipulator ProcessMouseEvent
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "ProcessMouseEvent", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "ProcessMouseEvent", true), value);
}
public static event ILContext.Manipulator ProcessMouseEvent_int
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "ProcessMouseEvent", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "ProcessMouseEvent", true), value);
}
public static event ILContext.Manipulator ProcessMousePress
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "ProcessMousePress", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "ProcessMousePress", true), value);
}
public static event ILContext.Manipulator ProcessTouchPress
{
add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "ProcessTouchPress", true), value);
remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControl.InControlInputModule), "ProcessTouchPress", true), value);
}
}
