namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of BossSequenceController_BossSequenceData
///     allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossSequenceController_BossSequenceDataR : InstanceClassWrapper<BossSequenceController.BossSequenceData>
{
    public BossSequenceController_BossSequenceDataR(BossSequenceController.BossSequenceData _orig) : base(_orig)
    {
    }

    public float timer
    {
        get => orig.timer;
        set => orig.timer = value;
    }

    public bool knightDamaged
    {
        get => orig.knightDamaged;
        set => orig.knightDamaged = value;
    }

    public string playerData
    {
        get => orig.playerData;
        set => orig.playerData = value;
    }

    public int[] previousEquippedCharms
    {
        get => orig.previousEquippedCharms;
        set => orig.previousEquippedCharms = value;
    }

    public bool wasOvercharmed
    {
        get => orig.wasOvercharmed;
        set => orig.wasOvercharmed = value;
    }

    public string bossSequenceName
    {
        get => orig.bossSequenceName;
        set => orig.bossSequenceName = value;
    }
}