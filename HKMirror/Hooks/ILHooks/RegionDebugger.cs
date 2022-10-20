namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for RegionDebugger.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILRegionDebugger
{
    public static event ILContext.Manipulator Start
    {
        add => IL.RegionDebugger.Start += value;
        remove => IL.RegionDebugger.Start -= value;
    }
}