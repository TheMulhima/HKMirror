using UnityEngine.UI;

namespace HKMirror.Reflection;

/// <summary>
///     A class that contains all (public and private) fields and methods of GameCameras allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public static class GameCamerasR
{
    public static Camera hudCamera
    {
        get => GameCameras.instance.hudCamera;
        set => GameCameras.instance.hudCamera = value;
    }

    public static Camera mainCamera
    {
        get => GameCameras.instance.mainCamera;
        set => GameCameras.instance.mainCamera = value;
    }

    public static CameraController cameraController
    {
        get => GameCameras.instance.cameraController;
        set => GameCameras.instance.cameraController = value;
    }

    public static CameraTarget cameraTarget
    {
        get => GameCameras.instance.cameraTarget;
        set => GameCameras.instance.cameraTarget = value;
    }

    public static ForceCameraAspect forceCameraAspect
    {
        get => GameCameras.instance.forceCameraAspect;
        set => GameCameras.instance.forceCameraAspect = value;
    }

    public static PlayMakerFSM cameraFadeFSM
    {
        get => GameCameras.instance.cameraFadeFSM;
        set => GameCameras.instance.cameraFadeFSM = value;
    }

    public static PlayMakerFSM cameraShakeFSM
    {
        get => GameCameras.instance.cameraShakeFSM;
        set => GameCameras.instance.cameraShakeFSM = value;
    }

    public static PlayMakerFSM soulOrbFSM
    {
        get => GameCameras.instance.soulOrbFSM;
        set => GameCameras.instance.soulOrbFSM = value;
    }

    public static PlayMakerFSM soulVesselFSM
    {
        get => GameCameras.instance.soulVesselFSM;
        set => GameCameras.instance.soulVesselFSM = value;
    }

    public static PlayMakerFSM openStagFSM
    {
        get => GameCameras.instance.openStagFSM;
        set => GameCameras.instance.openStagFSM = value;
    }

    public static SceneColorManager sceneColorManager
    {
        get => GameCameras.instance.sceneColorManager;
        set => GameCameras.instance.sceneColorManager = value;
    }

    public static BrightnessEffect brightnessEffect
    {
        get => GameCameras.instance.brightnessEffect;
        set => GameCameras.instance.brightnessEffect = value;
    }

    public static SceneParticlesController sceneParticlesPrefab
    {
        get => GameCameras.instance.sceneParticlesPrefab;
        set => GameCameras.instance.sceneParticlesPrefab = value;
    }

    public static tk2dCamera tk2dCam
    {
        get => GameCameras.instance.tk2dCam;
        set => GameCameras.instance.tk2dCam = value;
    }

    public static GameObject hudCanvas
    {
        get => GameCameras.instance.hudCanvas;
        set => GameCameras.instance.hudCanvas = value;
    }

    public static Transform cameraParent
    {
        get => GameCameras.instance.cameraParent;
        set => GameCameras.instance.cameraParent = value;
    }

    public static GeoCounter geoCounter
    {
        get => GameCameras.instance.geoCounter;
        set => GameCameras.instance.geoCounter = value;
    }

    public static GameManager gm
    {
        get => ReflectionHelper.GetField<GameCameras, GameManager>(GameCameras.instance, "gm");
        set => ReflectionHelper.SetField(GameCameras.instance, "gm", value);
    }

    public static GameSettings gs
    {
        get => ReflectionHelper.GetField<GameCameras, GameSettings>(GameCameras.instance, "gs");
        set => ReflectionHelper.SetField(GameCameras.instance, "gs", value);
    }

    public static CanvasScaler canvasScaler
    {
        get => ReflectionHelper.GetField<GameCameras, CanvasScaler>(GameCameras.instance, "canvasScaler");
        set => ReflectionHelper.SetField(GameCameras.instance, "canvasScaler", value);
    }

    public static bool init
    {
        get => ReflectionHelper.GetField<GameCameras, bool>(GameCameras.instance, "init");
        set => ReflectionHelper.SetField(GameCameras.instance, "init", value);
    }

    public static SceneParticlesController sceneParticles
    {
        get => GameCameras.instance.sceneParticles;
        set => ReflectionHelper.SetProperty(GameCameras.instance, "sceneParticles", value);
    }

    public static GameCameras instance => GameCameras.instance;


    public static void Awake()
    {
        ReflectionHelper.CallMethod(GameCameras.instance, "Awake");
    }

    public static void Start()
    {
        ReflectionHelper.CallMethod(GameCameras.instance, "Start");
    }

    public static void SceneInit()
    {
        GameCameras.instance.SceneInit();
    }

    public static void OnDestroy()
    {
        ReflectionHelper.CallMethod(GameCameras.instance, "OnDestroy");
    }

    public static void SetupGameRefs()
    {
        ReflectionHelper.CallMethod(GameCameras.instance, "SetupGameRefs");
    }

    public static void StartScene()
    {
        ReflectionHelper.CallMethod(GameCameras.instance, "StartScene");
    }

    public static void MoveMenuToHUDCamera()
    {
        GameCameras.instance.MoveMenuToHUDCamera();
    }

    public static void DisableHUDCamIfAllowed()
    {
        GameCameras.instance.DisableHUDCamIfAllowed();
    }

    public static void StopCameraShake()
    {
        GameCameras.instance.StopCameraShake();
    }

    public static void ResumeCameraShake()
    {
        GameCameras.instance.ResumeCameraShake();
    }

    public static void DisableImageEffects()
    {
        GameCameras.instance.DisableImageEffects();
    }

    public static void EnableImageEffects(bool isGameplayLevel, bool isBloomForced)
    {
        GameCameras.instance.EnableImageEffects(isGameplayLevel, isBloomForced);
    }

    public static void SetOverscan(float value)
    {
        GameCameras.instance.SetOverscan(value);
    }

    public static void TestParentForPosition()
    {
        GameCameras.instance.TestParentForPosition();
    }
}