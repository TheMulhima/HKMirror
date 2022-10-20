using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dUIMultiStateToggleButton.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dUIMultiStateToggleButton
{
    public static event ILContext.Manipulator get_Index
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIMultiStateToggleButton), "get_Index"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIMultiStateToggleButton), "get_Index"), value);
    }

    public static event ILContext.Manipulator set_Index
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIMultiStateToggleButton), "set_Index"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIMultiStateToggleButton), "set_Index"), value);
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.tk2dUIMultiStateToggleButton.Start += value;
        remove => IL.tk2dUIMultiStateToggleButton.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.tk2dUIMultiStateToggleButton.OnEnable += value;
        remove => IL.tk2dUIMultiStateToggleButton.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.tk2dUIMultiStateToggleButton.OnDisable += value;
        remove => IL.tk2dUIMultiStateToggleButton.OnDisable -= value;
    }

    public static event ILContext.Manipulator ButtonClick
    {
        add => IL.tk2dUIMultiStateToggleButton.ButtonClick += value;
        remove => IL.tk2dUIMultiStateToggleButton.ButtonClick -= value;
    }

    public static event ILContext.Manipulator ButtonDown
    {
        add => IL.tk2dUIMultiStateToggleButton.ButtonDown += value;
        remove => IL.tk2dUIMultiStateToggleButton.ButtonDown -= value;
    }

    public static event ILContext.Manipulator ButtonToggle
    {
        add => IL.tk2dUIMultiStateToggleButton.ButtonToggle += value;
        remove => IL.tk2dUIMultiStateToggleButton.ButtonToggle -= value;
    }

    public static event ILContext.Manipulator SetState
    {
        add => IL.tk2dUIMultiStateToggleButton.SetState += value;
        remove => IL.tk2dUIMultiStateToggleButton.SetState -= value;
    }
}