namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of MatchMasterTimeSample allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MatchMasterTimeSampleR : InstanceClassWrapper<MatchMasterTimeSample>
{
    public MatchMasterTimeSampleR(MatchMasterTimeSample _orig) : base(_orig)
    {
    }

    public AudioSource master
    {
        get => orig.master;
        set => orig.master = value;
    }

    public AudioSource slave1
    {
        get => orig.slave1;
        set => orig.slave1 = value;
    }

    public AudioSource slave2
    {
        get => orig.slave2;
        set => orig.slave2 = value;
    }

    public AudioSource slave3
    {
        get => orig.slave3;
        set => orig.slave3 = value;
    }

    public AudioSource slave4
    {
        get => orig.slave4;
        set => orig.slave4 = value;
    }


    public void Update()
    {
        CallMethod();
    }
}