namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of PlayerDataBoolTrueAndFalse allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayerDataBoolTrueAndFalseR : InstanceClassWrapper<PlayerDataBoolTrueAndFalse>
{
    public PlayerDataBoolTrueAndFalseR(PlayerDataBoolTrueAndFalse _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmString trueBool
    {
        get => orig.trueBool;
        set => orig.trueBool = value;
    }

    public FsmString falseBool
    {
        get => orig.falseBool;
        set => orig.falseBool = value;
    }

    public FsmEvent isTrue
    {
        get => orig.isTrue;
        set => orig.isTrue = value;
    }

    public FsmEvent isFalse
    {
        get => orig.isFalse;
        set => orig.isFalse = value;
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
}