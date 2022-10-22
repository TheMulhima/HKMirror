namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of GamepadVibrationMixer_GamepadVibrationEmission
///     allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class
    GamepadVibrationMixer_GamepadVibrationEmissionR : InstanceClassWrapper<
        GamepadVibrationMixer.GamepadVibrationEmission>
{
    public GamepadVibrationMixer_GamepadVibrationEmissionR(GamepadVibrationMixer.GamepadVibrationEmission _orig) :
        base(_orig)
    {
    }

    public GamepadVibrationMixer mixer
    {
        get => GetField<GamepadVibrationMixer>();
        set => SetField(value);
    }

    public GamepadVibration gamepadVibration
    {
        get => GetField<GamepadVibration>();
        set => SetField(value);
    }

    public float duration
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool isLooping
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool isPlaying
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public string tag
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public VibrationTarget target
    {
        get => GetField<VibrationTarget>();
        set => SetField(value);
    }

    public float timer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool IsLooping
    {
        get => orig.IsLooping;
        set => orig.IsLooping = value;
    }

    public bool IsPlaying => orig.IsPlaying;

    public string Tag
    {
        get => orig.Tag;
        set => orig.Tag = value;
    }

    public VibrationTarget Target
    {
        get => orig.Target;
        set => orig.Target = value;
    }

    public void Stop()
    {
        orig.Stop();
    }

    public void Advance(float deltaTime)
    {
        orig.Advance(deltaTime);
    }
}