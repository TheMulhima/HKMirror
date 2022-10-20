using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GUILayoutHorizontalSlider.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGUILayoutHorizontalSlider
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GUILayoutHorizontalSlider), "Reset"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GUILayoutHorizontalSlider), "Reset"), value);
    }

    public static event ILContext.Manipulator OnGUI
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GUILayoutHorizontalSlider), "OnGUI"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GUILayoutHorizontalSlider), "OnGUI"), value);
    }
}