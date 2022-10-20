using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BounceShroom.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBounceShroom
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.BounceShroom.Awake += value;
        remove => IL.BounceShroom.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.BounceShroom.Start += value;
        remove => IL.BounceShroom.Start -= value;
    }

    public static event ILContext.Manipulator Idle
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BounceShroom), "Idle").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BounceShroom), "Idle").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator BounceSmall
    {
        add => IL.BounceShroom.BounceSmall += value;
        remove => IL.BounceShroom.BounceSmall -= value;
    }

    public static event ILContext.Manipulator Bounce
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BounceShroom), "Bounce").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BounceShroom), "Bounce").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator BounceLarge
    {
        add => IL.BounceShroom.BounceLarge += value;
        remove => IL.BounceShroom.BounceLarge -= value;
    }
}