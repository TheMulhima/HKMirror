using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GlowResponse.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGlowResponse
{
    public static event ILContext.Manipulator OnValidate
    {
        add => IL.GlowResponse.OnValidate += value;
        remove => IL.GlowResponse.OnValidate -= value;
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.GlowResponse.Awake += value;
        remove => IL.GlowResponse.Awake -= value;
    }

    public static event ILContext.Manipulator HandleUpgrade
    {
        add => IL.GlowResponse.HandleUpgrade += value;
        remove => IL.GlowResponse.HandleUpgrade -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.GlowResponse.Start += value;
        remove => IL.GlowResponse.Start -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.GlowResponse.OnTriggerEnter2D += value;
        remove => IL.GlowResponse.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerExit2D
    {
        add => IL.GlowResponse.OnTriggerExit2D += value;
        remove => IL.GlowResponse.OnTriggerExit2D -= value;
    }

    public static event ILContext.Manipulator FadeTo
    {
        add => IL.GlowResponse.FadeTo += value;
        remove => IL.GlowResponse.FadeTo -= value;
    }

    public static event ILContext.Manipulator Fade
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GlowResponse), "Fade").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GlowResponse), "Fade").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator FadeEnd
    {
        add => IL.GlowResponse.FadeEnd += value;
        remove => IL.GlowResponse.FadeEnd -= value;
    }
}