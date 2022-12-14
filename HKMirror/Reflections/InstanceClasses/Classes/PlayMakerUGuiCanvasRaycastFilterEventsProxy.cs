namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of PlayMakerUGuiCanvasRaycastFilterEventsProxy
///     allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class
    PlayMakerUGuiCanvasRaycastFilterEventsProxyR : InstanceClassWrapper<PlayMakerUGuiCanvasRaycastFilterEventsProxy>
{
    public PlayMakerUGuiCanvasRaycastFilterEventsProxyR(PlayMakerUGuiCanvasRaycastFilterEventsProxy _orig) : base(_orig)
    {
    }

    public bool RayCastingEnabled
    {
        get => orig.RayCastingEnabled;
        set => orig.RayCastingEnabled = value;
    }


    public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
    {
        return orig.IsRaycastLocationValid(sp, eventCamera);
    }
}