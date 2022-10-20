namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CameraShake.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCameraShake
{
    public static event ILContext.Manipulator Init
    {
        add => IL.CameraShake.Init += value;
        remove => IL.CameraShake.Init -= value;
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.CameraShake.Awake += value;
        remove => IL.CameraShake.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.CameraShake.OnEnable += value;
        remove => IL.CameraShake.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.CameraShake.OnDisable += value;
        remove => IL.CameraShake.OnDisable -= value;
    }

    public static event ILContext.Manipulator ShakeSingle
    {
        add => IL.CameraShake.ShakeSingle += value;
        remove => IL.CameraShake.ShakeSingle -= value;
    }

    public static event ILContext.Manipulator Shake
    {
        add => IL.CameraShake.Shake += value;
        remove => IL.CameraShake.Shake -= value;
    }
}