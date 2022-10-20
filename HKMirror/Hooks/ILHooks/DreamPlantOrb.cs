using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for DreamPlantOrb.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDreamPlantOrb
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.DreamPlantOrb.Awake += value;
        remove => IL.DreamPlantOrb.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.DreamPlantOrb.Start += value;
        remove => IL.DreamPlantOrb.Start -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.DreamPlantOrb.OnTriggerEnter2D += value;
        remove => IL.DreamPlantOrb.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator Show
    {
        add => IL.DreamPlantOrb.Show += value;
        remove => IL.DreamPlantOrb.Show -= value;
    }

    public static event ILContext.Manipulator SetActive
    {
        add => IL.DreamPlantOrb.SetActive += value;
        remove => IL.DreamPlantOrb.SetActive -= value;
    }

    public static event ILContext.Manipulator Spread
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(DreamPlantOrb), "Spread").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(DreamPlantOrb), "Spread").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Disable
    {
        add => IL.DreamPlantOrb.Disable += value;
        remove => IL.DreamPlantOrb.Disable -= value;
    }

    public static event ILContext.Manipulator DisableAfterTime
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(DreamPlantOrb), "DisableAfterTime").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(DreamPlantOrb), "DisableAfterTime").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator TweenPosition
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(DreamPlantOrb), "TweenPosition").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(DreamPlantOrb), "TweenPosition").GetStateMachineTarget(), value);
    }
}