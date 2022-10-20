namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for AchievementPopup.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILAchievementPopup
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.AchievementPopup.Awake += value;
        remove => IL.AchievementPopup.Awake -= value;
    }

    public static event ILContext.Manipulator Setup
    {
        add => IL.AchievementPopup.Setup += value;
        remove => IL.AchievementPopup.Setup -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.AchievementPopup.Update += value;
        remove => IL.AchievementPopup.Update -= value;
    }
}