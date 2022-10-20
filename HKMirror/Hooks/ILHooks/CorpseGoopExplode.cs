using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CorpseGoopExplode.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCorpseGoopExplode
{
    public static event ILContext.Manipulator Start
    {
        add => IL.CorpseGoopExplode.Start += value;
        remove => IL.CorpseGoopExplode.Start -= value;
    }

    public static event ILContext.Manipulator LandEffects
    {
        add => IL.CorpseGoopExplode.LandEffects += value;
        remove => IL.CorpseGoopExplode.LandEffects -= value;
    }

    public static event ILContext.Manipulator DoLandEffects
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CorpseGoopExplode), "DoLandEffects").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CorpseGoopExplode), "DoLandEffects").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Jitter
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CorpseGoopExplode), "Jitter").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CorpseGoopExplode), "Jitter").GetStateMachineTarget(), value);
    }
}