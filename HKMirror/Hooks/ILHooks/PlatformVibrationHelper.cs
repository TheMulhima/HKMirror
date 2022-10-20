namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PlatformVibrationHelper.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPlatformVibrationHelper
{
    public static event ILContext.Manipulator Destroy
    {
        add => IL.PlatformVibrationHelper.Destroy += value;
        remove => IL.PlatformVibrationHelper.Destroy -= value;
    }

    public static event ILContext.Manipulator UpdateVibration
    {
        add => IL.PlatformVibrationHelper.UpdateVibration += value;
        remove => IL.PlatformVibrationHelper.UpdateVibration -= value;
    }

    public static event ILContext.Manipulator GetMixer
    {
        add => IL.PlatformVibrationHelper.GetMixer += value;
        remove => IL.PlatformVibrationHelper.GetMixer -= value;
    }
}