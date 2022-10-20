using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Crawler.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCrawler
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.Crawler.Awake += value;
        remove => IL.Crawler.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.Crawler.Start += value;
        remove => IL.Crawler.Start -= value;
    }

    public static event ILContext.Manipulator Walk
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Crawler), "Walk").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Crawler), "Walk").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator Turn
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(Crawler), "Turn").GetStateMachineTarget(), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(Crawler), "Turn").GetStateMachineTarget(), value);
    }

    public static event ILContext.Manipulator CheckRayLocal
    {
        add => IL.Crawler.CheckRayLocal += value;
        remove => IL.Crawler.CheckRayLocal -= value;
    }
}