namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for VibrationPlayerSetMotors.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILVibrationPlayerSetMotors
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.VibrationPlayerSetMotors.Reset += value;
        remove => IL.VibrationPlayerSetMotors.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.VibrationPlayerSetMotors.OnEnter += value;
        remove => IL.VibrationPlayerSetMotors.OnEnter -= value;
    }
}