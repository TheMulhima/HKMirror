namespace HKMirror.Reflection.InstanceClasses
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dSpriteDefinition_AttachPoint allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dSpriteDefinition_AttachPointR:InstanceClassWrapper<tk2dSpriteDefinition.AttachPoint>
{
public tk2dSpriteDefinition_AttachPointR(tk2dSpriteDefinition.AttachPoint _orig) : base(_orig) {}
public string name
{
get => orig.name;
set => orig.name = value;
}

public UnityEngine.Vector3 position
{
get => orig.position;
set => orig.position = value;
}

public float angle
{
get => orig.angle;
set => orig.angle = value;
}

public void CopyFrom (tk2dSpriteDefinition.AttachPoint src) =>
orig.CopyFrom(src);

public bool CompareTo (tk2dSpriteDefinition.AttachPoint src) =>
orig.CompareTo(src);

}
}
