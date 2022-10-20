namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GrubPin.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGrubPin
{
    public static event ILContext.Manipulator Start
    {
        add => IL.GrubPin.Start += value;
        remove => IL.GrubPin.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.GrubPin.OnEnable += value;
        remove => IL.GrubPin.OnEnable -= value;
    }
}