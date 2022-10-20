namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ConstrainPosition.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILConstrainPosition
{
    public static event ILContext.Manipulator Update
    {
        add => IL.ConstrainPosition.Update += value;
        remove => IL.ConstrainPosition.Update -= value;
    }
}