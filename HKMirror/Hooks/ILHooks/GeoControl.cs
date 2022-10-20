using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GeoControl.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGeoControl
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.GeoControl.Awake += value;
        remove => IL.GeoControl.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.GeoControl.Start += value;
        remove => IL.GeoControl.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.GeoControl.OnEnable += value;
        remove => IL.GeoControl.OnEnable -= value;
    }

    public static event ILContext.Manipulator FixedUpdate
    {
        add => IL.GeoControl.FixedUpdate += value;
        remove => IL.GeoControl.FixedUpdate -= value;
    }

    public static event ILContext.Manipulator SetSize
    {
        add => IL.GeoControl.SetSize += value;
        remove => IL.GeoControl.SetSize -= value;
    }

    public static event ILContext.Manipulator SetFlashing
    {
        add => IL.GeoControl.SetFlashing += value;
        remove => IL.GeoControl.SetFlashing -= value;
    }

    public static event ILContext.Manipulator OnCollisionEnter2D
    {
        add => IL.GeoControl.OnCollisionEnter2D += value;
        remove => IL.GeoControl.OnCollisionEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.GeoControl.OnTriggerEnter2D += value;
        remove => IL.GeoControl.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator PlayCollectSound
    {
        add => IL.GeoControl.PlayCollectSound += value;
        remove => IL.GeoControl.PlayCollectSound -= value;
    }

    public static event ILContext.Manipulator Disable
    {
        add => IL.GeoControl.Disable += value;
        remove => IL.GeoControl.Disable -= value;
    }

    public static event ILContext.Manipulator DisableAfterTime
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GeoControl), "DisableAfterTime").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GeoControl), "DisableAfterTime").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Getter
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GeoControl), "Getter").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GeoControl), "Getter").GetStateMachineTarget(), value);
    }
}