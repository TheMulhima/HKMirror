using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MenuScreen.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMenuScreen
{
    public static event ILContext.Manipulator get_screenCanvasGroup
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MenuScreen), "get_screenCanvasGroup"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MenuScreen), "get_screenCanvasGroup"), value);
    }

    public static event ILContext.Manipulator HighlightDefault
    {
        add => IL.MenuScreen.HighlightDefault += value;
        remove => IL.MenuScreen.HighlightDefault -= value;
    }
}