namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ActiveRegion.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILActiveRegion
{
    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.ActiveRegion.OnTriggerEnter2D += value;
        remove => IL.ActiveRegion.OnTriggerEnter2D -= value;
    }
}