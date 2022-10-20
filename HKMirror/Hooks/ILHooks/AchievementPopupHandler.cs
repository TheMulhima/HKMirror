namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for AchievementPopupHandler.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILAchievementPopupHandler
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.AchievementPopupHandler.Awake += value;
        remove => IL.AchievementPopupHandler.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.AchievementPopupHandler.Start += value;
        remove => IL.AchievementPopupHandler.Start -= value;
    }

    public static event ILContext.Manipulator Setup
    {
        add => IL.AchievementPopupHandler.Setup += value;
        remove => IL.AchievementPopupHandler.Setup -= value;
    }

    public static event ILContext.Manipulator HandleAchievementEvent
    {
        add => IL.AchievementPopupHandler.HandleAchievementEvent += value;
        remove => IL.AchievementPopupHandler.HandleAchievementEvent -= value;
    }

    public static event ILContext.Manipulator GetPooledPopup
    {
        add => IL.AchievementPopupHandler.GetPooledPopup += value;
        remove => IL.AchievementPopupHandler.GetPooledPopup -= value;
    }

    public static event ILContext.Manipulator DisableAll
    {
        add => IL.AchievementPopupHandler.DisableAll += value;
        remove => IL.AchievementPopupHandler.DisableAll -= value;
    }
}