using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dPixelPerfectHelper.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dPixelPerfectHelper
{
    public static event ILContext.Manipulator get_inst
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dPixelPerfectHelper), "get_inst", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dPixelPerfectHelper), "get_inst", false), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.tk2dPixelPerfectHelper.Awake += value;
        remove => IL.tk2dPixelPerfectHelper.Awake -= value;
    }

    public static event ILContext.Manipulator Setup
    {
        add => IL.tk2dPixelPerfectHelper.Setup += value;
        remove => IL.tk2dPixelPerfectHelper.Setup -= value;
    }

    public static event ILContext.Manipulator CalculateScaleForPerspectiveCamera
    {
        add => IL.tk2dPixelPerfectHelper.CalculateScaleForPerspectiveCamera += value;
        remove => IL.tk2dPixelPerfectHelper.CalculateScaleForPerspectiveCamera -= value;
    }

    public static event ILContext.Manipulator get_CameraIsOrtho
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dPixelPerfectHelper), "get_CameraIsOrtho"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dPixelPerfectHelper), "get_CameraIsOrtho"), value);
    }
}