using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for AcidCorpseSplash.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILAcidCorpseSplash
{
    public static event ILContext.Manipulator Start
    {
        add => IL.AcidCorpseSplash.Start += value;
        remove => IL.AcidCorpseSplash.Start -= value;
    }

    public static event ILContext.Manipulator CorpseSplash
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(AcidCorpseSplash), "CorpseSplash").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(AcidCorpseSplash), "CorpseSplash").GetStateMachineTarget(), value);
    }
}