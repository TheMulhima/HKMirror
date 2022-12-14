namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of StartAudioPlayerAfterHeroInPosition allowing
///     you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class StartAudioPlayerAfterHeroInPositionR : InstanceClassWrapper<StartAudioPlayerAfterHeroInPosition>
{
    public StartAudioPlayerAfterHeroInPositionR(StartAudioPlayerAfterHeroInPosition _orig) : base(_orig)
    {
    }


    public IEnumerator Start()
    {
        return CallMethod<IEnumerator>();
    }
}