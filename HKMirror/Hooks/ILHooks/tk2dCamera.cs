using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dCamera.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dCamera
{
    public static event ILContext.Manipulator get_CameraSettings
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_CameraSettings"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_CameraSettings"),
            value);
    }

    public static event ILContext.Manipulator get_CurrentResolutionOverride
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_CurrentResolutionOverride"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_CurrentResolutionOverride"), value);
    }

    public static event ILContext.Manipulator get_InheritConfig
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_InheritConfig"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_InheritConfig"),
            value);
    }

    public static event ILContext.Manipulator set_InheritConfig
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "set_InheritConfig"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "set_InheritConfig"),
            value);
    }

    public static event ILContext.Manipulator get_UnityCamera
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_UnityCamera"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_UnityCamera"),
            value);
    }

    public static event ILContext.Manipulator get_Instance
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_Instance", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_Instance", false), value);
    }

    public static event ILContext.Manipulator CameraForLayer
    {
        add => IL.tk2dCamera.CameraForLayer += value;
        remove => IL.tk2dCamera.CameraForLayer -= value;
    }

    public static event ILContext.Manipulator get_ScreenExtents
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_ScreenExtents"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_ScreenExtents"),
            value);
    }

    public static event ILContext.Manipulator get_NativeScreenExtents
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_NativeScreenExtents"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_NativeScreenExtents"), value);
    }

    public static event ILContext.Manipulator get_TargetResolution
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_TargetResolution"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_TargetResolution"), value);
    }

    public static event ILContext.Manipulator get_NativeResolution
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_NativeResolution"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_NativeResolution"), value);
    }

    public static event ILContext.Manipulator get_ScreenOffset
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_ScreenOffset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_ScreenOffset"),
            value);
    }

    public static event ILContext.Manipulator get_resolution
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_resolution"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_resolution"),
            value);
    }

    public static event ILContext.Manipulator get_ScreenResolution
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_ScreenResolution"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_ScreenResolution"), value);
    }

    public static event ILContext.Manipulator get_ScaledResolution
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_ScaledResolution"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_ScaledResolution"), value);
    }

    public static event ILContext.Manipulator get_ZoomFactor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_ZoomFactor"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_ZoomFactor"),
            value);
    }

    public static event ILContext.Manipulator set_ZoomFactor
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "set_ZoomFactor"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "set_ZoomFactor"),
            value);
    }

    public static event ILContext.Manipulator get_zoomScale
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_zoomScale"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_zoomScale"),
            value);
    }

    public static event ILContext.Manipulator set_zoomScale
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "set_zoomScale"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "set_zoomScale"),
            value);
    }

    public static event ILContext.Manipulator get_ScreenCamera
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_ScreenCamera"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_ScreenCamera"),
            value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.tk2dCamera.Awake += value;
        remove => IL.tk2dCamera.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.tk2dCamera.OnEnable += value;
        remove => IL.tk2dCamera.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.tk2dCamera.OnDestroy += value;
        remove => IL.tk2dCamera.OnDestroy -= value;
    }

    public static event ILContext.Manipulator OnPreCull
    {
        add => IL.tk2dCamera.OnPreCull += value;
        remove => IL.tk2dCamera.OnPreCull -= value;
    }

    public static event ILContext.Manipulator GetSizeAtDistance
    {
        add => IL.tk2dCamera.GetSizeAtDistance += value;
        remove => IL.tk2dCamera.GetSizeAtDistance -= value;
    }

    public static event ILContext.Manipulator get_SettingsRoot
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_SettingsRoot"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dCamera), "get_SettingsRoot"),
            value);
    }

    public static event ILContext.Manipulator OrthoOffCenter
    {
        add => IL.tk2dCamera.OrthoOffCenter += value;
        remove => IL.tk2dCamera.OrthoOffCenter -= value;
    }

    public static event ILContext.Manipulator GetScaleForOverride
    {
        add => IL.tk2dCamera.GetScaleForOverride += value;
        remove => IL.tk2dCamera.GetScaleForOverride -= value;
    }

    public static event ILContext.Manipulator GetOffsetForOverride
    {
        add => IL.tk2dCamera.GetOffsetForOverride += value;
        remove => IL.tk2dCamera.GetOffsetForOverride -= value;
    }

    public static event ILContext.Manipulator GetProjectionMatrixForOverride
    {
        add => IL.tk2dCamera.GetProjectionMatrixForOverride += value;
        remove => IL.tk2dCamera.GetProjectionMatrixForOverride -= value;
    }

    public static event ILContext.Manipulator GetScreenPixelDimensions
    {
        add => IL.tk2dCamera.GetScreenPixelDimensions += value;
        remove => IL.tk2dCamera.GetScreenPixelDimensions -= value;
    }

    public static event ILContext.Manipulator Upgrade
    {
        add => IL.tk2dCamera.Upgrade += value;
        remove => IL.tk2dCamera.Upgrade -= value;
    }

    public static event ILContext.Manipulator UpdateCameraMatrix
    {
        add => IL.tk2dCamera.UpdateCameraMatrix += value;
        remove => IL.tk2dCamera.UpdateCameraMatrix -= value;
    }
}