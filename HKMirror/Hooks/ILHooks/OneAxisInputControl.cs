using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for OneAxisInputControl.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILOneAxisInputControl
{
    public static event ILContext.Manipulator get_UpdateTick
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_UpdateTick"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_UpdateTick"), value);
    }

    public static event ILContext.Manipulator set_UpdateTick
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "set_UpdateTick"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "set_UpdateTick"), value);
    }

    public static event ILContext.Manipulator PrepareForUpdate
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "PrepareForUpdate"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "PrepareForUpdate"), value);
    }

    public static event ILContext.Manipulator UpdateWithState
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "UpdateWithState"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "UpdateWithState"), value);
    }

    public static event ILContext.Manipulator UpdateWithValue
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "UpdateWithValue"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "UpdateWithValue"), value);
    }

    public static event ILContext.Manipulator UpdateWithRawValue
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "UpdateWithRawValue"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "UpdateWithRawValue"), value);
    }

    public static event ILContext.Manipulator SetValue
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "SetValue"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "SetValue"),
            value);
    }

    public static event ILContext.Manipulator ClearInputState
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "ClearInputState"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "ClearInputState"), value);
    }

    public static event ILContext.Manipulator Commit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "Commit"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "Commit"),
            value);
    }

    public static event ILContext.Manipulator CommitWithState
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "CommitWithState"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "CommitWithState"), value);
    }

    public static event ILContext.Manipulator CommitWithValue
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "CommitWithValue"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "CommitWithValue"), value);
    }

    public static event ILContext.Manipulator CommitWithSides
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "CommitWithSides"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "CommitWithSides"), value);
    }

    public static event ILContext.Manipulator get_State
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_State"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_State"),
            value);
    }

    public static event ILContext.Manipulator get_LastState
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_LastState"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_LastState"), value);
    }

    public static event ILContext.Manipulator get_Value
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_Value"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_Value"),
            value);
    }

    public static event ILContext.Manipulator get_LastValue
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_LastValue"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_LastValue"), value);
    }

    public static event ILContext.Manipulator get_RawValue
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_RawValue"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_RawValue"), value);
    }

    public static event ILContext.Manipulator get_NextRawValue
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_NextRawValue"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_NextRawValue"), value);
    }

    public static event ILContext.Manipulator get_HasInput
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_HasInput"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_HasInput"), value);
    }

    public static event ILContext.Manipulator get_HasChanged
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_HasChanged"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_HasChanged"), value);
    }

    public static event ILContext.Manipulator get_IsPressed
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_IsPressed"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_IsPressed"), value);
    }

    public static event ILContext.Manipulator get_WasPressed
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_WasPressed"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_WasPressed"), value);
    }

    public static event ILContext.Manipulator get_WasReleased
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_WasReleased"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_WasReleased"), value);
    }

    public static event ILContext.Manipulator get_WasRepeated
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_WasRepeated"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_WasRepeated"), value);
    }

    public static event ILContext.Manipulator get_Sensitivity
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_Sensitivity"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_Sensitivity"), value);
    }

    public static event ILContext.Manipulator set_Sensitivity
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "set_Sensitivity"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "set_Sensitivity"), value);
    }

    public static event ILContext.Manipulator get_LowerDeadZone
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_LowerDeadZone"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_LowerDeadZone"), value);
    }

    public static event ILContext.Manipulator set_LowerDeadZone
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "set_LowerDeadZone"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "set_LowerDeadZone"), value);
    }

    public static event ILContext.Manipulator get_UpperDeadZone
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_UpperDeadZone"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_UpperDeadZone"), value);
    }

    public static event ILContext.Manipulator set_UpperDeadZone
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "set_UpperDeadZone"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "set_UpperDeadZone"), value);
    }

    public static event ILContext.Manipulator get_StateThreshold
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_StateThreshold"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_StateThreshold"), value);
    }

    public static event ILContext.Manipulator set_StateThreshold
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "set_StateThreshold"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "set_StateThreshold"), value);
    }

    public static event ILContext.Manipulator get_IsNullControl
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_IsNullControl"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_IsNullControl"), value);
    }

    public static event ILContext.Manipulator get_Enabled
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_Enabled"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_Enabled"), value);
    }

    public static event ILContext.Manipulator set_Enabled
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "set_Enabled"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "set_Enabled"), value);
    }

    public static event ILContext.Manipulator get_EnabledInHierarchy
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_EnabledInHierarchy"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "get_EnabledInHierarchy"), value);
    }

    public static event ILContext.Manipulator op_Implicit_OneAxisInputControl
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "op_Implicit", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OneAxisInputControl), "op_Implicit", false), value);
    }
}