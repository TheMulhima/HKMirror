using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Drip.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDrip
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.Drip.Awake += value;
        remove => IL.Drip.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.Drip.Start += value;
        remove => IL.Drip.Start -= value;
    }

    public static event ILContext.Manipulator DripRoutine
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Drip), "DripRoutine").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Drip), "DripRoutine").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator DropDrip
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Drip), "DropDrip").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Drip), "DropDrip").GetStateMachineTarget(), value);
    }
}