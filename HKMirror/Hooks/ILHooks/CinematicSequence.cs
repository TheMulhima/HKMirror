using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CinematicSequence.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCinematicSequence
{
    public static event ILContext.Manipulator get_VideoPlayer
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CinematicSequence), "get_VideoPlayer"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicSequence), "get_VideoPlayer"), value);
    }

    public static event ILContext.Manipulator get_IsSkipped
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CinematicSequence), "get_IsSkipped"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicSequence), "get_IsSkipped"), value);
    }

    public static event ILContext.Manipulator get_IsLooping
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CinematicSequence), "get_IsLooping"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicSequence), "get_IsLooping"), value);
    }

    public static event ILContext.Manipulator set_IsLooping
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CinematicSequence), "set_IsLooping"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicSequence), "set_IsLooping"), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.CinematicSequence.Awake += value;
        remove => IL.CinematicSequence.Awake -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.CinematicSequence.OnDestroy += value;
        remove => IL.CinematicSequence.OnDestroy -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.CinematicSequence.Update += value;
        remove => IL.CinematicSequence.Update -= value;
    }

    public static event ILContext.Manipulator Begin
    {
        add => IL.CinematicSequence.Begin += value;
        remove => IL.CinematicSequence.Begin -= value;
    }

    public static event ILContext.Manipulator UpdateBlanker
    {
        add => IL.CinematicSequence.UpdateBlanker += value;
        remove => IL.CinematicSequence.UpdateBlanker -= value;
    }

    public static event ILContext.Manipulator get_IsPlaying
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(CinematicSequence), "get_IsPlaying"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicSequence), "get_IsPlaying"), value);
    }

    public static event ILContext.Manipulator Skip
    {
        add => IL.CinematicSequence.Skip += value;
        remove => IL.CinematicSequence.Skip -= value;
    }

    public static event ILContext.Manipulator get_FadeByController
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicSequence), "get_FadeByController"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicSequence), "get_FadeByController"), value);
    }

    public static event ILContext.Manipulator set_FadeByController
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicSequence), "set_FadeByController"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(CinematicSequence), "set_FadeByController"), value);
    }
}