namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CameraTarget.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCameraTarget
{
    public static event ILContext.Manipulator GameInit
    {
        add => IL.CameraTarget.GameInit += value;
        remove => IL.CameraTarget.GameInit -= value;
    }

    public static event ILContext.Manipulator SceneInit
    {
        add => IL.CameraTarget.SceneInit += value;
        remove => IL.CameraTarget.SceneInit -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.CameraTarget.Update += value;
        remove => IL.CameraTarget.Update -= value;
    }

    public static event ILContext.Manipulator EnterLockZone
    {
        add => IL.CameraTarget.EnterLockZone += value;
        remove => IL.CameraTarget.EnterLockZone -= value;
    }

    public static event ILContext.Manipulator EnterLockZoneInstant
    {
        add => IL.CameraTarget.EnterLockZoneInstant += value;
        remove => IL.CameraTarget.EnterLockZoneInstant -= value;
    }

    public static event ILContext.Manipulator ExitLockZone
    {
        add => IL.CameraTarget.ExitLockZone += value;
        remove => IL.CameraTarget.ExitLockZone -= value;
    }

    public static event ILContext.Manipulator SetDampTime
    {
        add => IL.CameraTarget.SetDampTime += value;
        remove => IL.CameraTarget.SetDampTime -= value;
    }

    public static event ILContext.Manipulator SetSuperDash
    {
        add => IL.CameraTarget.SetSuperDash += value;
        remove => IL.CameraTarget.SetSuperDash -= value;
    }

    public static event ILContext.Manipulator SetQuake
    {
        add => IL.CameraTarget.SetQuake += value;
        remove => IL.CameraTarget.SetQuake -= value;
    }

    public static event ILContext.Manipulator FreezeInPlace
    {
        add => IL.CameraTarget.FreezeInPlace += value;
        remove => IL.CameraTarget.FreezeInPlace -= value;
    }

    public static event ILContext.Manipulator PositionToStart
    {
        add => IL.CameraTarget.PositionToStart += value;
        remove => IL.CameraTarget.PositionToStart -= value;
    }
}