using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dUICamera.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dUICamera
{
    public static event ILContext.Manipulator AssignRaycastLayerMask
    {
        add => IL.tk2dUICamera.AssignRaycastLayerMask += value;
        remove => IL.tk2dUICamera.AssignRaycastLayerMask -= value;
    }

    public static event ILContext.Manipulator get_FilteredMask
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUICamera), "get_FilteredMask"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dUICamera), "get_FilteredMask"),
            value);
    }

    public static event ILContext.Manipulator get_HostCamera
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUICamera), "get_HostCamera"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dUICamera), "get_HostCamera"),
            value);
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.tk2dUICamera.OnEnable += value;
        remove => IL.tk2dUICamera.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.tk2dUICamera.OnDisable += value;
        remove => IL.tk2dUICamera.OnDisable -= value;
    }
}