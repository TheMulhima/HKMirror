namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CameraControlAnimationEvents.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCameraControlAnimationEvents
{
    public static event ILContext.Manipulator BigShake
    {
        add => IL.CameraControlAnimationEvents.BigShake += value;
        remove => IL.CameraControlAnimationEvents.BigShake -= value;
    }

    public static event ILContext.Manipulator SmallShake
    {
        add => IL.CameraControlAnimationEvents.SmallShake += value;
        remove => IL.CameraControlAnimationEvents.SmallShake -= value;
    }

    public static event ILContext.Manipulator AverageShake
    {
        add => IL.CameraControlAnimationEvents.AverageShake += value;
        remove => IL.CameraControlAnimationEvents.AverageShake -= value;
    }

    public static event ILContext.Manipulator EnemyKillShake
    {
        add => IL.CameraControlAnimationEvents.EnemyKillShake += value;
        remove => IL.CameraControlAnimationEvents.EnemyKillShake -= value;
    }

    public static event ILContext.Manipulator SmallRumble
    {
        add => IL.CameraControlAnimationEvents.SmallRumble += value;
        remove => IL.CameraControlAnimationEvents.SmallRumble -= value;
    }

    public static event ILContext.Manipulator MedRumble
    {
        add => IL.CameraControlAnimationEvents.MedRumble += value;
        remove => IL.CameraControlAnimationEvents.MedRumble -= value;
    }

    public static event ILContext.Manipulator BigRumble
    {
        add => IL.CameraControlAnimationEvents.BigRumble += value;
        remove => IL.CameraControlAnimationEvents.BigRumble -= value;
    }

    public static event ILContext.Manipulator StopRumble
    {
        add => IL.CameraControlAnimationEvents.StopRumble += value;
        remove => IL.CameraControlAnimationEvents.StopRumble -= value;
    }

    public static event ILContext.Manipulator SendCameraEvent
    {
        add => IL.CameraControlAnimationEvents.SendCameraEvent += value;
        remove => IL.CameraControlAnimationEvents.SendCameraEvent -= value;
    }

    public static event ILContext.Manipulator SetCameraBool
    {
        add => IL.CameraControlAnimationEvents.SetCameraBool += value;
        remove => IL.CameraControlAnimationEvents.SetCameraBool -= value;
    }
}