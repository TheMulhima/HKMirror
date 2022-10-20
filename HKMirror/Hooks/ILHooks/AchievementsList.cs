namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for AchievementsList.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILAchievementsList
{
    public static event ILContext.Manipulator FindAchievement
    {
        add => IL.AchievementsList.FindAchievement += value;
        remove => IL.AchievementsList.FindAchievement -= value;
    }

    public static event ILContext.Manipulator AchievementExists
    {
        add => IL.AchievementsList.AchievementExists += value;
        remove => IL.AchievementsList.AchievementExists -= value;
    }
}