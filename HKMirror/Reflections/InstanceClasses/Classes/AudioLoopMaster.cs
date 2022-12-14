namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of AudioLoopMaster allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AudioLoopMasterR : InstanceClassWrapper<AudioLoopMaster>
{
    public AudioLoopMasterR(AudioLoopMaster _orig) : base(_orig)
    {
    }

    public AudioSource audioSource
    {
        get => GetField<AudioSource>();
        set => SetField(value);
    }

    public AudioSource action
    {
        get => orig.action;
        set => orig.action = value;
    }

    public AudioSource sub
    {
        get => orig.sub;
        set => orig.sub = value;
    }

    public AudioSource mainAlt
    {
        get => orig.mainAlt;
        set => orig.mainAlt = value;
    }

    public AudioSource tension
    {
        get => orig.tension;
        set => orig.tension = value;
    }

    public AudioSource extra
    {
        get => orig.extra;
        set => orig.extra = value;
    }

    public bool reset
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool syncAction
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool syncSub
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool syncMainAlt
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool syncTension
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool syncExtra
    {
        get => GetField<bool>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }

    public void SetSyncAction(bool set)
    {
        orig.SetSyncAction(set);
    }

    public void SetSyncSub(bool set)
    {
        orig.SetSyncSub(set);
    }

    public void SetSyncMainAlt(bool set)
    {
        orig.SetSyncMainAlt(set);
    }

    public void SetSyncTension(bool set)
    {
        orig.SetSyncTension(set);
    }

    public void SetSyncExtra(bool set)
    {
        orig.SetSyncExtra(set);
    }
}