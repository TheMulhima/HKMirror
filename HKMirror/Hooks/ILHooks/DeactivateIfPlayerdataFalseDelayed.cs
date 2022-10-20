namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for DeactivateIfPlayerdataFalseDelayed.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDeactivateIfPlayerdataFalseDelayed
{
    public static event ILContext.Manipulator Start
    {
        add => IL.DeactivateIfPlayerdataFalseDelayed.Start += value;
        remove => IL.DeactivateIfPlayerdataFalseDelayed.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.DeactivateIfPlayerdataFalseDelayed.OnEnable += value;
        remove => IL.DeactivateIfPlayerdataFalseDelayed.OnEnable -= value;
    }

    public static event ILContext.Manipulator DoCheck
    {
        add => IL.DeactivateIfPlayerdataFalseDelayed.DoCheck += value;
        remove => IL.DeactivateIfPlayerdataFalseDelayed.DoCheck -= value;
    }
}