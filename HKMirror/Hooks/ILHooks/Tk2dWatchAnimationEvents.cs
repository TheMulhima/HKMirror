using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Tk2dWatchAnimationEvents.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTk2dWatchAnimationEvents
{
    public static event ILContext.Manipulator _getSprite
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dWatchAnimationEvents), "_getSprite"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dWatchAnimationEvents), "_getSprite"), value);
    }

    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Tk2dWatchAnimationEvents), "Reset"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dWatchAnimationEvents), "Reset"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Tk2dWatchAnimationEvents), "OnEnter"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dWatchAnimationEvents), "OnEnter"), value);
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Tk2dWatchAnimationEvents), "OnUpdate"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dWatchAnimationEvents), "OnUpdate"), value);
    }

    public static event ILContext.Manipulator DoWatchAnimationWithEvents
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dWatchAnimationEvents), "DoWatchAnimationWithEvents"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dWatchAnimationEvents), "DoWatchAnimationWithEvents"), value);
    }

    public static event ILContext.Manipulator AnimationEventDelegate
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dWatchAnimationEvents), "AnimationEventDelegate"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dWatchAnimationEvents), "AnimationEventDelegate"), value);
    }

    public static event ILContext.Manipulator AnimationCompleteDelegate
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dWatchAnimationEvents), "AnimationCompleteDelegate"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dWatchAnimationEvents), "AnimationCompleteDelegate"), value);
    }
}