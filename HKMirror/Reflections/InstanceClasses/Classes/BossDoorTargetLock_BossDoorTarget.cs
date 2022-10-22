namespace HKMirror.Reflection.InstanceClasses
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BossDoorTargetLock_BossDoorTarget allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossDoorTargetLock_BossDoorTargetR:InstanceClassWrapper<BossDoorTargetLock.BossDoorTarget>
{
public BossDoorTargetLock_BossDoorTargetR(BossDoorTargetLock.BossDoorTarget _orig) : base(_orig) {}
public BossSequenceDoor door
{
get => orig.door;
set => orig.door = value;
}

public UnityEngine.GameObject indicator
{
get => orig.indicator;
set => orig.indicator = value;
}

public bool Evaluate () =>
orig.Evaluate();

}
}
