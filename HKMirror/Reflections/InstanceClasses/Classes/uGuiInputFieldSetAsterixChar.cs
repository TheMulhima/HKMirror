using UnityEngine.UI;

namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of uGuiInputFieldSetAsterixChar allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class uGuiInputFieldSetAsterixCharR : InstanceClassWrapper<uGuiInputFieldSetAsterixChar>
{
    public uGuiInputFieldSetAsterixCharR(uGuiInputFieldSetAsterixChar _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmString asterixChar
    {
        get => orig.asterixChar;
        set => orig.asterixChar = value;
    }

    public FsmBool resetOnExit
    {
        get => orig.resetOnExit;
        set => orig.resetOnExit = value;
    }

    public InputField _inputField
    {
        get => GetField<InputField>();
        set => SetField(value);
    }

    public char _originalValue
    {
        get => GetField<char>();
        set => SetField(value);
    }

    public char __char__
    {
        get => GetFieldStatic<char>();
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

    public void DoSetValue()
    {
        CallMethod();
    }

    public void OnExit()
    {
        orig.OnExit();
    }
}