namespace HKMirror.Reflection.InstanceClasses
{
/// <summary>
///     A class that contains all (public and private) fields and methods of Probability_ProbabilityGameObject allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class Probability_ProbabilityGameObjectR:InstanceClassWrapper<Probability.ProbabilityGameObject>
{
public Probability_ProbabilityGameObjectR(Probability.ProbabilityGameObject _orig) : base(_orig) {}
public UnityEngine.GameObject prefab
{
get => orig.prefab;
set => orig.prefab = value;
}

public float probability
{
get => orig.probability;
set => orig.probability = value;
}

}
}
