using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for LoadingSpinner.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILLoadingSpinner
{
    public static event ILContext.Manipulator get_DisplayDelayAdjustment
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(LoadingSpinner), "get_DisplayDelayAdjustment"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(LoadingSpinner), "get_DisplayDelayAdjustment"), value);
    }

    public static event ILContext.Manipulator set_DisplayDelayAdjustment
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(LoadingSpinner), "set_DisplayDelayAdjustment"), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(LoadingSpinner), "set_DisplayDelayAdjustment"), value);
    }

    public static event ILContext.Manipulator get_DisplayDelay
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(LoadingSpinner), "get_DisplayDelay"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(LoadingSpinner), "get_DisplayDelay"), value);
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.LoadingSpinner.OnEnable += value;
        remove => IL.LoadingSpinner.OnEnable -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.LoadingSpinner.Start += value;
        remove => IL.LoadingSpinner.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.LoadingSpinner.Update += value;
        remove => IL.LoadingSpinner.Update -= value;
    }
}