using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for HollowKnightInputModule.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILHollowKnightInputModule
{
    public static event ILContext.Manipulator get_SubmitAction
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "get_SubmitAction"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "get_SubmitAction"), value);
    }

    public static event ILContext.Manipulator set_SubmitAction
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "set_SubmitAction"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "set_SubmitAction"), value);
    }

    public static event ILContext.Manipulator get_CancelAction
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "get_CancelAction"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "get_CancelAction"), value);
    }

    public static event ILContext.Manipulator set_CancelAction
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "set_CancelAction"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "set_CancelAction"), value);
    }

    public static event ILContext.Manipulator get_JumpAction
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "get_JumpAction"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "get_JumpAction"), value);
    }

    public static event ILContext.Manipulator set_JumpAction
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "set_JumpAction"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "set_JumpAction"), value);
    }

    public static event ILContext.Manipulator get_CastAction
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "get_CastAction"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "get_CastAction"), value);
    }

    public static event ILContext.Manipulator set_CastAction
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "set_CastAction"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "set_CastAction"), value);
    }

    public static event ILContext.Manipulator get_AttackAction
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "get_AttackAction"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "get_AttackAction"), value);
    }

    public static event ILContext.Manipulator set_AttackAction
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "set_AttackAction"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "set_AttackAction"), value);
    }

    public static event ILContext.Manipulator get_MoveAction
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "get_MoveAction"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "get_MoveAction"), value);
    }

    public static event ILContext.Manipulator set_MoveAction
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "set_MoveAction"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "set_MoveAction"), value);
    }

    public static event ILContext.Manipulator UpdateModule
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "UpdateModule"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "UpdateModule"), value);
    }

    public static event ILContext.Manipulator IsModuleSupported
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "IsModuleSupported"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "IsModuleSupported"), value);
    }

    public static event ILContext.Manipulator ShouldActivateModule
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "ShouldActivateModule"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "ShouldActivateModule"), value);
    }

    public static event ILContext.Manipulator ActivateModule
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "ActivateModule"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "ActivateModule"), value);
    }

    public static event ILContext.Manipulator Process
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "Process"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "Process"), value);
    }

    public static event ILContext.Manipulator SendButtonEventToSelectedObject
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "SendButtonEventToSelectedObject"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "SendButtonEventToSelectedObject"), value);
    }

    public static event ILContext.Manipulator SendVectorEventToSelectedObject
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "SendVectorEventToSelectedObject"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "SendVectorEventToSelectedObject"), value);
    }

    public static event ILContext.Manipulator ProcessMove
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "ProcessMove"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "ProcessMove"), value);
    }

    public static event ILContext.Manipulator Update
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "Update"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "Update"), value);
    }

    public static event ILContext.Manipulator UpdateInputState
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "UpdateInputState"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "UpdateInputState"), value);
    }

    public static event ILContext.Manipulator set_Device
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "set_Device"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "set_Device"), value);
    }

    public static event ILContext.Manipulator get_Device
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "get_Device"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "get_Device"), value);
    }

    public static event ILContext.Manipulator SetVectorRepeatTimer
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "SetVectorRepeatTimer"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "SetVectorRepeatTimer"), value);
    }

    public static event ILContext.Manipulator get_VectorIsPressed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "get_VectorIsPressed"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "get_VectorIsPressed"), value);
    }

    public static event ILContext.Manipulator get_VectorIsReleased
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "get_VectorIsReleased"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "get_VectorIsReleased"), value);
    }

    public static event ILContext.Manipulator get_VectorHasChanged
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "get_VectorHasChanged"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "get_VectorHasChanged"), value);
    }

    public static event ILContext.Manipulator get_VectorWasPressed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "get_VectorWasPressed"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "get_VectorWasPressed"), value);
    }

    public static event ILContext.Manipulator get_MouseHasMoved
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "get_MouseHasMoved"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "get_MouseHasMoved"), value);
    }

    public static event ILContext.Manipulator get_MouseButtonIsPressed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "get_MouseButtonIsPressed"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HollowKnightInputModule), "get_MouseButtonIsPressed"), value);
    }
}