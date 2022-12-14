using TMPro;

namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of GameCompletionScreen allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GameCompletionScreenR : InstanceClassWrapper<GameCompletionScreen>
{
    public GameCompletionScreenR(GameCompletionScreen _orig) : base(_orig)
    {
    }

    public TextMeshPro percentageNumber
    {
        get => orig.percentageNumber;
        set => orig.percentageNumber = value;
    }

    public TextMeshPro playTimeNumber
    {
        get => orig.playTimeNumber;
        set => orig.playTimeNumber = value;
    }

    public GameManager gm
    {
        get => GetField<GameManager>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }
}