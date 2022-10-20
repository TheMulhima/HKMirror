using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for InputControlMapping.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILInputControlMapping
{
    public static event ILContext.Manipulator get_Name
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "get_Name"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "get_Name"),
            value);
    }

    public static event ILContext.Manipulator set_Name
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "set_Name"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "set_Name"),
            value);
    }

    public static event ILContext.Manipulator get_Invert
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "get_Invert"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "get_Invert"), value);
    }

    public static event ILContext.Manipulator set_Invert
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "set_Invert"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "set_Invert"), value);
    }

    public static event ILContext.Manipulator get_Scale
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "get_Scale"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "get_Scale"),
            value);
    }

    public static event ILContext.Manipulator set_Scale
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "set_Scale"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "set_Scale"),
            value);
    }

    public static event ILContext.Manipulator get_Raw
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "get_Raw"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "get_Raw"),
            value);
    }

    public static event ILContext.Manipulator set_Raw
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "set_Raw"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "set_Raw"),
            value);
    }

    public static event ILContext.Manipulator get_Passive
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "get_Passive"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "get_Passive"), value);
    }

    public static event ILContext.Manipulator set_Passive
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "set_Passive"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "set_Passive"), value);
    }

    public static event ILContext.Manipulator get_IgnoreInitialZeroValue
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "get_IgnoreInitialZeroValue"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "get_IgnoreInitialZeroValue"), value);
    }

    public static event ILContext.Manipulator set_IgnoreInitialZeroValue
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "set_IgnoreInitialZeroValue"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "set_IgnoreInitialZeroValue"), value);
    }

    public static event ILContext.Manipulator get_Sensitivity
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "get_Sensitivity"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "get_Sensitivity"), value);
    }

    public static event ILContext.Manipulator set_Sensitivity
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "set_Sensitivity"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "set_Sensitivity"), value);
    }

    public static event ILContext.Manipulator get_LowerDeadZone
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "get_LowerDeadZone"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "get_LowerDeadZone"), value);
    }

    public static event ILContext.Manipulator set_LowerDeadZone
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "set_LowerDeadZone"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "set_LowerDeadZone"), value);
    }

    public static event ILContext.Manipulator get_UpperDeadZone
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "get_UpperDeadZone"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "get_UpperDeadZone"), value);
    }

    public static event ILContext.Manipulator set_UpperDeadZone
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "set_UpperDeadZone"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "set_UpperDeadZone"), value);
    }

    public static event ILContext.Manipulator get_Source
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "get_Source"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "get_Source"), value);
    }

    public static event ILContext.Manipulator set_Source
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "set_Source"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "set_Source"), value);
    }

    public static event ILContext.Manipulator get_Target
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "get_Target"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "get_Target"), value);
    }

    public static event ILContext.Manipulator set_Target
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "set_Target"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "set_Target"), value);
    }

    public static event ILContext.Manipulator get_SourceRange
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "get_SourceRange"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "get_SourceRange"), value);
    }

    public static event ILContext.Manipulator set_SourceRange
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "set_SourceRange"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "set_SourceRange"), value);
    }

    public static event ILContext.Manipulator get_TargetRange
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "get_TargetRange"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "get_TargetRange"), value);
    }

    public static event ILContext.Manipulator set_TargetRange
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "set_TargetRange"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "set_TargetRange"), value);
    }

    public static event ILContext.Manipulator ApplyToValue
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "ApplyToValue"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(InputControlMapping), "ApplyToValue"), value);
    }
}