namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ShowGodfinderIconQueued.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILShowGodfinderIconQueued
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.ShowGodfinderIconQueued.Reset += value;
        remove => IL.ShowGodfinderIconQueued.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.ShowGodfinderIconQueued.OnEnter += value;
        remove => IL.ShowGodfinderIconQueued.OnEnter -= value;
    }
}