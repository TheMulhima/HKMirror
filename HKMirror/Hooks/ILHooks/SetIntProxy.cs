using Modding.Delegates;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SetIntProxy.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSetIntProxy
{
    public static event ILContext.Manipulator Invoke
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SetIntProxy), "Invoke"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SetIntProxy), "Invoke"), value);
    }

    public static event ILContext.Manipulator EndInvoke
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SetIntProxy), "EndInvoke"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(SetIntProxy), "EndInvoke"), value);
    }
}