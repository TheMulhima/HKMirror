using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MouseLook2.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMouseLook2
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MouseLook2), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MouseLook2), "Reset"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MouseLook2), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MouseLook2), "OnEnter"), value);
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MouseLook2), "OnUpdate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MouseLook2), "OnUpdate"), value);
    }

    public static event ILContext.Manipulator DoMouseLook
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MouseLook2), "DoMouseLook"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MouseLook2), "DoMouseLook"), value);
    }

    public static event ILContext.Manipulator GetXRotation
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MouseLook2), "GetXRotation"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MouseLook2), "GetXRotation"),
            value);
    }

    public static event ILContext.Manipulator GetYRotation
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MouseLook2), "GetYRotation"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MouseLook2), "GetYRotation"),
            value);
    }

    public static event ILContext.Manipulator ClampAngle
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MouseLook2), "ClampAngle", false),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MouseLook2), "ClampAngle", false),
            value);
    }
}