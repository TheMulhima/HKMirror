namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of ParticleSystemAutoRecycle allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ParticleSystemAutoRecycleR : InstanceClassWrapper<ParticleSystemAutoRecycle>
{
    public ParticleSystemAutoRecycleR(ParticleSystemAutoRecycle _orig) : base(_orig)
    {
    }

    public ParticleSystem ps
    {
        get => GetField<ParticleSystem>();
        set => SetField(value);
    }

    public bool activated
    {
        get => GetField<bool>();
        set => SetField(value);
    }


    public void Start()
    {
        orig.Start();
    }

    public void Update()
    {
        orig.Update();
    }
}