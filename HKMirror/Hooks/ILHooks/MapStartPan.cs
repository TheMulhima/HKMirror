namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MapStartPan.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMapStartPan
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.MapStartPan.Reset += value;
        remove => IL.MapStartPan.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.MapStartPan.OnEnter += value;
        remove => IL.MapStartPan.OnEnter -= value;
    }
}