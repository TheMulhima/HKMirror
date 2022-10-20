using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for AchievementHandler.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILAchievementHandler
{
    public static event ILContext.Manipulator get_achievementsList
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(AchievementHandler), "get_achievementsList"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(AchievementHandler), "get_achievementsList"), value);
    }

    public static event ILContext.Manipulator set_achievementsList
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(AchievementHandler), "set_achievementsList"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(AchievementHandler), "set_achievementsList"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.AchievementHandler.Awake += value;
        remove => IL.AchievementHandler.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.AchievementHandler.Start += value;
        remove => IL.AchievementHandler.Start -= value;
    }

    public static event ILContext.Manipulator AwardAchievementToPlayer
    {
        add => IL.AchievementHandler.AwardAchievementToPlayer += value;
        remove => IL.AchievementHandler.AwardAchievementToPlayer -= value;
    }

    public static event ILContext.Manipulator AchievementWasAwarded
    {
        add => IL.AchievementHandler.AchievementWasAwarded += value;
        remove => IL.AchievementHandler.AchievementWasAwarded -= value;
    }

    public static event ILContext.Manipulator ResetAllAchievements
    {
        add => IL.AchievementHandler.ResetAllAchievements += value;
        remove => IL.AchievementHandler.ResetAllAchievements -= value;
    }

    public static event ILContext.Manipulator FlushRecordsToDisk
    {
        add => IL.AchievementHandler.FlushRecordsToDisk += value;
        remove => IL.AchievementHandler.FlushRecordsToDisk -= value;
    }

    public static event ILContext.Manipulator QueueAchievement
    {
        add => IL.AchievementHandler.QueueAchievement += value;
        remove => IL.AchievementHandler.QueueAchievement -= value;
    }

    public static event ILContext.Manipulator AwardQueuedAchievements
    {
        add => IL.AchievementHandler.AwardQueuedAchievements += value;
        remove => IL.AchievementHandler.AwardQueuedAchievements -= value;
    }

    public static event ILContext.Manipulator AwardAllAchievements
    {
        add => IL.AchievementHandler.AwardAllAchievements += value;
        remove => IL.AchievementHandler.AwardAllAchievements -= value;
    }

    public static event ILContext.Manipulator CanAwardAchievement
    {
        add => IL.AchievementHandler.CanAwardAchievement += value;
        remove => IL.AchievementHandler.CanAwardAchievement -= value;
    }
}