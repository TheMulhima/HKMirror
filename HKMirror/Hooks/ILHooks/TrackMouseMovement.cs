namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TrackMouseMovement.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTrackMouseMovement
{
    public static event ILContext.Manipulator Start
    {
        add => IL.TrackMouseMovement.Start += value;
        remove => IL.TrackMouseMovement.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.TrackMouseMovement.Update += value;
        remove => IL.TrackMouseMovement.Update -= value;
    }
}