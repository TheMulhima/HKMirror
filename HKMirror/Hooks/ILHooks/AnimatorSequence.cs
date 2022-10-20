using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for AnimatorSequence.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILAnimatorSequence
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.AnimatorSequence.Awake += value;
        remove => IL.AnimatorSequence.Awake -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.AnimatorSequence.Update += value;
        remove => IL.AnimatorSequence.Update -= value;
    }

    public static event ILContext.Manipulator Begin
    {
        add => IL.AnimatorSequence.Begin += value;
        remove => IL.AnimatorSequence.Begin -= value;
    }

    public static event ILContext.Manipulator get_IsPlaying
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(AnimatorSequence), "get_IsPlaying"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(AnimatorSequence), "get_IsPlaying"), value);
    }

    public static event ILContext.Manipulator Skip
    {
        add => IL.AnimatorSequence.Skip += value;
        remove => IL.AnimatorSequence.Skip -= value;
    }

    public static event ILContext.Manipulator get_IsSkipped
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(AnimatorSequence), "get_IsSkipped"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(AnimatorSequence), "get_IsSkipped"), value);
    }

    public static event ILContext.Manipulator get_FadeByController
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(AnimatorSequence), "get_FadeByController"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(AnimatorSequence), "get_FadeByController"), value);
    }

    public static event ILContext.Manipulator set_FadeByController
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(AnimatorSequence), "set_FadeByController"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(AnimatorSequence), "set_FadeByController"), value);
    }
}