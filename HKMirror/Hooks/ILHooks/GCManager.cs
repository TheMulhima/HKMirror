using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GCManager.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGCManager
{
    public static event ILContext.Manipulator get_IsSupported
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GCManager), "get_IsSupported", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GCManager), "get_IsSupported", false), value);
    }

    public static event ILContext.Manipulator get_IsAutomaticCollectionEnabled
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GCManager), "get_IsAutomaticCollectionEnabled", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GCManager), "get_IsAutomaticCollectionEnabled", false), value);
    }

    public static event ILContext.Manipulator set_IsAutomaticCollectionEnabled
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GCManager), "set_IsAutomaticCollectionEnabled", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GCManager), "set_IsAutomaticCollectionEnabled", false), value);
    }

    public static event ILContext.Manipulator Collect
    {
        add => IL.GCManager.Collect += value;
        remove => IL.GCManager.Collect -= value;
    }

    public static event ILContext.Manipulator Init
    {
        add => IL.GCManager.Init += value;
        remove => IL.GCManager.Init -= value;
    }

    public static event ILContext.Manipulator GetMemoryUsage
    {
        add => IL.GCManager.GetMemoryUsage += value;
        remove => IL.GCManager.GetMemoryUsage -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.GCManager.Update += value;
        remove => IL.GCManager.Update -= value;
    }
}