using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dUIUpDownButton.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dUIUpDownButton
{
    public static event ILContext.Manipulator get_UseOnReleaseInsteadOfOnUp
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIUpDownButton), "get_UseOnReleaseInsteadOfOnUp"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIUpDownButton), "get_UseOnReleaseInsteadOfOnUp"), value);
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.tk2dUIUpDownButton.Start += value;
        remove => IL.tk2dUIUpDownButton.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.tk2dUIUpDownButton.OnEnable += value;
        remove => IL.tk2dUIUpDownButton.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.tk2dUIUpDownButton.OnDisable += value;
        remove => IL.tk2dUIUpDownButton.OnDisable -= value;
    }

    public static event ILContext.Manipulator ButtonUp
    {
        add => IL.tk2dUIUpDownButton.ButtonUp += value;
        remove => IL.tk2dUIUpDownButton.ButtonUp -= value;
    }

    public static event ILContext.Manipulator ButtonDown
    {
        add => IL.tk2dUIUpDownButton.ButtonDown += value;
        remove => IL.tk2dUIUpDownButton.ButtonDown -= value;
    }

    public static event ILContext.Manipulator SetState
    {
        add => IL.tk2dUIUpDownButton.SetState += value;
        remove => IL.tk2dUIUpDownButton.SetState -= value;
    }

    public static event ILContext.Manipulator InternalSetUseOnReleaseInsteadOfOnUp
    {
        add => IL.tk2dUIUpDownButton.InternalSetUseOnReleaseInsteadOfOnUp += value;
        remove => IL.tk2dUIUpDownButton.InternalSetUseOnReleaseInsteadOfOnUp -= value;
    }
}