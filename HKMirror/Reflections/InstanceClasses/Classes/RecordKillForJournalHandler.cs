using Modding.Delegates;

namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of RecordKillForJournalHandler allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RecordKillForJournalHandlerR : InstanceClassWrapper<RecordKillForJournalHandler>
{
    public RecordKillForJournalHandlerR(RecordKillForJournalHandler _orig) : base(_orig)
    {
    }

    public bool HasSingleTarget => GetProperty<bool>();

    public MethodInfo Method => orig.Method;

    public object Target => orig.Target;

    public void Invoke(EnemyDeathEffects enemyDeathEffects, string playerDataName, string killedBoolPlayerDataLookupKey,
        string killCountIntPlayerDataLookupKey, string newDataBoolPlayerDataLookupKey)
    {
        orig.Invoke(enemyDeathEffects, playerDataName, killedBoolPlayerDataLookupKey, killCountIntPlayerDataLookupKey,
            newDataBoolPlayerDataLookupKey);
    }

    public void EndInvoke(IAsyncResult result)
    {
        orig.EndInvoke(result);
    }
}