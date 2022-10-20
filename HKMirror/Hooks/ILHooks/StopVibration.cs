namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for StopVibration.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILStopVibration
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.StopVibration.Reset += value;
        remove => IL.StopVibration.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.StopVibration.OnEnter += value;
        remove => IL.StopVibration.OnEnter -= value;
    }
}