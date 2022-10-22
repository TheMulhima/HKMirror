using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MenuStyles_MenuStyle,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMenuStyles_MenuStyle
{
    public static event ILContext.Manipulator get_IsAvailable
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuStyles.MenuStyle), "get_IsAvailable"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuStyles.MenuStyle), "get_IsAvailable"), value);
    }

    public static event ILContext.Manipulator SetInitialAudioVolumes
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MenuStyles.MenuStyle), "SetInitialAudioVolumes"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuStyles.MenuStyle), "SetInitialAudioVolumes"), value);
    }
}