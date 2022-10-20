namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for VibrationPlayerPlay.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILVibrationPlayerPlay
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.VibrationPlayerPlay.Reset += value;
        remove => IL.VibrationPlayerPlay.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.VibrationPlayerPlay.OnEnter += value;
        remove => IL.VibrationPlayerPlay.OnEnter -= value;
    }
}