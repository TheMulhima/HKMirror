namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for DeactivateIfPlayerdataTrue.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDeactivateIfPlayerdataTrue
{
    public static event ILContext.Manipulator Start
    {
        add => IL.DeactivateIfPlayerdataTrue.Start += value;
        remove => IL.DeactivateIfPlayerdataTrue.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.DeactivateIfPlayerdataTrue.OnEnable += value;
        remove => IL.DeactivateIfPlayerdataTrue.OnEnable -= value;
    }
}