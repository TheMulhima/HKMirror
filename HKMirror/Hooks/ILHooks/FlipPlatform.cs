using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for FlipPlatform.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILFlipPlatform
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.FlipPlatform.Awake += value;
        remove => IL.FlipPlatform.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.FlipPlatform.Start += value;
        remove => IL.FlipPlatform.Start -= value;
    }

    public static event ILContext.Manipulator OnCollisionEnter2D
    {
        add => IL.FlipPlatform.OnCollisionEnter2D += value;
        remove => IL.FlipPlatform.OnCollisionEnter2D -= value;
    }

    public static event ILContext.Manipulator PlaySound
    {
        add => IL.FlipPlatform.PlaySound += value;
        remove => IL.FlipPlatform.PlaySound -= value;
    }

    public static event ILContext.Manipulator Idle
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(FlipPlatform), "Idle").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(FlipPlatform), "Idle").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Flip
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(FlipPlatform), "Flip").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(FlipPlatform), "Flip").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Jitter
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(FlipPlatform), "Jitter").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(FlipPlatform), "Jitter").GetStateMachineTarget(), value);
    }
}