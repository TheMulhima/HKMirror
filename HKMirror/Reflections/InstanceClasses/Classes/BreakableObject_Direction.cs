namespace HKMirror.Reflection.InstanceClasses
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BreakableObject_Direction allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BreakableObject_DirectionR:InstanceClassWrapper<BreakableObject.Direction>
{
public BreakableObject_DirectionR(BreakableObject.Direction _orig) : base(_orig) {}
public UnityEngine.GameObject effectPrefab
{
get => orig.effectPrefab;
set => orig.effectPrefab = value;
}

public UnityEngine.Vector3 scale
{
get => orig.scale;
set => orig.scale = value;
}

public UnityEngine.Vector3 rotation
{
get => orig.rotation;
set => orig.rotation = value;
}

public float minFlingSpeed
{
get => orig.minFlingSpeed;
set => orig.minFlingSpeed = value;
}

public float maxFlingSpeed
{
get => orig.maxFlingSpeed;
set => orig.maxFlingSpeed = value;
}

public float minFlingAngle
{
get => orig.minFlingAngle;
set => orig.minFlingAngle = value;
}

public float maxFlingAngle
{
get => orig.maxFlingAngle;
set => orig.maxFlingAngle = value;
}

}
}
