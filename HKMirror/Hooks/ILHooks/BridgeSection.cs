using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BridgeSection.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBridgeSection
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.BridgeSection.Awake += value;
        remove => IL.BridgeSection.Awake -= value;
    }

    public static event ILContext.Manipulator Open_BridgeLever_bool
    {
        add => IL.BridgeSection.Open_BridgeLever_bool += value;
        remove => IL.BridgeSection.Open_BridgeLever_bool -= value;
    }

    public static event ILContext.Manipulator Open_float
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BridgeSection), "Open").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BridgeSection), "Open").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator OpenFence
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BridgeSection), "OpenFence").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BridgeSection), "OpenFence").GetStateMachineTarget(), value);
    }
}