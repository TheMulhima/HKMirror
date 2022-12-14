namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of RemoteDisable allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RemoteDisableR : InstanceClassWrapper<RemoteDisable>
{
    public RemoteDisableR(RemoteDisable _orig) : base(_orig)
    {
    }


    public void RemoteDisableObject()
    {
        orig.RemoteDisableObject();
    }
}