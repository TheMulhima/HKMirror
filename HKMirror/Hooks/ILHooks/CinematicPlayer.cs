using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CinematicPlayer.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCinematicPlayer
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.CinematicPlayer.Awake += value;
        remove => IL.CinematicPlayer.Awake -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.CinematicPlayer.OnDestroy += value;
        remove => IL.CinematicPlayer.OnDestroy -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.CinematicPlayer.Start += value;
        remove => IL.CinematicPlayer.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.CinematicPlayer.Update += value;
        remove => IL.CinematicPlayer.Update -= value;
    }

    public static event ILContext.Manipulator Update10
    {
        add => IL.CinematicPlayer.Update10 += value;
        remove => IL.CinematicPlayer.Update10 -= value;
    }

    public static event ILContext.Manipulator SkipVideo
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicPlayer), "SkipVideo").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicPlayer), "SkipVideo").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator TriggerStartVideo
    {
        add => IL.CinematicPlayer.TriggerStartVideo += value;
        remove => IL.CinematicPlayer.TriggerStartVideo -= value;
    }

    public static event ILContext.Manipulator TriggerStopVideo
    {
        add => IL.CinematicPlayer.TriggerStopVideo += value;
        remove => IL.CinematicPlayer.TriggerStopVideo -= value;
    }

    public static event ILContext.Manipulator UnlockSkip
    {
        add => IL.CinematicPlayer.UnlockSkip += value;
        remove => IL.CinematicPlayer.UnlockSkip -= value;
    }

    public static event ILContext.Manipulator StartVideo
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicPlayer), "StartVideo").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicPlayer), "StartVideo").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator FinishVideo
    {
        add => IL.CinematicPlayer.FinishVideo += value;
        remove => IL.CinematicPlayer.FinishVideo -= value;
    }

    public static event ILContext.Manipulator FinishInGameVideo
    {
        add => IL.CinematicPlayer.FinishInGameVideo += value;
        remove => IL.CinematicPlayer.FinishInGameVideo -= value;
    }

    public static event ILContext.Manipulator WaitForStagFadeOut
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicPlayer), "WaitForStagFadeOut").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicPlayer), "WaitForStagFadeOut").GetStateMachineTarget(),
            value);
    }
}