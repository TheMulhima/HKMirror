using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for FadeAudio.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILFadeAudio
{
    public static event ILContext.Manipulator Reset
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(FadeAudio), "Reset"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(FadeAudio), "Reset"), value);
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(FadeAudio), "OnEnter"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(FadeAudio), "OnEnter"), value);
    }

    public static event ILContext.Manipulator OnExit
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(FadeAudio), "OnExit"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(FadeAudio), "OnExit"), value);
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(FadeAudio), "OnUpdate"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(FadeAudio), "OnUpdate"), value);
    }

    public static event ILContext.Manipulator DoSetAudioVolume
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(FadeAudio), "DoSetAudioVolume"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(FadeAudio), "DoSetAudioVolume"),
            value);
    }
}