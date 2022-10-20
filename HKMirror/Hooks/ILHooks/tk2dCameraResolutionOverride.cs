using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dCameraResolutionOverride.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dCameraResolutionOverride
{
    public static event ILContext.Manipulator Match
    {
        add => IL.tk2dCameraResolutionOverride.Match += value;
        remove => IL.tk2dCameraResolutionOverride.Match -= value;
    }

    public static event ILContext.Manipulator Upgrade
    {
        add => IL.tk2dCameraResolutionOverride.Upgrade += value;
        remove => IL.tk2dCameraResolutionOverride.Upgrade -= value;
    }

    public static event ILContext.Manipulator get_DefaultOverride
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dCameraResolutionOverride), "get_DefaultOverride", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(tk2dCameraResolutionOverride), "get_DefaultOverride", false), value);
    }
}