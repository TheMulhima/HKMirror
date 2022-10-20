namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BrokenVesselGlob.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBrokenVesselGlob
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.BrokenVesselGlob.OnEnable += value;
        remove => IL.BrokenVesselGlob.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.BrokenVesselGlob.Update += value;
        remove => IL.BrokenVesselGlob.Update -= value;
    }

    public static event ILContext.Manipulator FixedUpdate
    {
        add => IL.BrokenVesselGlob.FixedUpdate += value;
        remove => IL.BrokenVesselGlob.FixedUpdate -= value;
    }

    public static event ILContext.Manipulator FaceAngle
    {
        add => IL.BrokenVesselGlob.FaceAngle += value;
        remove => IL.BrokenVesselGlob.FaceAngle -= value;
    }

    public static event ILContext.Manipulator ProjectileSquash
    {
        add => IL.BrokenVesselGlob.ProjectileSquash += value;
        remove => IL.BrokenVesselGlob.ProjectileSquash -= value;
    }
}