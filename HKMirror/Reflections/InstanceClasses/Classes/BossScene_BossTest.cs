namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of BossScene_BossTest allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossScene_BossTestR : InstanceClassWrapper<BossScene.BossTest>
{
    public BossScene_BossTestR(BossScene.BossTest _orig) : base(_orig)
    {
    }

    public PersistentBoolData persistentBool
    {
        get => orig.persistentBool;
        set => orig.persistentBool = value;
    }

    public BossScene.BossTest.BoolTest[] boolTests
    {
        get => orig.boolTests;
        set => orig.boolTests = value;
    }

    public BossScene.BossTest.IntTest[] intTests
    {
        get => orig.intTests;
        set => orig.intTests = value;
    }

    public BossScene.BossTest.SharedDataTest[] sharedData
    {
        get => orig.sharedData;
        set => orig.sharedData = value;
    }

    public bool IsUnlocked()
    {
        return orig.IsUnlocked();
    }
}