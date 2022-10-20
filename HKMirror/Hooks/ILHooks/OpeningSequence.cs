using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for OpeningSequence.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILOpeningSequence
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.OpeningSequence.OnEnable += value;
        remove => IL.OpeningSequence.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.OpeningSequence.OnDisable += value;
        remove => IL.OpeningSequence.OnDisable -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OpeningSequence), "Start").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OpeningSequence), "Start").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator StartAsync
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OpeningSequence), "StartAsync").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OpeningSequence), "StartAsync").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator StartSync
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OpeningSequence), "StartSync").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OpeningSequence), "StartSync").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.OpeningSequence.Update += value;
        remove => IL.OpeningSequence.Update -= value;
    }

    public static event ILContext.Manipulator IsLevelReady
    {
        add => IL.OpeningSequence.IsLevelReady += value;
        remove => IL.OpeningSequence.IsLevelReady -= value;
    }

    public static event ILContext.Manipulator Skip
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(OpeningSequence), "Skip").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(OpeningSequence), "Skip").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator OnChangingSequences
    {
        add => IL.OpeningSequence.OnChangingSequences += value;
        remove => IL.OpeningSequence.OnChangingSequences -= value;
    }
}