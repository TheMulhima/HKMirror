using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for WaterDrip.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILWaterDrip
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.WaterDrip.Awake += value;
        remove => IL.WaterDrip.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.WaterDrip.Start += value;
        remove => IL.WaterDrip.Start -= value;
    }

    public static event ILContext.Manipulator Drip
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(WaterDrip), "Drip").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(WaterDrip), "Drip").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator OnCollisionEnter2D
    {
        add => IL.WaterDrip.OnCollisionEnter2D += value;
        remove => IL.WaterDrip.OnCollisionEnter2D -= value;
    }
}