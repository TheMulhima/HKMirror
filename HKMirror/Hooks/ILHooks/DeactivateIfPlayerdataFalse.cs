namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for DeactivateIfPlayerdataFalse.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDeactivateIfPlayerdataFalse
{
    public static event ILContext.Manipulator Start
    {
        add => IL.DeactivateIfPlayerdataFalse.Start += value;
        remove => IL.DeactivateIfPlayerdataFalse.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.DeactivateIfPlayerdataFalse.OnEnable += value;
        remove => IL.DeactivateIfPlayerdataFalse.OnEnable -= value;
    }
}