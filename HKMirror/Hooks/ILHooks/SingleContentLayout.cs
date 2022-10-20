using Modding.Menu;
using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SingleContentLayout.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSingleContentLayout
{
    public static event ILContext.Manipulator get_Position
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SingleContentLayout), "get_Position"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SingleContentLayout), "get_Position"), value);
    }

    public static event ILContext.Manipulator set_Position
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SingleContentLayout), "set_Position"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SingleContentLayout), "set_Position"), value);
    }

    public static event ILContext.Manipulator ModifyNext
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(SingleContentLayout), "ModifyNext"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(SingleContentLayout), "ModifyNext"), value);
    }
}