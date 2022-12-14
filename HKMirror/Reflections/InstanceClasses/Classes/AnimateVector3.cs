namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of AnimateVector3 allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AnimateVector3R : InstanceClassWrapper<AnimateVector3>
{
    public AnimateVector3R(AnimateVector3 _orig) : base(_orig)
    {
    }

    public FsmVector3 vectorVariable
    {
        get => orig.vectorVariable;
        set => orig.vectorVariable = value;
    }

    public FsmAnimationCurve curveX
    {
        get => orig.curveX;
        set => orig.curveX = value;
    }

    public FsmAnimationCurve curveY
    {
        get => orig.curveY;
        set => orig.curveY = value;
    }

    public FsmAnimationCurve curveZ
    {
        get => orig.curveZ;
        set => orig.curveZ = value;
    }

    public bool finishInNextStep
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public FsmFloat time
    {
        get => orig.time;
        set => orig.time = value;
    }

    public FsmFloat speed
    {
        get => orig.speed;
        set => orig.speed = value;
    }

    public FsmFloat delay
    {
        get => orig.delay;
        set => orig.delay = value;
    }

    public FsmBool ignoreCurveOffset
    {
        get => orig.ignoreCurveOffset;
        set => orig.ignoreCurveOffset = value;
    }

    public FsmEvent finishEvent
    {
        get => orig.finishEvent;
        set => orig.finishEvent = value;
    }

    public bool realTime
    {
        get => orig.realTime;
        set => orig.realTime = value;
    }

    public AnimationCurve[] curves
    {
        get => GetField<AnimationCurve[]>();
        set => SetField(value);
    }

    public AnimateFsmAction.Calculation[] calculations
    {
        get => GetField<AnimateFsmAction.Calculation[]>();
        set => SetField(value);
    }

    public float[] resultFloats
    {
        get => GetField<float[]>();
        set => SetField(value);
    }

    public float[] fromFloats
    {
        get => GetField<float[]>();
        set => SetField(value);
    }

    public float[] toFloats
    {
        get => GetField<float[]>();
        set => SetField(value);
    }

    public bool finishAction
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool isRunning
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool looping
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public string Name
    {
        get => orig.Name;
        set => orig.Name = value;
    }

    public string DisplayName
    {
        get => orig.DisplayName;
        set => orig.DisplayName = value;
    }

    public Fsm Fsm
    {
        get => orig.Fsm;
        set => orig.Fsm = value;
    }

    public GameObject Owner
    {
        get => orig.Owner;
        set => orig.Owner = value;
    }

    public FsmState State
    {
        get => orig.State;
        set => orig.State = value;
    }

    public bool Enabled
    {
        get => orig.Enabled;
        set => orig.Enabled = value;
    }

    public bool IsOpen
    {
        get => orig.IsOpen;
        set => orig.IsOpen = value;
    }

    public bool IsAutoNamed
    {
        get => orig.IsAutoNamed;
        set => orig.IsAutoNamed = value;
    }

    public bool Entered
    {
        get => orig.Entered;
        set => orig.Entered = value;
    }

    public bool Finished
    {
        get => orig.Finished;
        set => orig.Finished = value;
    }

    public bool Active
    {
        get => orig.Active;
        set => orig.Active = value;
    }

    public void Reset()
    {
        orig.Reset();
    }

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public void UpdateVariableValue()
    {
        CallMethod();
    }

    public void OnUpdate()
    {
        orig.OnUpdate();
    }
}