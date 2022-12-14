namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of DeactivateGameObjectPerBuildType allowing you
///     to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DeactivateGameObjectPerBuildTypeR : InstanceClassWrapper<DeactivateGameObjectPerBuildType>
{
    public DeactivateGameObjectPerBuildTypeR(DeactivateGameObjectPerBuildType _orig) : base(_orig)
    {
    }

    public BuildTypes[] buildTypes
    {
        get => GetField<BuildTypes[]>();
        set => SetField(value);
    }


    public void OnEnable()
    {
        CallMethod();
    }
}