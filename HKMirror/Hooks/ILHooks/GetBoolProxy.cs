using Modding.Delegates;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GetBoolProxy.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGetBoolProxy
{
    public static event ILContext.Manipulator Invoke
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GetBoolProxy), "Invoke"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GetBoolProxy), "Invoke"), value);
    }

    public static event ILContext.Manipulator EndInvoke
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GetBoolProxy), "EndInvoke"), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(GetBoolProxy), "EndInvoke"), value);
    }
}