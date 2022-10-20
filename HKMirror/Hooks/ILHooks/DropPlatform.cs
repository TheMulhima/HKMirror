using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for DropPlatform.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDropPlatform
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.DropPlatform.Awake += value;
        remove => IL.DropPlatform.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.DropPlatform.Start += value;
        remove => IL.DropPlatform.Start -= value;
    }

    public static event ILContext.Manipulator OnCollisionEnter2D
    {
        add => IL.DropPlatform.OnCollisionEnter2D += value;
        remove => IL.DropPlatform.OnCollisionEnter2D -= value;
    }

    public static event ILContext.Manipulator PlaySound
    {
        add => IL.DropPlatform.PlaySound += value;
        remove => IL.DropPlatform.PlaySound -= value;
    }

    public static event ILContext.Manipulator Idle
    {
        add => IL.DropPlatform.Idle += value;
        remove => IL.DropPlatform.Idle -= value;
    }

    public static event ILContext.Manipulator Flip
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(DropPlatform), "Flip").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(DropPlatform), "Flip").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Jitter
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(DropPlatform), "Jitter").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(DropPlatform), "Jitter").GetStateMachineTarget(), value);
    }
}