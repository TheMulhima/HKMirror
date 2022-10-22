namespace HKMirror.Reflection.InstanceClasses
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BreakableWithExternalDebris_WeightedExternalDebrisItem allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BreakableWithExternalDebris_WeightedExternalDebrisItemR:InstanceClassWrapper<BreakableWithExternalDebris.WeightedExternalDebrisItem>
{
public BreakableWithExternalDebris_WeightedExternalDebrisItemR(BreakableWithExternalDebris.WeightedExternalDebrisItem _orig) : base(_orig) {}
public float Weight
{
get => orig.Weight;
}

}
}
