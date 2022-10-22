namespace HKMirror.Reflection.InstanceClasses
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BossDoorCompletionStates_CompletionState allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossDoorCompletionStates_CompletionStateR:InstanceClassWrapper<BossDoorCompletionStates.CompletionState>
{
public BossDoorCompletionStates_CompletionStateR(BossDoorCompletionStates.CompletionState _orig) : base(_orig) {}
public UnityEngine.GameObject stateObject
{
get => orig.stateObject;
set => orig.stateObject = value;
}

public string sendEvent
{
get => orig.sendEvent;
set => orig.sendEvent = value;
}

}
}
