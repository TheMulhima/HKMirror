namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of PlayMakerUnity2d allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayMakerUnity2dR : InstanceClassWrapper<PlayMakerUnity2d>
{
    public PlayMakerUnity2dR(PlayMakerUnity2d _orig) : base(_orig)
    {
    }

    public PlayMakerFSM fsmProxy
    {
        get => GetFieldStatic<PlayMakerFSM>();
        set => SetField(value);
    }

    public string PlayMakerUnity2dProxyName
    {
        get => PlayMakerUnity2d.PlayMakerUnity2dProxyName;
        set => PlayMakerUnity2d.PlayMakerUnity2dProxyName = value;
    }

    public FsmOwnerDefault goTarget
    {
        get => GetFieldStatic<FsmOwnerDefault>();
        set => SetField(value);
    }

    public string OnCollisionEnter2DEvent
    {
        get => PlayMakerUnity2d.OnCollisionEnter2DEvent;
        set => PlayMakerUnity2d.OnCollisionEnter2DEvent = value;
    }

    public string OnCollisionExit2DEvent
    {
        get => PlayMakerUnity2d.OnCollisionExit2DEvent;
        set => PlayMakerUnity2d.OnCollisionExit2DEvent = value;
    }

    public string OnCollisionStay2DEvent
    {
        get => PlayMakerUnity2d.OnCollisionStay2DEvent;
        set => PlayMakerUnity2d.OnCollisionStay2DEvent = value;
    }

    public string OnTriggerEnter2DEvent
    {
        get => PlayMakerUnity2d.OnTriggerEnter2DEvent;
        set => PlayMakerUnity2d.OnTriggerEnter2DEvent = value;
    }

    public string OnTriggerExit2DEvent
    {
        get => PlayMakerUnity2d.OnTriggerExit2DEvent;
        set => PlayMakerUnity2d.OnTriggerExit2DEvent = value;
    }

    public string OnTriggerStay2DEvent
    {
        get => PlayMakerUnity2d.OnTriggerStay2DEvent;
        set => PlayMakerUnity2d.OnTriggerStay2DEvent = value;
    }

    public Dictionary<Fsm, RaycastHit2D> lastRaycastHit2DInfoLUT
    {
        get => GetFieldStatic<Dictionary<Fsm, RaycastHit2D>>();
        set => SetField(value);
    }


    public void RecordLastRaycastHitInfo(Fsm fsm, RaycastHit2D info)
    {
        PlayMakerUnity2d.RecordLastRaycastHitInfo(fsm, info);
    }

    public RaycastHit2D GetLastRaycastHitInfo(Fsm fsm)
    {
        return PlayMakerUnity2d.GetLastRaycastHitInfo(fsm);
    }

    public void Awake()
    {
        CallMethod();
    }

    public void OnLevelWasLoaded(int level)
    {
        CallMethod(new object[] { level });
    }

    public bool isAvailable()
    {
        return PlayMakerUnity2d.isAvailable();
    }

    public void ForwardEventToGameObject(GameObject target, string eventName)
    {
        PlayMakerUnity2d.ForwardEventToGameObject(target, eventName);
    }

    public void ForwardCollisionToCurrentState(GameObject target, PlayMakerUnity2d.Collision2DType type,
        Collision2D CollisionInfo)
    {
        PlayMakerUnity2d.ForwardCollisionToCurrentState(target, type, CollisionInfo);
    }
}