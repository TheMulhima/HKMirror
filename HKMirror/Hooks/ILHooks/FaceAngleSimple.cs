namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for FaceAngleSimple.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILFaceAngleSimple
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.FaceAngleSimple.OnEnable += value;
        remove => IL.FaceAngleSimple.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.FaceAngleSimple.Update += value;
        remove => IL.FaceAngleSimple.Update -= value;
    }

    public static event ILContext.Manipulator DoAngle
    {
        add => IL.FaceAngleSimple.DoAngle += value;
        remove => IL.FaceAngleSimple.DoAngle -= value;
    }
}