using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for tk2dUIProgressBar.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILtk2dUIProgressBar
{
    public static event ILContext.Manipulator Start
    {
        add => IL.tk2dUIProgressBar.Start += value;
        remove => IL.tk2dUIProgressBar.Start -= value;
    }

    public static event ILContext.Manipulator get_Value
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIProgressBar), "get_Value"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIProgressBar), "get_Value"),
            value);
    }

    public static event ILContext.Manipulator set_Value
    {
        add =>
            HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIProgressBar), "set_Value"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(tk2dUIProgressBar), "set_Value"),
            value);
    }

    public static event ILContext.Manipulator InitializeSlicedSpriteDimensions
    {
        add => IL.tk2dUIProgressBar.InitializeSlicedSpriteDimensions += value;
        remove => IL.tk2dUIProgressBar.InitializeSlicedSpriteDimensions -= value;
    }
}