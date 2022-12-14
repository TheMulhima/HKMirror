namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of RandomAudioClipTable allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RandomAudioClipTableR : InstanceClassWrapper<RandomAudioClipTable>
{
    public RandomAudioClipTableR(RandomAudioClipTable _orig) : base(_orig)
    {
    }


    public float pitchMin
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float pitchMax
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public string name
    {
        get => orig.name;
        set => orig.name = value;
    }

    public HideFlags hideFlags
    {
        get => orig.hideFlags;
        set => orig.hideFlags = value;
    }

    public void Reset()
    {
        CallMethod();
    }

    public AudioClip SelectClip()
    {
        return orig.SelectClip();
    }

    public float SelectPitch()
    {
        return orig.SelectPitch();
    }

    public void PlayOneShotUnsafe(AudioSource audioSource)
    {
        orig.PlayOneShotUnsafe(audioSource);
    }
}