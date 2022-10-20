namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for AddTrackTrigger.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILAddTrackTrigger
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.AddTrackTrigger.Reset += value;
        remove => IL.AddTrackTrigger.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.AddTrackTrigger.OnEnter += value;
        remove => IL.AddTrackTrigger.OnEnter -= value;
    }
}