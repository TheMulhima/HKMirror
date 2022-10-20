using MonoMod.RuntimeDetour.HookGen;
using Logger = InControl.Logger;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Logger.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILLogger
{
    public static event ILContext.Manipulator LogInfo
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Logger), "LogInfo", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Logger), "LogInfo", false), value);
    }

    public static event ILContext.Manipulator LogWarning
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Logger), "LogWarning", false), value);
        remove => HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Logger), "LogWarning", false),
            value);
    }

    public static event ILContext.Manipulator LogError
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(Logger), "LogError", false), value);
        remove =>
            HookEndpointManager.Unmodify(ReflectionHelper.GetMethodInfo(typeof(Logger), "LogError", false), value);
    }
}