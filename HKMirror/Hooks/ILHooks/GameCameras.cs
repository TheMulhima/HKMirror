using MonoMod.RuntimeDetour.HookGen;

namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GameCameras.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGameCameras
{
    public static event ILContext.Manipulator get_sceneParticles
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameCameras), "get_sceneParticles"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameCameras), "get_sceneParticles"), value);
    }

    public static event ILContext.Manipulator set_sceneParticles
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameCameras), "set_sceneParticles"),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameCameras), "set_sceneParticles"), value);
    }

    public static event ILContext.Manipulator get_instance
    {
        add => HookEndpointManager.Modify(ReflectionHelper.GetMethodInfo(typeof(GameCameras), "get_instance", false),
            value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameCameras), "get_instance", false), value);
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.GameCameras.Awake += value;
        remove => IL.GameCameras.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.GameCameras.Start += value;
        remove => IL.GameCameras.Start -= value;
    }

    public static event ILContext.Manipulator SceneInit
    {
        add => IL.GameCameras.SceneInit += value;
        remove => IL.GameCameras.SceneInit -= value;
    }

    public static event ILContext.Manipulator OnDestroy
    {
        add => IL.GameCameras.OnDestroy += value;
        remove => IL.GameCameras.OnDestroy -= value;
    }

    public static event ILContext.Manipulator SetupGameRefs
    {
        add => IL.GameCameras.SetupGameRefs += value;
        remove => IL.GameCameras.SetupGameRefs -= value;
    }

    public static event ILContext.Manipulator StartScene
    {
        add => IL.GameCameras.StartScene += value;
        remove => IL.GameCameras.StartScene -= value;
    }

    public static event ILContext.Manipulator MoveMenuToHUDCamera
    {
        add => IL.GameCameras.MoveMenuToHUDCamera += value;
        remove => IL.GameCameras.MoveMenuToHUDCamera -= value;
    }

    public static event ILContext.Manipulator DisableHUDCamIfAllowed
    {
        add => IL.GameCameras.DisableHUDCamIfAllowed += value;
        remove => IL.GameCameras.DisableHUDCamIfAllowed -= value;
    }

    public static event ILContext.Manipulator StopCameraShake
    {
        add => IL.GameCameras.StopCameraShake += value;
        remove => IL.GameCameras.StopCameraShake -= value;
    }

    public static event ILContext.Manipulator ResumeCameraShake
    {
        add => IL.GameCameras.ResumeCameraShake += value;
        remove => IL.GameCameras.ResumeCameraShake -= value;
    }

    public static event ILContext.Manipulator DisableImageEffects
    {
        add => IL.GameCameras.DisableImageEffects += value;
        remove => IL.GameCameras.DisableImageEffects -= value;
    }

    public static event ILContext.Manipulator EnableImageEffects
    {
        add => IL.GameCameras.EnableImageEffects += value;
        remove => IL.GameCameras.EnableImageEffects -= value;
    }

    public static event ILContext.Manipulator SetOverscan
    {
        add => IL.GameCameras.SetOverscan += value;
        remove => IL.GameCameras.SetOverscan -= value;
    }

    public static event ILContext.Manipulator TestParentForPosition
    {
        add => IL.GameCameras.TestParentForPosition += value;
        remove => IL.GameCameras.TestParentForPosition -= value;
    }

    public static event ILContext.Manipulator orig_get_instance
    {
        add => HookEndpointManager.Modify(
            ReflectionHelper.GetMethodInfo(typeof(GameCameras), "orig_get_instance", false), value);
        remove => HookEndpointManager.Unmodify(
            ReflectionHelper.GetMethodInfo(typeof(GameCameras), "orig_get_instance", false), value);
    }
}