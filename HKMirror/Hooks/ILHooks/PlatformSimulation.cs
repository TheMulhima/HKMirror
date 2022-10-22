using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PlatformSimulation,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPlatformSimulation
{
    public static event ILContext.Manipulator get_IsPlatformSimulationEnabled
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PlatformSimulation), "get_IsPlatformSimulationEnabled", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlatformSimulation), "get_IsPlatformSimulationEnabled", false),
            value);
    }
}