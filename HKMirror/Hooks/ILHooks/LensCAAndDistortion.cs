using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for LensCAAndDistortion.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILLensCAAndDistortion
{
    public static event ILContext.Manipulator get_material
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(LensCAAndDistortion), "get_material"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(LensCAAndDistortion), "get_material"), value);
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.LensCAAndDistortion.Start += value;
        remove => IL.LensCAAndDistortion.Start -= value;
    }

    public static event ILContext.Manipulator OnRenderImage
    {
        add => IL.LensCAAndDistortion.OnRenderImage += value;
        remove => IL.LensCAAndDistortion.OnRenderImage -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.LensCAAndDistortion.Update += value;
        remove => IL.LensCAAndDistortion.Update -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.LensCAAndDistortion.OnDisable += value;
        remove => IL.LensCAAndDistortion.OnDisable -= value;
    }
}