using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CorpseFungusExplode.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCorpseFungusExplode
{
    public static event ILContext.Manipulator LandEffects
    {
        add => IL.CorpseFungusExplode.LandEffects += value;
        remove => IL.CorpseFungusExplode.LandEffects -= value;
    }

    public static event ILContext.Manipulator DoLandEffects
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CorpseFungusExplode), "DoLandEffects").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CorpseFungusExplode), "DoLandEffects").GetStateMachineTarget(),
            value);
    }

    public static event ILContext.Manipulator Jitter
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CorpseFungusExplode), "Jitter").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CorpseFungusExplode), "Jitter").GetStateMachineTarget(), value);
    }
}