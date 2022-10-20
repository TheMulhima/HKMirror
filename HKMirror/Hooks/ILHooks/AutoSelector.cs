using Modding.Menu.Components;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for AutoSelector.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILAutoSelector
{
    public static event ILContext.Manipulator get_Start
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(AutoSelector), "get_Start"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(AutoSelector), "get_Start"), value);
    }

    public static event ILContext.Manipulator set_Start
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(AutoSelector), "set_Start"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(AutoSelector), "set_Start"), value);
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(AutoSelector), "OnEnable"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(AutoSelector), "OnEnable"), value);
    }

    public static event ILContext.Manipulator SelectDelayed
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(AutoSelector), "SelectDelayed").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(AutoSelector), "SelectDelayed").GetStateMachineTarget(), value);
    }
}