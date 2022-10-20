using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ScuttlerControl.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILScuttlerControl
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.ScuttlerControl.Awake += value;
        remove => IL.ScuttlerControl.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.ScuttlerControl.Start += value;
        remove => IL.ScuttlerControl.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.ScuttlerControl.Update += value;
        remove => IL.ScuttlerControl.Update -= value;
    }

    public static event ILContext.Manipulator Land
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ScuttlerControl), "Land").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ScuttlerControl), "Land").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Run
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ScuttlerControl), "Run").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ScuttlerControl), "Run").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Bounce
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ScuttlerControl), "Bounce").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ScuttlerControl), "Bounce").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Heal
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ScuttlerControl), "Heal").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ScuttlerControl), "Heal").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Hit
    {
        add => IL.ScuttlerControl.Hit += value;
        remove => IL.ScuttlerControl.Hit -= value;
    }
}