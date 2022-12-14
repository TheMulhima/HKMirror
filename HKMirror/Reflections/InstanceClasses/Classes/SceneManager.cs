using UnityEngine.Audio;

namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of SceneManager allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SceneManagerR : InstanceClassWrapper<SceneManager>
{
    public SceneManagerR(SceneManager _orig) : base(_orig)
    {
    }

    public SceneType sceneType
    {
        get => orig.sceneType;
        set => orig.sceneType = value;
    }

    public MapZone mapZone
    {
        get => orig.mapZone;
        set => orig.mapZone = value;
    }

    public bool isWindy
    {
        get => orig.isWindy;
        set => orig.isWindy = value;
    }

    public bool isTremorZone
    {
        get => orig.isTremorZone;
        set => orig.isTremorZone = value;
    }

    public int environmentType
    {
        get => orig.environmentType;
        set => orig.environmentType = value;
    }

    public int darknessLevel
    {
        get => orig.darknessLevel;
        set => orig.darknessLevel = value;
    }

    public bool noLantern
    {
        get => orig.noLantern;
        set => orig.noLantern = value;
    }

    public float saturation
    {
        get => orig.saturation;
        set => orig.saturation = value;
    }

    public bool ignorePlatformSaturationModifiers
    {
        get => orig.ignorePlatformSaturationModifiers;
        set => orig.ignorePlatformSaturationModifiers = value;
    }

    public AnimationCurve redChannel
    {
        get => orig.redChannel;
        set => orig.redChannel = value;
    }

    public AnimationCurve greenChannel
    {
        get => orig.greenChannel;
        set => orig.greenChannel = value;
    }

    public AnimationCurve blueChannel
    {
        get => orig.blueChannel;
        set => orig.blueChannel = value;
    }

    public Color defaultColor
    {
        get => orig.defaultColor;
        set => orig.defaultColor = value;
    }

    public float defaultIntensity
    {
        get => orig.defaultIntensity;
        set => orig.defaultIntensity = value;
    }

    public Color heroLightColor
    {
        get => orig.heroLightColor;
        set => orig.heroLightColor = value;
    }

    public bool noParticles
    {
        get => orig.noParticles;
        set => orig.noParticles = value;
    }

    public MapZone overrideParticlesWith
    {
        get => orig.overrideParticlesWith;
        set => orig.overrideParticlesWith = value;
    }

    public AtmosCue atmosCue
    {
        get => GetField<AtmosCue>();
        set => SetField(value);
    }

    public MusicCue musicCue
    {
        get => GetField<MusicCue>();
        set => SetField(value);
    }

    public MusicCue infectedMusicCue
    {
        get => GetField<MusicCue>();
        set => SetField(value);
    }

    public AudioMixerSnapshot musicSnapshot
    {
        get => GetField<AudioMixerSnapshot>();
        set => SetField(value);
    }

    public float musicDelayTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float musicTransitionTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public AudioMixerSnapshot atmosSnapshot
    {
        get => orig.atmosSnapshot;
        set => orig.atmosSnapshot = value;
    }

    public AudioMixerSnapshot enviroSnapshot
    {
        get => orig.enviroSnapshot;
        set => orig.enviroSnapshot = value;
    }

    public AudioMixerSnapshot actorSnapshot
    {
        get => orig.actorSnapshot;
        set => orig.actorSnapshot = value;
    }

    public AudioMixerSnapshot shadeSnapshot
    {
        get => orig.shadeSnapshot;
        set => orig.shadeSnapshot = value;
    }

    public float transitionTime
    {
        get => orig.transitionTime;
        set => orig.transitionTime = value;
    }

    public GameObject borderPrefab
    {
        get => orig.borderPrefab;
        set => orig.borderPrefab = value;
    }

    public bool manualMapTrigger
    {
        get => orig.manualMapTrigger;
        set => orig.manualMapTrigger = value;
    }

    public GameObject hollowShadeObject
    {
        get => orig.hollowShadeObject;
        set => orig.hollowShadeObject = value;
    }

    public GameObject dreamgateObject
    {
        get => orig.dreamgateObject;
        set => orig.dreamgateObject = value;
    }

    public GameManager gm
    {
        get => GetField<GameManager>();
        set => SetField(value);
    }

    public GameCameras gc
    {
        get => GetField<GameCameras>();
        set => SetField(value);
    }

    public HeroController heroCtrl
    {
        get => GetField<HeroController>();
        set => SetField(value);
    }

    public PlayerData pd
    {
        get => GetField<PlayerData>();
        set => SetField(value);
    }

    public float enviroTimer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool enviroSent
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool heroInfoSent
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool setSaturation
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool isGameplayScene
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public float AmbientIntesityMix
    {
        get => SceneManager.AmbientIntesityMix;
        set => SceneManager.AmbientIntesityMix = value;
    }

    public float SwitchConstant
    {
        get => GetFieldStatic<float>();
        set => SetField(value);
    }

    public float SwitchConstantGG
    {
        get => GetFieldStatic<float>();
        set => SetField(value);
    }

    public float RegularConstant
    {
        get => GetFieldStatic<float>();
        set => SetField(value);
    }

    public bool gameplayScene
    {
        get => GetField<bool>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void SetLighting(Color ambientLightColor, float ambientLightIntensity)
    {
        SceneManager.SetLighting(ambientLightColor, ambientLightIntensity);
    }

    public void Update()
    {
        CallMethod();
    }

    public int GetDarknessLevel()
    {
        return orig.GetDarknessLevel();
    }

    public void SetWindy(bool setting)
    {
        orig.SetWindy(setting);
    }

    public float AdjustSaturation(float originalSaturation)
    {
        return orig.AdjustSaturation(originalSaturation);
    }

    public float AdjustSaturationForPlatform(float originalSaturation, MapZone? mapZone = null)
    {
        return SceneManager.AdjustSaturationForPlatform(originalSaturation, mapZone);
    }

    public void PrintDebugInfo()
    {
        CallMethod();
    }

    public void DrawBlackBorders()
    {
        CallMethod();
    }

    public void AddSceneMapped()
    {
        CallMethod();
    }

    public void UpdateSceneSettings(SceneManagerSettings sms)
    {
        orig.UpdateSceneSettings(sms);
    }

    public void orig_Update()
    {
        CallMethod();
    }

    public void orig_Start()
    {
        CallMethod();
    }
}