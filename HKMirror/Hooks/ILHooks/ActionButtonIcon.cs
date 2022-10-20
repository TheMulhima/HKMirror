using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ActionButtonIcon.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILActionButtonIcon
{
    public static event ILContext.Manipulator get_Action
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(ActionButtonIcon), "get_Action"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(ActionButtonIcon), "get_Action"),
            value);
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.ActionButtonIcon.OnEnable += value;
        remove => IL.ActionButtonIcon.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.ActionButtonIcon.OnDisable += value;
        remove => IL.ActionButtonIcon.OnDisable -= value;
    }

    public static event ILContext.Manipulator CheckHideIcon
    {
        add => IL.ActionButtonIcon.CheckHideIcon += value;
        remove => IL.ActionButtonIcon.CheckHideIcon -= value;
    }

    public static event ILContext.Manipulator SetAction
    {
        add => IL.ActionButtonIcon.SetAction += value;
        remove => IL.ActionButtonIcon.SetAction -= value;
    }

    public static event ILContext.Manipulator SetActionString
    {
        add => IL.ActionButtonIcon.SetActionString += value;
        remove => IL.ActionButtonIcon.SetActionString -= value;
    }
}