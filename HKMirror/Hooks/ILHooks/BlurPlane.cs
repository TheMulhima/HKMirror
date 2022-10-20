using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BlurPlane.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBlurPlane
{
    public static event ILContext.Manipulator get_OriginalMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BlurPlane), "get_OriginalMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BlurPlane), "get_OriginalMaterial"), value);
    }

    public static event ILContext.Manipulator set_OriginalMaterial
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BlurPlane), "set_OriginalMaterial"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BlurPlane), "set_OriginalMaterial"), value);
    }

    public static event ILContext.Manipulator get_BlurPlaneCount
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BlurPlane), "get_BlurPlaneCount", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BlurPlane), "get_BlurPlaneCount", false), value);
    }

    public static event ILContext.Manipulator GetBlurPlane
    {
        add => IL.BlurPlane.GetBlurPlane += value;
        remove => IL.BlurPlane.GetBlurPlane -= value;
    }

    public static event ILContext.Manipulator get_ClosestBlurPlane
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BlurPlane), "get_ClosestBlurPlane", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BlurPlane), "get_ClosestBlurPlane", false), value);
    }

    public static event ILContext.Manipulator get_PlaneZ
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(BlurPlane), "get_PlaneZ"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(BlurPlane), "get_PlaneZ"), value);
    }

    public static event ILContext.Manipulator Init
    {
        add => IL.BlurPlane.Init += value;
        remove => IL.BlurPlane.Init -= value;
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.BlurPlane.Awake += value;
        remove => IL.BlurPlane.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.BlurPlane.OnEnable += value;
        remove => IL.BlurPlane.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.BlurPlane.OnDisable += value;
        remove => IL.BlurPlane.OnDisable -= value;
    }

    public static event ILContext.Manipulator SetPlaneVisibility
    {
        add => IL.BlurPlane.SetPlaneVisibility += value;
        remove => IL.BlurPlane.SetPlaneVisibility -= value;
    }

    public static event ILContext.Manipulator SetPlaneMaterial
    {
        add => IL.BlurPlane.SetPlaneMaterial += value;
        remove => IL.BlurPlane.SetPlaneMaterial -= value;
    }
}