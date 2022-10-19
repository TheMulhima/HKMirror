namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of RandomFrame allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RandomFrameR : InstanceClassWrapper<RandomFrame>
{
    public RandomFrameR(RandomFrame _orig) : base(_orig)
    {
    }


    public void Start()
    {
        CallMethod();
    }
}