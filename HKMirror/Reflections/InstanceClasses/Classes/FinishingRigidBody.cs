namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of FinishingRigidBody allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FinishingRigidBodyR : InstanceClassWrapper<FinishingRigidBody>
{
    public FinishingRigidBodyR(FinishingRigidBody _orig) : base(_orig)
    {
    }

    public float waitDuration
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float shrinkDuration
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool persistOffScreen
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Renderer rend
    {
        get => GetField<Renderer>();
        set => SetField(value);
    }

    public Rigidbody2D body
    {
        get => GetField<Rigidbody2D>();
        set => SetField(value);
    }

    public Vector3 shrinkStartScale
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public float timer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public int framesEnabled
    {
        get => GetField<int>();
        set => SetField(value);
    }


    public void Reset()
    {
        CallMethod();
    }

    public void Awake()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }

    public void Conclude()
    {
        CallMethod();
    }
}