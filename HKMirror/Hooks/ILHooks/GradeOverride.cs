namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GradeOverride.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGradeOverride
{
    public static event ILContext.Manipulator Start
    {
        add => IL.GradeOverride.Start += value;
        remove => IL.GradeOverride.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.GradeOverride.OnEnable += value;
        remove => IL.GradeOverride.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.GradeOverride.OnDisable += value;
        remove => IL.GradeOverride.OnDisable -= value;
    }

    public static event ILContext.Manipulator Activate
    {
        add => IL.GradeOverride.Activate += value;
        remove => IL.GradeOverride.Activate -= value;
    }

    public static event ILContext.Manipulator Deactivate
    {
        add => IL.GradeOverride.Deactivate += value;
        remove => IL.GradeOverride.Deactivate -= value;
    }
}