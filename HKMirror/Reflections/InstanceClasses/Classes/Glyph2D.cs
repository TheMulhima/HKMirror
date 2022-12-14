using TMPro;

namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of Glyph2D allowing you to easily get/set fields
///     and call methods without dealing with reflection.
/// </summary>
public class Glyph2DR : InstanceClassWrapper<Glyph2D>
{
    public Glyph2DR(Glyph2D _orig) : base(_orig)
    {
    }

    public Vector3 bottomLeft
    {
        get => orig.bottomLeft;
        set => orig.bottomLeft = value;
    }

    public Vector3 topLeft
    {
        get => orig.topLeft;
        set => orig.topLeft = value;
    }

    public Vector3 bottomRight
    {
        get => orig.bottomRight;
        set => orig.bottomRight = value;
    }

    public Vector3 topRight
    {
        get => orig.topRight;
        set => orig.topRight = value;
    }

    public Vector2 uv0
    {
        get => orig.uv0;
        set => orig.uv0 = value;
    }

    public Vector2 uv1
    {
        get => orig.uv1;
        set => orig.uv1 = value;
    }

    public Vector2 uv2
    {
        get => orig.uv2;
        set => orig.uv2 = value;
    }

    public Vector2 uv3
    {
        get => orig.uv3;
        set => orig.uv3 = value;
    }
}