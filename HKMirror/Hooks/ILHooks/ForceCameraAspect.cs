using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ForceCameraAspect.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILForceCameraAspect
{
    public static event ILContext.Manipulator get_CurrentViewportAspect
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ForceCameraAspect), "get_CurrentViewportAspect", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ForceCameraAspect), "get_CurrentViewportAspect", false), value);
    }

    public static event ILContext.Manipulator set_CurrentViewportAspect
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ForceCameraAspect), "set_CurrentViewportAspect", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ForceCameraAspect), "set_CurrentViewportAspect", false), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.ForceCameraAspect.Awake += value;
        remove => IL.ForceCameraAspect.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.ForceCameraAspect.Start += value;
        remove => IL.ForceCameraAspect.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.ForceCameraAspect.Update += value;
        remove => IL.ForceCameraAspect.Update -= value;
    }

    public static event ILContext.Manipulator SetOverscanViewport
    {
        add => IL.ForceCameraAspect.SetOverscanViewport += value;
        remove => IL.ForceCameraAspect.SetOverscanViewport -= value;
    }

    public static event ILContext.Manipulator AutoScaleViewport
    {
        add => IL.ForceCameraAspect.AutoScaleViewport += value;
        remove => IL.ForceCameraAspect.AutoScaleViewport -= value;
    }
}