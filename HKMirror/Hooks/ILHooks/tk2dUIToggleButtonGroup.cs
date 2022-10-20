using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dUIToggleButtonGroup.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dUIToggleButtonGroup
{
    public static event ILContext.Manipulator get_ToggleBtns
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIToggleButtonGroup), "get_ToggleBtns"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIToggleButtonGroup), "get_ToggleBtns"), value);
    }

    public static event ILContext.Manipulator get_SelectedIndex
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIToggleButtonGroup), "get_SelectedIndex"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIToggleButtonGroup), "get_SelectedIndex"), value);
    }

    public static event ILContext.Manipulator set_SelectedIndex
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIToggleButtonGroup), "set_SelectedIndex"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIToggleButtonGroup), "set_SelectedIndex"), value);
    }

    public static event ILContext.Manipulator get_SelectedToggleButton
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIToggleButtonGroup), "get_SelectedToggleButton"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIToggleButtonGroup), "get_SelectedToggleButton"), value);
    }

    public static event ILContext.Manipulator set_SelectedToggleButton
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIToggleButtonGroup), "set_SelectedToggleButton"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIToggleButtonGroup), "set_SelectedToggleButton"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.tk2dUIToggleButtonGroup.Awake += value;
        remove => IL.tk2dUIToggleButtonGroup.Awake -= value;
    }

    public static event ILContext.Manipulator Setup
    {
        add => IL.tk2dUIToggleButtonGroup.Setup += value;
        remove => IL.tk2dUIToggleButtonGroup.Setup -= value;
    }

    public static event ILContext.Manipulator AddNewToggleButtons
    {
        add => IL.tk2dUIToggleButtonGroup.AddNewToggleButtons += value;
        remove => IL.tk2dUIToggleButtonGroup.AddNewToggleButtons -= value;
    }

    public static event ILContext.Manipulator ClearExistingToggleBtns
    {
        add => IL.tk2dUIToggleButtonGroup.ClearExistingToggleBtns += value;
        remove => IL.tk2dUIToggleButtonGroup.ClearExistingToggleBtns -= value;
    }

    public static event ILContext.Manipulator SetToggleButtonUsingSelectedIndex
    {
        add => IL.tk2dUIToggleButtonGroup.SetToggleButtonUsingSelectedIndex += value;
        remove => IL.tk2dUIToggleButtonGroup.SetToggleButtonUsingSelectedIndex -= value;
    }

    public static event ILContext.Manipulator ButtonToggle
    {
        add => IL.tk2dUIToggleButtonGroup.ButtonToggle += value;
        remove => IL.tk2dUIToggleButtonGroup.ButtonToggle -= value;
    }

    public static event ILContext.Manipulator SetSelectedIndexFromSelectedToggleButton
    {
        add => IL.tk2dUIToggleButtonGroup.SetSelectedIndexFromSelectedToggleButton += value;
        remove => IL.tk2dUIToggleButtonGroup.SetSelectedIndexFromSelectedToggleButton -= value;
    }
}