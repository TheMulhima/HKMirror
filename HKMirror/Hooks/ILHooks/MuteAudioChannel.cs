using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MuteAudioChannel.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMuteAudioChannel
{
    public static event ILContext.Manipulator get_Volume
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MuteAudioChannel), "get_Volume"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MuteAudioChannel), "get_Volume"),
            value);
    }

    public static event ILContext.Manipulator set_Volume
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(MuteAudioChannel), "set_Volume"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(MuteAudioChannel), "set_Volume"),
            value);
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.MuteAudioChannel.OnEnable += value;
        remove => IL.MuteAudioChannel.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.MuteAudioChannel.OnDisable += value;
        remove => IL.MuteAudioChannel.OnDisable -= value;
    }

    public static event ILContext.Manipulator LinearToDecibel
    {
        add => IL.MuteAudioChannel.LinearToDecibel += value;
        remove => IL.MuteAudioChannel.LinearToDecibel -= value;
    }

    public static event ILContext.Manipulator DecibelToLinear
    {
        add => IL.MuteAudioChannel.DecibelToLinear += value;
        remove => IL.MuteAudioChannel.DecibelToLinear -= value;
    }
}