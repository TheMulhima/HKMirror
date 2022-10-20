using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Tk2dPlayAnimationWithEvents.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTk2dPlayAnimationWithEvents
{
    public static event ILContext.Manipulator _getSprite
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dPlayAnimationWithEvents), "_getSprite"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dPlayAnimationWithEvents), "_getSprite"), value);
    }

    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Tk2dPlayAnimationWithEvents), "Reset"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dPlayAnimationWithEvents), "Reset"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dPlayAnimationWithEvents), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dPlayAnimationWithEvents), "OnEnter"), value);
    }

    public static event ILContext.Manipulator DoPlayAnimationWithEvents
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dPlayAnimationWithEvents), "DoPlayAnimationWithEvents"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dPlayAnimationWithEvents), "DoPlayAnimationWithEvents"), value);
    }

    public static event ILContext.Manipulator AnimationEventDelegate
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dPlayAnimationWithEvents), "AnimationEventDelegate"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dPlayAnimationWithEvents), "AnimationEventDelegate"), value);
    }

    public static event ILContext.Manipulator AnimationCompleteDelegate
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dPlayAnimationWithEvents), "AnimationCompleteDelegate"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Tk2dPlayAnimationWithEvents), "AnimationCompleteDelegate"), value);
    }
}