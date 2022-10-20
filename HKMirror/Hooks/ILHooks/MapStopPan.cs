namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MapStopPan.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMapStopPan
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.MapStopPan.Reset += value;
        remove => IL.MapStopPan.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.MapStopPan.OnEnter += value;
        remove => IL.MapStopPan.OnEnter -= value;
    }
}