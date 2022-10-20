using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CameraFade.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCameraFade
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.CameraFade.Awake += value;
        remove => IL.CameraFade.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CameraFade), "Start").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CameraFade), "Start").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator OnGUI
    {
        add => IL.CameraFade.OnGUI += value;
        remove => IL.CameraFade.OnGUI -= value;
    }

    public static event ILContext.Manipulator SetScreenOverlayColor
    {
        add => IL.CameraFade.SetScreenOverlayColor += value;
        remove => IL.CameraFade.SetScreenOverlayColor -= value;
    }

    public static event ILContext.Manipulator StartFade
    {
        add => IL.CameraFade.StartFade += value;
        remove => IL.CameraFade.StartFade -= value;
    }

    public static event ILContext.Manipulator FadeToBlack
    {
        add => IL.CameraFade.FadeToBlack += value;
        remove => IL.CameraFade.FadeToBlack -= value;
    }

    public static event ILContext.Manipulator FadeToTransparent
    {
        add => IL.CameraFade.FadeToTransparent += value;
        remove => IL.CameraFade.FadeToTransparent -= value;
    }
}