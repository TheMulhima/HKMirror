namespace HKMirror.Reflection.InstanceClasses
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ShineAnimSequence_ShineObject allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ShineAnimSequence_ShineObjectR:InstanceClassWrapper<ShineAnimSequence.ShineObject>
{
public ShineAnimSequence_ShineObjectR(ShineAnimSequence.ShineObject _orig) : base(_orig) {}
public UnityEngine.SpriteRenderer renderer
{
get => orig.renderer;
set => orig.renderer = value;
}

public UnityEngine.Sprite[] shineSprites
{
get => orig.shineSprites;
set => orig.shineSprites = value;
}

public float fps
{
get => orig.fps;
set => orig.fps = value;
}

public System.Collections.IEnumerator ShineAnim () =>
orig.ShineAnim();

}
}
