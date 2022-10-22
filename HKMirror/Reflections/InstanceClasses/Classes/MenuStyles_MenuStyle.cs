using UnityEngine.Audio;

namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of MenuStyles_MenuStyle allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuStyles_MenuStyleR : InstanceClassWrapper<MenuStyles.MenuStyle>
{
    public MenuStyles_MenuStyleR(MenuStyles.MenuStyle _orig) : base(_orig)
    {
    }

    public bool enabled
    {
        get => orig.enabled;
        set => orig.enabled = value;
    }

    public string displayName
    {
        get => orig.displayName;
        set => orig.displayName = value;
    }

    public GameObject styleObject
    {
        get => orig.styleObject;
        set => orig.styleObject = value;
    }

    public AudioMixerSnapshot musicSnapshot
    {
        get => orig.musicSnapshot;
        set => orig.musicSnapshot = value;
    }

    public int titleIndex
    {
        get => orig.titleIndex;
        set => orig.titleIndex = value;
    }

    public string unlockKey
    {
        get => orig.unlockKey;
        set => orig.unlockKey = value;
    }

    public string[] achievementKeys
    {
        get => orig.achievementKeys;
        set => orig.achievementKeys = value;
    }

    public float[] initialAudioVolumes
    {
        get => orig.initialAudioVolumes;
        set => orig.initialAudioVolumes = value;
    }

    public bool IsAvailable => orig.IsAvailable;

    public void SetInitialAudioVolumes(AudioSource[] sources)
    {
        orig.SetInitialAudioVolumes(sources);
    }
}