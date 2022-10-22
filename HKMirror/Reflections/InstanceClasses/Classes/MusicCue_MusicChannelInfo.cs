namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of MusicCue_MusicChannelInfo allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MusicCue_MusicChannelInfoR : InstanceClassWrapper<MusicCue.MusicChannelInfo>
{
    public MusicCue_MusicChannelInfoR(MusicCue.MusicChannelInfo _orig) : base(_orig)
    {
    }

    public AudioClip clip
    {
        get => GetField<AudioClip>();
        set => SetField(value);
    }

    public MusicChannelSync sync
    {
        get => GetField<MusicChannelSync>();
        set => SetField(value);
    }

    public AudioClip Clip => orig.Clip;

    public bool IsEnabled => orig.IsEnabled;

    public bool IsSyncRequired => orig.IsSyncRequired;
}