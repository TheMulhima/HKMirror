using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for FSMActivator.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILFSMActivator
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.FSMActivator.Awake += value;
        remove => IL.FSMActivator.Awake -= value;
    }

    public static event ILContext.Manipulator Activate
    {
        add => IL.FSMActivator.Activate += value;
        remove => IL.FSMActivator.Activate -= value;
    }

    public static event ILContext.Manipulator ActivateStaggered
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(FSMActivator), "ActivateStaggered").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(FSMActivator), "ActivateStaggered").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Deactivate
    {
        add => IL.FSMActivator.Deactivate += value;
        remove => IL.FSMActivator.Deactivate -= value;
    }

    public static event ILContext.Manipulator DeactivateStaggered
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(FSMActivator), "DeactivateStaggered").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(FSMActivator), "DeactivateStaggered").GetStateMachineTarget(), value);
    }
}