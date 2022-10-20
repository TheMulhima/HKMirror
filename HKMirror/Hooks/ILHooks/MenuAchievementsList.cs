using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MenuAchievementsList.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMenuAchievementsList
{
    public static event ILContext.Manipulator get_init
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuAchievementsList), "get_init"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuAchievementsList), "get_init"),
            value);
    }

    public static event ILContext.Manipulator set_init
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuAchievementsList), "set_init"),
            value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuAchievementsList), "set_init"),
            value);
    }

    public static event ILContext.Manipulator AddMenuAchievement
    {
        add => IL.MenuAchievementsList.AddMenuAchievement += value;
        remove => IL.MenuAchievementsList.AddMenuAchievement -= value;
    }

    public static event ILContext.Manipulator FindAchievement
    {
        add => IL.MenuAchievementsList.FindAchievement += value;
        remove => IL.MenuAchievementsList.FindAchievement -= value;
    }

    public static event ILContext.Manipulator MarkInit
    {
        add => IL.MenuAchievementsList.MarkInit += value;
        remove => IL.MenuAchievementsList.MarkInit -= value;
    }
}