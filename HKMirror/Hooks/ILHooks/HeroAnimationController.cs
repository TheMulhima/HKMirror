using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for HeroAnimationController.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILHeroAnimationController
{
    public static event ILContext.Manipulator get_actorState
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HeroAnimationController), "get_actorState"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HeroAnimationController), "get_actorState"), value);
    }

    public static event ILContext.Manipulator set_actorState
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HeroAnimationController), "set_actorState"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HeroAnimationController), "set_actorState"), value);
    }

    public static event ILContext.Manipulator get_prevActorState
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HeroAnimationController), "get_prevActorState"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HeroAnimationController), "get_prevActorState"), value);
    }

    public static event ILContext.Manipulator set_prevActorState
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HeroAnimationController), "set_prevActorState"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HeroAnimationController), "set_prevActorState"), value);
    }

    public static event ILContext.Manipulator get_stateBeforeControl
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HeroAnimationController), "get_stateBeforeControl"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HeroAnimationController), "get_stateBeforeControl"), value);
    }

    public static event ILContext.Manipulator set_stateBeforeControl
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HeroAnimationController), "set_stateBeforeControl"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HeroAnimationController), "set_stateBeforeControl"), value);
    }

    public static event ILContext.Manipulator get_controlEnabled
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HeroAnimationController), "get_controlEnabled"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HeroAnimationController), "get_controlEnabled"), value);
    }

    public static event ILContext.Manipulator set_controlEnabled
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(HeroAnimationController), "set_controlEnabled"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(HeroAnimationController), "set_controlEnabled"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.HeroAnimationController.Awake += value;
        remove => IL.HeroAnimationController.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.HeroAnimationController.Start += value;
        remove => IL.HeroAnimationController.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.HeroAnimationController.Update += value;
        remove => IL.HeroAnimationController.Update -= value;
    }

    public static event ILContext.Manipulator ResetAll
    {
        add => IL.HeroAnimationController.ResetAll += value;
        remove => IL.HeroAnimationController.ResetAll -= value;
    }

    public static event ILContext.Manipulator ResetPlays
    {
        add => IL.HeroAnimationController.ResetPlays += value;
        remove => IL.HeroAnimationController.ResetPlays -= value;
    }

    public static event ILContext.Manipulator UpdateState
    {
        add => IL.HeroAnimationController.UpdateState += value;
        remove => IL.HeroAnimationController.UpdateState -= value;
    }

    public static event ILContext.Manipulator PlayClip
    {
        add => IL.HeroAnimationController.PlayClip += value;
        remove => IL.HeroAnimationController.PlayClip -= value;
    }

    public static event ILContext.Manipulator UpdateAnimation
    {
        add => IL.HeroAnimationController.UpdateAnimation += value;
        remove => IL.HeroAnimationController.UpdateAnimation -= value;
    }

    public static event ILContext.Manipulator CanPlayIdle
    {
        add => IL.HeroAnimationController.CanPlayIdle += value;
        remove => IL.HeroAnimationController.CanPlayIdle -= value;
    }

    public static event ILContext.Manipulator CanPlayLookDown
    {
        add => IL.HeroAnimationController.CanPlayLookDown += value;
        remove => IL.HeroAnimationController.CanPlayLookDown -= value;
    }

    public static event ILContext.Manipulator canPlayTurn
    {
        add => IL.HeroAnimationController.canPlayTurn += value;
        remove => IL.HeroAnimationController.canPlayTurn -= value;
    }

    public static event ILContext.Manipulator AnimationCompleteDelegate
    {
        add => IL.HeroAnimationController.AnimationCompleteDelegate += value;
        remove => IL.HeroAnimationController.AnimationCompleteDelegate -= value;
    }

    public static event ILContext.Manipulator PlayIdle
    {
        add => IL.HeroAnimationController.PlayIdle += value;
        remove => IL.HeroAnimationController.PlayIdle -= value;
    }

    public static event ILContext.Manipulator PlayRun
    {
        add => IL.HeroAnimationController.PlayRun += value;
        remove => IL.HeroAnimationController.PlayRun -= value;
    }

    public static event ILContext.Manipulator Play
    {
        add => IL.HeroAnimationController.Play += value;
        remove => IL.HeroAnimationController.Play -= value;
    }

    public static event ILContext.Manipulator PlayFromFrame
    {
        add => IL.HeroAnimationController.PlayFromFrame += value;
        remove => IL.HeroAnimationController.PlayFromFrame -= value;
    }

    public static event ILContext.Manipulator StopControl
    {
        add => IL.HeroAnimationController.StopControl += value;
        remove => IL.HeroAnimationController.StopControl -= value;
    }

    public static event ILContext.Manipulator StartControl
    {
        add => IL.HeroAnimationController.StartControl += value;
        remove => IL.HeroAnimationController.StartControl -= value;
    }

    public static event ILContext.Manipulator StartControlWithoutSettingState
    {
        add => IL.HeroAnimationController.StartControlWithoutSettingState += value;
        remove => IL.HeroAnimationController.StartControlWithoutSettingState -= value;
    }

    public static event ILContext.Manipulator FinishedDash
    {
        add => IL.HeroAnimationController.FinishedDash += value;
        remove => IL.HeroAnimationController.FinishedDash -= value;
    }

    public static event ILContext.Manipulator StopAttack
    {
        add => IL.HeroAnimationController.StopAttack += value;
        remove => IL.HeroAnimationController.StopAttack -= value;
    }

    public static event ILContext.Manipulator GetCurrentClipDuration
    {
        add => IL.HeroAnimationController.GetCurrentClipDuration += value;
        remove => IL.HeroAnimationController.GetCurrentClipDuration -= value;
    }

    public static event ILContext.Manipulator GetClipDuration
    {
        add => IL.HeroAnimationController.GetClipDuration += value;
        remove => IL.HeroAnimationController.GetClipDuration -= value;
    }
}