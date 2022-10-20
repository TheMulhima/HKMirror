using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MusicRegion.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMusicRegion
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.MusicRegion.Reset += value;
        remove => IL.MusicRegion.Reset -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.MusicRegion.OnTriggerEnter2D += value;
        remove => IL.MusicRegion.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerExit2D
    {
        add => IL.MusicRegion.OnTriggerExit2D += value;
        remove => IL.MusicRegion.OnTriggerExit2D -= value;
    }

    public static event ILContext.Manipulator FadeIn
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(MusicRegion), "FadeIn").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(MusicRegion), "FadeIn").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator FadeOut
    {
        add => IL.MusicRegion.FadeOut += value;
        remove => IL.MusicRegion.FadeOut -= value;
    }
}