using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for FadeSequence.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILFadeSequence
{
    public static event ILContext.Manipulator get_IsSkipped
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(FadeSequence), "get_IsSkipped"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(FadeSequence), "get_IsSkipped"),
            value);
    }

    public static event ILContext.Manipulator get_FadeRate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(FadeSequence), "get_FadeRate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(FadeSequence), "get_FadeRate"),
            value);
    }

    public static event ILContext.Manipulator get_FadeByController
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(FadeSequence), "get_FadeByController"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(FadeSequence), "get_FadeByController"), value);
    }

    public static event ILContext.Manipulator set_FadeByController
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(FadeSequence), "set_FadeByController"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(FadeSequence), "set_FadeByController"), value);
    }

    public static event ILContext.Manipulator get_IsPlaying
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(FadeSequence), "get_IsPlaying"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(FadeSequence), "get_IsPlaying"),
            value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.FadeSequence.Awake += value;
        remove => IL.FadeSequence.Awake -= value;
    }

    public static event ILContext.Manipulator Begin
    {
        add => IL.FadeSequence.Begin += value;
        remove => IL.FadeSequence.Begin -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.FadeSequence.Update += value;
        remove => IL.FadeSequence.Update -= value;
    }

    public static event ILContext.Manipulator Skip
    {
        add => IL.FadeSequence.Skip += value;
        remove => IL.FadeSequence.Skip -= value;
    }

    public static event ILContext.Manipulator UpdateFade
    {
        add => IL.FadeSequence.UpdateFade += value;
        remove => IL.FadeSequence.UpdateFade -= value;
    }
}