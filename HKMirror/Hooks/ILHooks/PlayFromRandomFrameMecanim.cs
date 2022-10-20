using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PlayFromRandomFrameMecanim.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPlayFromRandomFrameMecanim
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.PlayFromRandomFrameMecanim.Awake += value;
        remove => IL.PlayFromRandomFrameMecanim.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.PlayFromRandomFrameMecanim.Start += value;
        remove => IL.PlayFromRandomFrameMecanim.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.PlayFromRandomFrameMecanim.OnEnable += value;
        remove => IL.PlayFromRandomFrameMecanim.OnEnable -= value;
    }

    public static event ILContext.Manipulator DoPlay
    {
        add => IL.PlayFromRandomFrameMecanim.DoPlay += value;
        remove => IL.PlayFromRandomFrameMecanim.DoPlay -= value;
    }

    public static event ILContext.Manipulator DelayStart
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(PlayFromRandomFrameMecanim), "DelayStart").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(PlayFromRandomFrameMecanim), "DelayStart").GetStateMachineTarget(),
            value);
    }
}