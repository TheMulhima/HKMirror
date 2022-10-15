namespace HKMirror.StaticClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of BossSequenceController allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public static class BossSequenceControllerR
{
    public static BossSequenceController.BossSequenceData currentData
    {
        get => ReflectionHelper.GetField<BossSequenceController.BossSequenceData>(typeof(BossSequenceController),
            "currentData");
        set => ReflectionHelper.SetField(typeof(BossSequenceController), "currentData", value);
    }

    public static BossSequence currentSequence
    {
        get => ReflectionHelper.GetField<BossSequence>(typeof(BossSequenceController), "currentSequence");
        set => ReflectionHelper.SetField(typeof(BossSequenceController), "currentSequence", value);
    }

    public static int bossIndex
    {
        get => ReflectionHelper.GetField<int>(typeof(BossSequenceController), "bossIndex");
        set => ReflectionHelper.SetField(typeof(BossSequenceController), "bossIndex", value);
    }

    public static bool BoundNail => BossSequenceController.BoundNail;

    public static bool BoundShell => BossSequenceController.BoundShell;

    public static bool BoundCharms => BossSequenceController.BoundCharms;

    public static bool BoundSoul => BossSequenceController.BoundSoul;


    public static bool KnightDamaged
    {
        get => BossSequenceController.KnightDamaged;
        set => BossSequenceController.KnightDamaged = value;
    }

    public static BossSequenceDoor.Completion PreviousCompletion => BossSequenceController.PreviousCompletion;

    public static float Timer
    {
        get => BossSequenceController.Timer;
        set => BossSequenceController.Timer = value;
    }

    public static bool WasCompleted
    {
        get => BossSequenceController.WasCompleted;
        set => ReflectionHelper.SetProperty(typeof(BossSequenceController), "WasCompleted", value);
    }

    public static bool IsInSequence => BossSequenceController.IsInSequence;

    public static bool IsLastBossScene => BossSequenceController.IsLastBossScene;
    public static int BossIndex => BossSequenceController.BossIndex;

    public static int BossCount => BossSequenceController.BossCount;

    public static bool ShouldUnlockGGMode => BossSequenceController.ShouldUnlockGGMode;

    public static int BoundMaxHealth => BossSequenceController.BoundMaxHealth;

    public static int BoundNailDamage => BossSequenceController.BoundNailDamage;

    public static bool ForceAssetUnload => BossSequenceController.ForceAssetUnload;

    public static void Reset()
    {
        BossSequenceController.Reset();
    }

    public static void SetupNewSequence(BossSequence sequence, BossSequenceController.ChallengeBindings bindings,
        string playerData)
    {
        BossSequenceController.SetupNewSequence(sequence, bindings, playerData);
    }

    public static void CheckLoadSequence(MonoBehaviour caller)
    {
        BossSequenceController.CheckLoadSequence(caller);
    }

    public static void LoadCurrentSequence(MonoBehaviour caller)
    {
        ReflectionHelper.CallMethod(typeof(BossSequenceController), "LoadCurrentSequence", caller);
    }

    public static void ApplyBindings()
    {
        BossSequenceController.ApplyBindings();
    }

    public static void RestoreBindings()
    {
        BossSequenceController.RestoreBindings();
    }

    public static IEnumerator ResetBindingDisplay()
    {
        return ReflectionHelper.CallMethod<IEnumerator>(typeof(BossSequenceController), "ResetBindingsDisplay");
    }

    public static void SetupBossScene()
    {
        ReflectionHelper.CallMethod(typeof(BossSequenceController), "SetupBossScene");
    }

    public static void IncrementBossIndex()
    {
        ReflectionHelper.CallMethod(typeof(BossSequenceController), "IncrementBossIndex");
    }

    public static void FinishBossScene(BossSceneController self, BossSceneController.SetupEventDelegate setupEvent)
    {
        ReflectionHelper.CallMethod(typeof(BossSequenceController), "FinishBossScene", self, setupEvent);
    }

    public static void FinishLastBossScene(BossSceneController self)
    {
        ReflectionHelper.CallMethod(typeof(BossSequenceController), "FinishLastBossScene", self);
    }

    public static bool CheckIfSequence(BossSequence sequence)
    {
        return BossSequenceController.CheckIfSequence(sequence);
    }

    public static void SetMinValue(ref int variable, params int[] values)
    {
        variable = Mathf.Min(variable, Mathf.Min(values));
    }

    public static void SetCharmsEquipped(bool value)
    {
        ReflectionHelper.CallMethod(typeof(BossSequenceController), "SetCharmsEquipped", value);
    }
}