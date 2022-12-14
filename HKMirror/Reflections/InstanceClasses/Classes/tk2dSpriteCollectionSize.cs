namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dSpriteCollectionSize allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dSpriteCollectionSizeR : InstanceClassWrapper<tk2dSpriteCollectionSize>
{
    public tk2dSpriteCollectionSizeR(tk2dSpriteCollectionSize _orig) : base(_orig)
    {
    }

    public float orthoSize
    {
        get => orig.orthoSize;
        set => orig.orthoSize = value;
    }

    public float pixelsPerMeter
    {
        get => orig.pixelsPerMeter;
        set => orig.pixelsPerMeter = value;
    }

    public float width
    {
        get => orig.width;
        set => orig.width = value;
    }

    public float height
    {
        get => orig.height;
        set => orig.height = value;
    }

    public float OrthoSize => orig.OrthoSize;

    public float TargetHeight => orig.TargetHeight;

    public tk2dSpriteCollectionSize Explicit(float orthoSize, float targetHeight)
    {
        return tk2dSpriteCollectionSize.Explicit(orthoSize, targetHeight);
    }

    public tk2dSpriteCollectionSize PixelsPerMeter(float pixelsPerMeter)
    {
        return tk2dSpriteCollectionSize.PixelsPerMeter(pixelsPerMeter);
    }

    public tk2dSpriteCollectionSize ForResolution(float orthoSize, float width, float height)
    {
        return tk2dSpriteCollectionSize.ForResolution(orthoSize, width, height);
    }

    public tk2dSpriteCollectionSize ForTk2dCamera()
    {
        return tk2dSpriteCollectionSize.ForTk2dCamera();
    }

    public tk2dSpriteCollectionSize ForTk2dCamera(tk2dCamera camera)
    {
        return tk2dSpriteCollectionSize.ForTk2dCamera(camera);
    }

    public tk2dSpriteCollectionSize Default()
    {
        return tk2dSpriteCollectionSize.Default();
    }

    public void CopyFromLegacy(bool useTk2dCamera, float orthoSize, float targetHeight)
    {
        orig.CopyFromLegacy(useTk2dCamera, orthoSize, targetHeight);
    }

    public void CopyFrom(tk2dSpriteCollectionSize source)
    {
        orig.CopyFrom(source);
    }
}