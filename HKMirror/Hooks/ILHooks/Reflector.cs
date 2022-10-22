using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Reflector,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILReflector
{
    public static event ILContext.Manipulator get_AllAssemblyTypes
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Reflector), "get_AllAssemblyTypes", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Reflector), "get_AllAssemblyTypes", false), value);
    }

    public static event ILContext.Manipulator IgnoreAssemblyWithName
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Reflector), "IgnoreAssemblyWithName", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Reflector), "IgnoreAssemblyWithName", false), value);
    }

    public static event ILContext.Manipulator GetAllAssemblyTypes
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Reflector), "GetAllAssemblyTypes", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Reflector), "GetAllAssemblyTypes", false), value);
    }
}