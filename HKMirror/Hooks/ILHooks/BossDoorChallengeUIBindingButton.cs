using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BossDoorChallengeUIBindingButton.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBossDoorChallengeUIBindingButton
{
    public static event ILContext.Manipulator get_Selected
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorChallengeUIBindingButton), "get_Selected"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorChallengeUIBindingButton), "get_Selected"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.BossDoorChallengeUIBindingButton.Awake += value;
        remove => IL.BossDoorChallengeUIBindingButton.Awake -= value;
    }

    public static event ILContext.Manipulator Reset
    {
        add => IL.BossDoorChallengeUIBindingButton.Reset += value;
        remove => IL.BossDoorChallengeUIBindingButton.Reset -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.BossDoorChallengeUIBindingButton.OnDisable += value;
        remove => IL.BossDoorChallengeUIBindingButton.OnDisable -= value;
    }

    public static event ILContext.Manipulator OnSubmit
    {
        add => IL.BossDoorChallengeUIBindingButton.OnSubmit += value;
        remove => IL.BossDoorChallengeUIBindingButton.OnSubmit -= value;
    }

    public static event ILContext.Manipulator SetAllSelected
    {
        add => IL.BossDoorChallengeUIBindingButton.SetAllSelected += value;
        remove => IL.BossDoorChallengeUIBindingButton.SetAllSelected -= value;
    }

    public static event ILContext.Manipulator SetAnimSizeDelayed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorChallengeUIBindingButton), "SetAnimSizeDelayed")
                .GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(BossDoorChallengeUIBindingButton), "SetAnimSizeDelayed")
                .GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator OnCancel
    {
        add => IL.BossDoorChallengeUIBindingButton.OnCancel += value;
        remove => IL.BossDoorChallengeUIBindingButton.OnCancel -= value;
    }

    public static event ILContext.Manipulator OnPointerClick
    {
        add => IL.BossDoorChallengeUIBindingButton.OnPointerClick += value;
        remove => IL.BossDoorChallengeUIBindingButton.OnPointerClick -= value;
    }
}