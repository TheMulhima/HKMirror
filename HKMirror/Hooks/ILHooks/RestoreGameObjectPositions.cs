namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for RestoreGameObjectPositions.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILRestoreGameObjectPositions
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.RestoreGameObjectPositions.Reset += value;
        remove => IL.RestoreGameObjectPositions.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.RestoreGameObjectPositions.OnEnter += value;
        remove => IL.RestoreGameObjectPositions.OnEnter -= value;
    }
}