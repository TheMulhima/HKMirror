using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CorpseSpineBurst.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCorpseSpineBurst
{
    public static event ILContext.Manipulator LandEffects
    {
        add => IL.CorpseSpineBurst.LandEffects += value;
        remove => IL.CorpseSpineBurst.LandEffects -= value;
    }

    public static event ILContext.Manipulator DoLandEffects
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CorpseSpineBurst), "DoLandEffects").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CorpseSpineBurst), "DoLandEffects").GetStateMachineTarget(), value);
    }
}