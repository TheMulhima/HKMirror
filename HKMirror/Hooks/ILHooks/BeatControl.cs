namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BeatControl.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBeatControl
{
    public static event ILContext.Manipulator Update
    {
        add => IL.BeatControl.Update += value;
        remove => IL.BeatControl.Update -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.BeatControl.OnDestroy += value;
        remove => IL.BeatControl.OnDestroy -= value;
    }
}