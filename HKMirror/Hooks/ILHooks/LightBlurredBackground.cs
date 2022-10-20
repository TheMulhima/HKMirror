using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for LightBlurredBackground.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILLightBlurredBackground
{
    public static event ILContext.Manipulator get_RenderTextureHeight
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(LightBlurredBackground), "get_RenderTextureHeight"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(LightBlurredBackground), "get_RenderTextureHeight"), value);
    }

    public static event ILContext.Manipulator set_RenderTextureHeight
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(LightBlurredBackground), "set_RenderTextureHeight"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(LightBlurredBackground), "set_RenderTextureHeight"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.LightBlurredBackground.Awake += value;
        remove => IL.LightBlurredBackground.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.LightBlurredBackground.OnEnable += value;
        remove => IL.LightBlurredBackground.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnCameraAspectChanged
    {
        add => IL.LightBlurredBackground.OnCameraAspectChanged += value;
        remove => IL.LightBlurredBackground.OnCameraAspectChanged -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.LightBlurredBackground.OnDisable += value;
        remove => IL.LightBlurredBackground.OnDisable -= value;
    }

    public static event ILContext.Manipulator get_PassGroupCount
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(LightBlurredBackground), "get_PassGroupCount"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(LightBlurredBackground), "get_PassGroupCount"), value);
    }

    public static event ILContext.Manipulator set_PassGroupCount
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(LightBlurredBackground), "set_PassGroupCount"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(LightBlurredBackground), "set_PassGroupCount"), value);
    }

    public static event ILContext.Manipulator OnBlurPlanesChanged
    {
        add => IL.LightBlurredBackground.OnBlurPlanesChanged += value;
        remove => IL.LightBlurredBackground.OnBlurPlanesChanged -= value;
    }

    public static event ILContext.Manipulator LateUpdate
    {
        add => IL.LightBlurredBackground.LateUpdate += value;
        remove => IL.LightBlurredBackground.LateUpdate -= value;
    }

    public static event ILContext.Manipulator UpdateCameraClipPlanes
    {
        add => IL.LightBlurredBackground.UpdateCameraClipPlanes += value;
        remove => IL.LightBlurredBackground.UpdateCameraClipPlanes -= value;
    }
}