using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ColorFader.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILColorFader
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.ColorFader.Reset += value;
        remove => IL.ColorFader.Reset -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.ColorFader.Start += value;
        remove => IL.ColorFader.Start -= value;
    }

    public static event ILContext.Manipulator Setup
    {
        add => IL.ColorFader.Setup += value;
        remove => IL.ColorFader.Setup -= value;
    }

    public static event ILContext.Manipulator Fade_bool
    {
        add => IL.ColorFader.Fade_bool += value;
        remove => IL.ColorFader.Fade_bool -= value;
    }

    public static event ILContext.Manipulator Fade_Color_float_float
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(ColorFader), "Fade").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(ColorFader), "Fade").GetStateMachineTarget(), value);
    }
}