using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for StalactiteControl.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILStalactiteControl
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.StalactiteControl.Awake += value;
        remove => IL.StalactiteControl.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.StalactiteControl.Start += value;
        remove => IL.StalactiteControl.Start -= value;
    }

    public static event ILContext.Manipulator HandleTriggerEnter
    {
        add => IL.StalactiteControl.HandleTriggerEnter += value;
        remove => IL.StalactiteControl.HandleTriggerEnter -= value;
    }

    public static event ILContext.Manipulator Fall
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(StalactiteControl), "Fall").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(StalactiteControl), "Fall").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.StalactiteControl.OnTriggerEnter2D += value;
        remove => IL.StalactiteControl.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator FlingObjects
    {
        add => IL.StalactiteControl.FlingObjects += value;
        remove => IL.StalactiteControl.FlingObjects -= value;
    }
}