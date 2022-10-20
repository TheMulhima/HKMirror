namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for AchievementListener.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILAchievementListener
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.AchievementListener.OnEnable += value;
        remove => IL.AchievementListener.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.AchievementListener.OnDisable += value;
        remove => IL.AchievementListener.OnDisable -= value;
    }

    public static event ILContext.Manipulator CaptureAchievementEvent
    {
        add => IL.AchievementListener.CaptureAchievementEvent += value;
        remove => IL.AchievementListener.CaptureAchievementEvent -= value;
    }
}