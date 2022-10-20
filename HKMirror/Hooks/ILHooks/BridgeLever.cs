using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BridgeLever.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBridgeLever
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.BridgeLever.Awake += value;
        remove => IL.BridgeLever.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.BridgeLever.Start += value;
        remove => IL.BridgeLever.Start -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.BridgeLever.OnTriggerEnter2D += value;
        remove => IL.BridgeLever.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator OpenBridge
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BridgeLever), "OpenBridge").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BridgeLever), "OpenBridge").GetStateMachineTarget(), value);
    }
}