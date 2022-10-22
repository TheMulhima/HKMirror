namespace HKMirror.Reflection.InstanceClasses
{
/// <summary>
///     A class that contains all (public and private) fields and methods of MusicCue_MusicChannelInfo allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MusicCue_MusicChannelInfoR:InstanceClassWrapper<MusicCue.MusicChannelInfo>
{
public MusicCue_MusicChannelInfoR(MusicCue.MusicChannelInfo _orig) : base(_orig) {}
public UnityEngine.AudioClip clip
{
get => GetField<UnityEngine.AudioClip>();
set => SetField(value);
}

public MusicChannelSync sync
{
get => GetField<MusicChannelSync>();
set => SetField(value);
}

public UnityEngine.AudioClip Clip
{
get => orig.Clip;
}

public bool IsEnabled
{
get => orig.IsEnabled;
}

public bool IsSyncRequired
{
get => orig.IsSyncRequired;
}

}
}
