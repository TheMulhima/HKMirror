using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CharmVibrations.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCharmVibrations
{
    public static event ILContext.Manipulator PlayRegularPlace
    {
        add => IL.CharmVibrations.PlayRegularPlace += value;
        remove => IL.CharmVibrations.PlayRegularPlace -= value;
    }

    public static event ILContext.Manipulator PlayFailedPlace
    {
        add => IL.CharmVibrations.PlayFailedPlace += value;
        remove => IL.CharmVibrations.PlayFailedPlace -= value;
    }

    public static event ILContext.Manipulator PlayOvercharmPlace
    {
        add => IL.CharmVibrations.PlayOvercharmPlace += value;
        remove => IL.CharmVibrations.PlayOvercharmPlace -= value;
    }

    public static event ILContext.Manipulator PlayOvercharmHit
    {
        add => IL.CharmVibrations.PlayOvercharmHit += value;
        remove => IL.CharmVibrations.PlayOvercharmHit -= value;
    }

    public static event ILContext.Manipulator PlayOvercharmFinalHit
    {
        add => IL.CharmVibrations.PlayOvercharmFinalHit += value;
        remove => IL.CharmVibrations.PlayOvercharmFinalHit -= value;
    }

    public static event ILContext.Manipulator PlayDelayedVibration
    {
        add => IL.CharmVibrations.PlayDelayedVibration += value;
        remove => IL.CharmVibrations.PlayDelayedVibration -= value;
    }

    public static event ILContext.Manipulator PlayDelayedVibrationRoutine
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CharmVibrations), "PlayDelayedVibrationRoutine")
                .GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CharmVibrations), "PlayDelayedVibrationRoutine")
                .GetStateMachineTarget(), value);
    }
}