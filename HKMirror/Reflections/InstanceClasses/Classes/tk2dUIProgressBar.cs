namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUIProgressBar allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUIProgressBarR : InstanceClassWrapper<tk2dUIProgressBar>
{
    public tk2dUIProgressBarR(tk2dUIProgressBar _orig) : base(_orig)
    {
    }

    public Action OnProgressComplete
    {
        get => GetField<Action>();
        set => SetField(value);
    }

    public Transform scalableBar
    {
        get => orig.scalableBar;
        set => orig.scalableBar = value;
    }

    public tk2dClippedSprite clippedSpriteBar
    {
        get => orig.clippedSpriteBar;
        set => orig.clippedSpriteBar = value;
    }

    public tk2dSlicedSprite slicedSpriteBar
    {
        get => orig.slicedSpriteBar;
        set => orig.slicedSpriteBar = value;
    }

    public bool initializedSlicedSpriteDimensions
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Vector2 emptySlicedSpriteDimensions
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public Vector2 fullSlicedSpriteDimensions
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public Vector2 currentDimensions
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public float percent
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool isProgressComplete
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public GameObject sendMessageTarget
    {
        get => orig.sendMessageTarget;
        set => orig.sendMessageTarget = value;
    }

    public string SendMessageOnProgressCompleteMethodName
    {
        get => orig.SendMessageOnProgressCompleteMethodName;
        set => orig.SendMessageOnProgressCompleteMethodName = value;
    }

    public float Value
    {
        get => orig.Value;
        set => orig.Value = value;
    }


    public void Start()
    {
        CallMethod();
    }

    public void InitializeSlicedSpriteDimensions()
    {
        CallMethod();
    }
}