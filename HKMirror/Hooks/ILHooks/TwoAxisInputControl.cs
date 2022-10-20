using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TwoAxisInputControl.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTwoAxisInputControl
{
    public static event ILContext.Manipulator get_X
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_X"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_X"),
            value);
    }

    public static event ILContext.Manipulator set_X
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "set_X"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "set_X"),
            value);
    }

    public static event ILContext.Manipulator get_Y
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_Y"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_Y"),
            value);
    }

    public static event ILContext.Manipulator set_Y
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "set_Y"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "set_Y"),
            value);
    }

    public static event ILContext.Manipulator get_Left
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_Left"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_Left"),
            value);
    }

    public static event ILContext.Manipulator set_Left
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "set_Left"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "set_Left"),
            value);
    }

    public static event ILContext.Manipulator get_Right
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_Right"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_Right"),
            value);
    }

    public static event ILContext.Manipulator set_Right
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "set_Right"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "set_Right"),
            value);
    }

    public static event ILContext.Manipulator get_Up
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_Up"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_Up"),
            value);
    }

    public static event ILContext.Manipulator set_Up
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "set_Up"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "set_Up"),
            value);
    }

    public static event ILContext.Manipulator get_Down
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_Down"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_Down"),
            value);
    }

    public static event ILContext.Manipulator set_Down
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "set_Down"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "set_Down"),
            value);
    }

    public static event ILContext.Manipulator get_UpdateTick
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_UpdateTick"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_UpdateTick"), value);
    }

    public static event ILContext.Manipulator set_UpdateTick
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "set_UpdateTick"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "set_UpdateTick"), value);
    }

    public static event ILContext.Manipulator ClearInputState
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "ClearInputState"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "ClearInputState"), value);
    }

    public static event ILContext.Manipulator Filter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "Filter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "Filter"),
            value);
    }

    public static event ILContext.Manipulator UpdateWithAxes
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "UpdateWithAxes"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "UpdateWithAxes"), value);
    }

    public static event ILContext.Manipulator get_Sensitivity
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_Sensitivity"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_Sensitivity"), value);
    }

    public static event ILContext.Manipulator set_Sensitivity
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "set_Sensitivity"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "set_Sensitivity"), value);
    }

    public static event ILContext.Manipulator get_StateThreshold
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_StateThreshold"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_StateThreshold"), value);
    }

    public static event ILContext.Manipulator set_StateThreshold
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "set_StateThreshold"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "set_StateThreshold"), value);
    }

    public static event ILContext.Manipulator get_LowerDeadZone
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_LowerDeadZone"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_LowerDeadZone"), value);
    }

    public static event ILContext.Manipulator set_LowerDeadZone
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "set_LowerDeadZone"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "set_LowerDeadZone"), value);
    }

    public static event ILContext.Manipulator get_UpperDeadZone
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_UpperDeadZone"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_UpperDeadZone"), value);
    }

    public static event ILContext.Manipulator set_UpperDeadZone
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "set_UpperDeadZone"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "set_UpperDeadZone"), value);
    }

    public static event ILContext.Manipulator get_State
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_State"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_State"),
            value);
    }

    public static event ILContext.Manipulator get_LastState
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_LastState"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_LastState"), value);
    }

    public static event ILContext.Manipulator get_Value
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_Value"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_Value"),
            value);
    }

    public static event ILContext.Manipulator get_LastValue
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_LastValue"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_LastValue"), value);
    }

    public static event ILContext.Manipulator get_Vector
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_Vector"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_Vector"), value);
    }

    public static event ILContext.Manipulator get_HasChanged
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_HasChanged"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_HasChanged"), value);
    }

    public static event ILContext.Manipulator set_HasChanged
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "set_HasChanged"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "set_HasChanged"), value);
    }

    public static event ILContext.Manipulator get_IsPressed
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_IsPressed"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_IsPressed"), value);
    }

    public static event ILContext.Manipulator get_WasPressed
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_WasPressed"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_WasPressed"), value);
    }

    public static event ILContext.Manipulator get_WasReleased
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_WasReleased"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_WasReleased"), value);
    }

    public static event ILContext.Manipulator get_Angle
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_Angle"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "get_Angle"),
            value);
    }

    public static event ILContext.Manipulator op_Implicit_TwoAxisInputControl
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "op_Implicit", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TwoAxisInputControl), "op_Implicit", false), value);
    }
}