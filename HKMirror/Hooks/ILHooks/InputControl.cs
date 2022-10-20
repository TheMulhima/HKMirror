using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for InputControl.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILInputControl
{
    public static event ILContext.Manipulator get_Handle
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputControl), "get_Handle"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputControl), "get_Handle"),
            value);
    }

    public static event ILContext.Manipulator set_Handle
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputControl), "set_Handle"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputControl), "set_Handle"),
            value);
    }

    public static event ILContext.Manipulator get_Target
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputControl), "get_Target"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputControl), "get_Target"),
            value);
    }

    public static event ILContext.Manipulator set_Target
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputControl), "set_Target"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputControl), "set_Target"),
            value);
    }

    public static event ILContext.Manipulator get_IsButton
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputControl), "get_IsButton"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputControl), "get_IsButton"),
            value);
    }

    public static event ILContext.Manipulator set_IsButton
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputControl), "set_IsButton"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputControl), "set_IsButton"),
            value);
    }

    public static event ILContext.Manipulator get_IsAnalog
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputControl), "get_IsAnalog"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputControl), "get_IsAnalog"),
            value);
    }

    public static event ILContext.Manipulator set_IsAnalog
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputControl), "set_IsAnalog"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputControl), "set_IsAnalog"),
            value);
    }

    public static event ILContext.Manipulator SetZeroTick
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputControl), "SetZeroTick"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputControl), "SetZeroTick"),
            value);
    }

    public static event ILContext.Manipulator get_IsOnZeroTick
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputControl), "get_IsOnZeroTick"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputControl), "get_IsOnZeroTick"),
            value);
    }

    public static event ILContext.Manipulator get_IsStandard
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(InputControl), "get_IsStandard"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(InputControl), "get_IsStandard"),
            value);
    }
}