using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TriggerActivateComponent.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTriggerActivateComponent
{
    public static event ILContext.Manipulator Start
    {
        add => IL.TriggerActivateComponent.Start += value;
        remove => IL.TriggerActivateComponent.Start -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.TriggerActivateComponent.OnTriggerEnter2D += value;
        remove => IL.TriggerActivateComponent.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerExit2D
    {
        add => IL.TriggerActivateComponent.OnTriggerExit2D += value;
        remove => IL.TriggerActivateComponent.OnTriggerExit2D -= value;
    }

    public static event ILContext.Manipulator DisableTimer
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(TriggerActivateComponent), "DisableTimer").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(TriggerActivateComponent), "DisableTimer").GetStateMachineTarget(),
            value);
    }
}