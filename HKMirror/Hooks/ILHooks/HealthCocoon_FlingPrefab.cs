using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for HealthCocoon_FlingPrefab,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILHealthCocoon_FlingPrefab
{
    public static event ILContext.Manipulator SetupPool
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HealthCocoon.FlingPrefab), "SetupPool"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HealthCocoon.FlingPrefab), "SetupPool"), value);
    }

    public static event ILContext.Manipulator Spawn
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(HealthCocoon.FlingPrefab), "Spawn"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HealthCocoon.FlingPrefab), "Spawn"), value);
    }
}