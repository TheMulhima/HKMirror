using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dUIUpDownHoverButton.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dUIUpDownHoverButton
{
    public static event ILContext.Manipulator get_UseOnReleaseInsteadOfOnUp
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIUpDownHoverButton), "get_UseOnReleaseInsteadOfOnUp"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIUpDownHoverButton), "get_UseOnReleaseInsteadOfOnUp"), value);
    }

    public static event ILContext.Manipulator get_IsOver
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIUpDownHoverButton), "get_IsOver"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIUpDownHoverButton), "get_IsOver"), value);
    }

    public static event ILContext.Manipulator set_IsOver
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIUpDownHoverButton), "set_IsOver"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIUpDownHoverButton), "set_IsOver"), value);
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.tk2dUIUpDownHoverButton.Start += value;
        remove => IL.tk2dUIUpDownHoverButton.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.tk2dUIUpDownHoverButton.OnEnable += value;
        remove => IL.tk2dUIUpDownHoverButton.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.tk2dUIUpDownHoverButton.OnDisable += value;
        remove => IL.tk2dUIUpDownHoverButton.OnDisable -= value;
    }

    public static event ILContext.Manipulator ButtonUp
    {
        add => IL.tk2dUIUpDownHoverButton.ButtonUp += value;
        remove => IL.tk2dUIUpDownHoverButton.ButtonUp -= value;
    }

    public static event ILContext.Manipulator ButtonDown
    {
        add => IL.tk2dUIUpDownHoverButton.ButtonDown += value;
        remove => IL.tk2dUIUpDownHoverButton.ButtonDown -= value;
    }

    public static event ILContext.Manipulator ButtonHoverOver
    {
        add => IL.tk2dUIUpDownHoverButton.ButtonHoverOver += value;
        remove => IL.tk2dUIUpDownHoverButton.ButtonHoverOver -= value;
    }

    public static event ILContext.Manipulator ButtonHoverOut
    {
        add => IL.tk2dUIUpDownHoverButton.ButtonHoverOut += value;
        remove => IL.tk2dUIUpDownHoverButton.ButtonHoverOut -= value;
    }

    public static event ILContext.Manipulator SetState
    {
        add => IL.tk2dUIUpDownHoverButton.SetState += value;
        remove => IL.tk2dUIUpDownHoverButton.SetState -= value;
    }

    public static event ILContext.Manipulator InternalSetUseOnReleaseInsteadOfOnUp
    {
        add => IL.tk2dUIUpDownHoverButton.InternalSetUseOnReleaseInsteadOfOnUp += value;
        remove => IL.tk2dUIUpDownHoverButton.InternalSetUseOnReleaseInsteadOfOnUp -= value;
    }
}