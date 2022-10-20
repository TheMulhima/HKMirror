using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dUIAudioManager.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dUIAudioManager
{
    public static event ILContext.Manipulator get_Instance
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIAudioManager), "get_Instance", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dUIAudioManager), "get_Instance", false), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.tk2dUIAudioManager.Awake += value;
        remove => IL.tk2dUIAudioManager.Awake -= value;
    }

    public static event ILContext.Manipulator Setup
    {
        add => IL.tk2dUIAudioManager.Setup += value;
        remove => IL.tk2dUIAudioManager.Setup -= value;
    }

    public static event ILContext.Manipulator Play
    {
        add => IL.tk2dUIAudioManager.Play += value;
        remove => IL.tk2dUIAudioManager.Play -= value;
    }
}