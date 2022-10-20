namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for VibrationPlayerStop.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILVibrationPlayerStop
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.VibrationPlayerStop.Reset += value;
        remove => IL.VibrationPlayerStop.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.VibrationPlayerStop.OnEnter += value;
        remove => IL.VibrationPlayerStop.OnEnter -= value;
    }
}