using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dUIToggleButton.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dUIToggleButton
{
    public static event ILContext.Manipulator get_IsOn
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIToggleButton), "get_IsOn"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIToggleButton), "get_IsOn"),
            value);
    }

    public static event ILContext.Manipulator set_IsOn
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIToggleButton), "set_IsOn"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIToggleButton), "set_IsOn"),
            value);
    }

    public static event ILContext.Manipulator get_IsInToggleGroup
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIToggleButton), "get_IsInToggleGroup"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIToggleButton), "get_IsInToggleGroup"), value);
    }

    public static event ILContext.Manipulator set_IsInToggleGroup
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIToggleButton), "set_IsInToggleGroup"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIToggleButton), "set_IsInToggleGroup"), value);
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.tk2dUIToggleButton.Start += value;
        remove => IL.tk2dUIToggleButton.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.tk2dUIToggleButton.OnEnable += value;
        remove => IL.tk2dUIToggleButton.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.tk2dUIToggleButton.OnDisable += value;
        remove => IL.tk2dUIToggleButton.OnDisable -= value;
    }

    public static event ILContext.Manipulator ButtonClick
    {
        add => IL.tk2dUIToggleButton.ButtonClick += value;
        remove => IL.tk2dUIToggleButton.ButtonClick -= value;
    }

    public static event ILContext.Manipulator ButtonDown
    {
        add => IL.tk2dUIToggleButton.ButtonDown += value;
        remove => IL.tk2dUIToggleButton.ButtonDown -= value;
    }

    public static event ILContext.Manipulator ButtonToggle
    {
        add => IL.tk2dUIToggleButton.ButtonToggle += value;
        remove => IL.tk2dUIToggleButton.ButtonToggle -= value;
    }

    public static event ILContext.Manipulator SetState
    {
        add => IL.tk2dUIToggleButton.SetState += value;
        remove => IL.tk2dUIToggleButton.SetState -= value;
    }
}