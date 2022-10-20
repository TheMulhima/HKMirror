using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MenuStyles.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMenuStyles
{
    public static event ILContext.Manipulator get_CurrentStyle
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuStyles), "get_CurrentStyle"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MenuStyles), "get_CurrentStyle"),
            value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.MenuStyles.Awake += value;
        remove => IL.MenuStyles.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.MenuStyles.Start += value;
        remove => IL.MenuStyles.Start -= value;
    }

    public static event ILContext.Manipulator LoadStyle
    {
        add => IL.MenuStyles.LoadStyle += value;
        remove => IL.MenuStyles.LoadStyle -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.MenuStyles.OnDestroy += value;
        remove => IL.MenuStyles.OnDestroy -= value;
    }

    public static event ILContext.Manipulator SetStyle
    {
        add => IL.MenuStyles.SetStyle += value;
        remove => IL.MenuStyles.SetStyle -= value;
    }

    public static event ILContext.Manipulator SwitchStyle
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuStyles), "SwitchStyle").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuStyles), "SwitchStyle").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator StopAudio
    {
        add => IL.MenuStyles.StopAudio += value;
        remove => IL.MenuStyles.StopAudio -= value;
    }

    public static event ILContext.Manipulator FadeOutAudio
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuStyles), "FadeOutAudio").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuStyles), "FadeOutAudio").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator UnlockFromAchievements
    {
        add => IL.MenuStyles.UnlockFromAchievements += value;
        remove => IL.MenuStyles.UnlockFromAchievements -= value;
    }

    public static event ILContext.Manipulator UpdateTitle
    {
        add => IL.MenuStyles.UpdateTitle += value;
        remove => IL.MenuStyles.UpdateTitle -= value;
    }
}