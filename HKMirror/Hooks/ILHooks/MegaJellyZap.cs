using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MegaJellyZap.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMegaJellyZap
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.MegaJellyZap.Awake += value;
        remove => IL.MegaJellyZap.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.MegaJellyZap.OnEnable += value;
        remove => IL.MegaJellyZap.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.MegaJellyZap.OnDisable += value;
        remove => IL.MegaJellyZap.OnDisable -= value;
    }

    public static event ILContext.Manipulator ZapSequence
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MegaJellyZap), "ZapSequence").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MegaJellyZap), "ZapSequence").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator MultiZapSequence
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MegaJellyZap), "MultiZapSequence").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MegaJellyZap), "MultiZapSequence").GetStateMachineTarget(), value);
    }
}