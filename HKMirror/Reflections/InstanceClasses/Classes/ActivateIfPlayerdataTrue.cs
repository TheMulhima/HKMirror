namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of ActivateIfPlayerdataTrue allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ActivateIfPlayerdataTrueR : InstanceClassWrapper<ActivateIfPlayerdataTrue>
{
    public ActivateIfPlayerdataTrueR(ActivateIfPlayerdataTrue _orig) : base(_orig)
    {
    }

    public string boolName
    {
        get => orig.boolName;
        set => orig.boolName = value;
    }

    public GameManager gm
    {
        get => GetField<GameManager>();
        set => SetField(value);
    }

    public PlayerData pd
    {
        get => GetField<PlayerData>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }
}