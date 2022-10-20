using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SpriteFadeMaterial.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSpriteFadeMaterial
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.SpriteFadeMaterial.Awake += value;
        remove => IL.SpriteFadeMaterial.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.SpriteFadeMaterial.Start += value;
        remove => IL.SpriteFadeMaterial.Start -= value;
    }

    public static event ILContext.Manipulator FadeBack
    {
        add => IL.SpriteFadeMaterial.FadeBack += value;
        remove => IL.SpriteFadeMaterial.FadeBack -= value;
    }

    public static event ILContext.Manipulator FadeBackRoutine
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(SpriteFadeMaterial), "FadeBackRoutine").GetStateMachineTarget(),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SpriteFadeMaterial), "FadeBackRoutine").GetStateMachineTarget(),
            value);
    }
}