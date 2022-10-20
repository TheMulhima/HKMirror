using MonoMod.RuntimeDetour.HookGen;
using TMPro;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for FastAction.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILFastAction
{
    public static event ILContext.Manipulator Add
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(FastAction), "Add"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(FastAction), "Add"), value);
    }

    public static event ILContext.Manipulator Remove
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(FastAction), "Remove"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(FastAction), "Remove"), value);
    }

    public static event ILContext.Manipulator Call
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(FastAction), "Call"), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(FastAction), "Call"), value);
    }
}