using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for InControlInputModule.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILInControlInputModule
{
    public static event ILContext.Manipulator get_SubmitAction
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_SubmitAction"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_SubmitAction"), value);
    }

    public static event ILContext.Manipulator set_SubmitAction
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "set_SubmitAction"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "set_SubmitAction"), value);
    }

    public static event ILContext.Manipulator get_CancelAction
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_CancelAction"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_CancelAction"), value);
    }

    public static event ILContext.Manipulator set_CancelAction
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "set_CancelAction"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "set_CancelAction"), value);
    }

    public static event ILContext.Manipulator get_MoveAction
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_MoveAction"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_MoveAction"), value);
    }

    public static event ILContext.Manipulator set_MoveAction
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "set_MoveAction"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "set_MoveAction"), value);
    }

    public static event ILContext.Manipulator UpdateModule
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "UpdateModule"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "UpdateModule"), value);
    }

    public static event ILContext.Manipulator IsModuleSupported
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "IsModuleSupported"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "IsModuleSupported"), value);
    }

    public static event ILContext.Manipulator ShouldActivateModule
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "ShouldActivateModule"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "ShouldActivateModule"), value);
    }

    public static event ILContext.Manipulator ActivateModule
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "ActivateModule"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "ActivateModule"), value);
    }

    public static event ILContext.Manipulator Process
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "Process"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "Process"),
            value);
    }

    public static event ILContext.Manipulator ProcessTouchEvents
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "ProcessTouchEvents"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "ProcessTouchEvents"), value);
    }

    public static event ILContext.Manipulator SendButtonEventToSelectedObject
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "SendButtonEventToSelectedObject"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "SendButtonEventToSelectedObject"), value);
    }

    public static event ILContext.Manipulator SendVectorEventToSelectedObject
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "SendVectorEventToSelectedObject"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "SendVectorEventToSelectedObject"), value);
    }

    public static event ILContext.Manipulator ProcessMove
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "ProcessMove"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "ProcessMove"), value);
    }

    public static event ILContext.Manipulator Update
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "Update"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "Update"),
            value);
    }

    public static event ILContext.Manipulator UpdateInputState
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "UpdateInputState"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "UpdateInputState"), value);
    }

    public static event ILContext.Manipulator set_Device
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "set_Device"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "set_Device"), value);
    }

    public static event ILContext.Manipulator get_Device
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_Device"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_Device"), value);
    }

    public static event ILContext.Manipulator get_SubmitButton
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_SubmitButton"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_SubmitButton"), value);
    }

    public static event ILContext.Manipulator get_CancelButton
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_CancelButton"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_CancelButton"), value);
    }

    public static event ILContext.Manipulator SetVectorRepeatTimer
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "SetVectorRepeatTimer"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "SetVectorRepeatTimer"), value);
    }

    public static event ILContext.Manipulator get_VectorIsPressed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_VectorIsPressed"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_VectorIsPressed"), value);
    }

    public static event ILContext.Manipulator get_VectorIsReleased
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_VectorIsReleased"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_VectorIsReleased"), value);
    }

    public static event ILContext.Manipulator get_VectorHasChanged
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_VectorHasChanged"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_VectorHasChanged"), value);
    }

    public static event ILContext.Manipulator get_VectorWasPressed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_VectorWasPressed"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_VectorWasPressed"), value);
    }

    public static event ILContext.Manipulator get_SubmitWasPressed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_SubmitWasPressed"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_SubmitWasPressed"), value);
    }

    public static event ILContext.Manipulator get_SubmitWasReleased
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_SubmitWasReleased"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_SubmitWasReleased"), value);
    }

    public static event ILContext.Manipulator get_CancelWasPressed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_CancelWasPressed"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_CancelWasPressed"), value);
    }

    public static event ILContext.Manipulator get_MouseHasMoved
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_MouseHasMoved"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_MouseHasMoved"), value);
    }

    public static event ILContext.Manipulator get_MouseButtonWasPressed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_MouseButtonWasPressed", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "get_MouseButtonWasPressed", false), value);
    }

    public static event ILContext.Manipulator SendUpdateEventToSelectedObject
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "SendUpdateEventToSelectedObject"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "SendUpdateEventToSelectedObject"), value);
    }

    public static event ILContext.Manipulator ProcessMouseEvent
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "ProcessMouseEvent"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "ProcessMouseEvent"), value);
    }

    public static event ILContext.Manipulator ProcessMouseEvent_int
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "ProcessMouseEvent"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "ProcessMouseEvent"), value);
    }

    public static event ILContext.Manipulator ProcessTouchPress
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "ProcessTouchPress"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InControlInputModule), "ProcessTouchPress"), value);
    }
}