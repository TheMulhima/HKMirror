using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dCameraAnchor,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dCameraAnchor
{
    public static event ILContext.Manipulator set_AnchorPoint
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dCameraAnchor), "set_AnchorPoint"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dCameraAnchor), "set_AnchorPoint"), value);
    }

    public static event ILContext.Manipulator get_AnchorOffsetPixels
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dCameraAnchor), "get_AnchorOffsetPixels"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dCameraAnchor), "get_AnchorOffsetPixels"), value);
    }

    public static event ILContext.Manipulator set_AnchorOffsetPixels
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dCameraAnchor), "set_AnchorOffsetPixels"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dCameraAnchor), "set_AnchorOffsetPixels"), value);
    }

    public static event ILContext.Manipulator get_AnchorToNativeBounds
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dCameraAnchor), "get_AnchorToNativeBounds"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dCameraAnchor), "get_AnchorToNativeBounds"), value);
    }

    public static event ILContext.Manipulator set_AnchorToNativeBounds
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dCameraAnchor), "set_AnchorToNativeBounds"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dCameraAnchor), "set_AnchorToNativeBounds"), value);
    }

    public static event ILContext.Manipulator get_AnchorCamera
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dCameraAnchor), "get_AnchorCamera"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dCameraAnchor), "get_AnchorCamera"), value);
    }

    public static event ILContext.Manipulator set_AnchorCamera
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dCameraAnchor), "set_AnchorCamera"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dCameraAnchor), "set_AnchorCamera"), value);
    }

    public static event ILContext.Manipulator get_AnchorTk2dCamera
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dCameraAnchor), "get_AnchorTk2dCamera"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dCameraAnchor), "get_AnchorTk2dCamera"), value);
    }

    public static event ILContext.Manipulator get_myTransform
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dCameraAnchor), "get_myTransform"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dCameraAnchor), "get_myTransform"), value);
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.tk2dCameraAnchor.Start += value;
        remove => IL.tk2dCameraAnchor.Start -= value;
    }

    public static event ILContext.Manipulator UpdateTransform
    {
        add => IL.tk2dCameraAnchor.UpdateTransform += value;
        remove => IL.tk2dCameraAnchor.UpdateTransform -= value;
    }

    public static event ILContext.Manipulator ForceUpdateTransform
    {
        add => IL.tk2dCameraAnchor.ForceUpdateTransform += value;
        remove => IL.tk2dCameraAnchor.ForceUpdateTransform -= value;
    }

    public static event ILContext.Manipulator LateUpdate
    {
        add => IL.tk2dCameraAnchor.LateUpdate += value;
        remove => IL.tk2dCameraAnchor.LateUpdate -= value;
    }
}