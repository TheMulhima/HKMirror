using UnityEngine.UI;

namespace HKMirror.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of uGuiInputFieldRebuild allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class uGuiInputFieldRebuildR : InstanceClassWrapper<uGuiInputFieldRebuild>
{
    public uGuiInputFieldRebuildR(uGuiInputFieldRebuild _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public CanvasUpdate canvasUpdate
    {
        get => orig.canvasUpdate;
        set => orig.canvasUpdate = value;
    }

    public bool rebuildOnExit
    {
        get => orig.rebuildOnExit;
        set => orig.rebuildOnExit = value;
    }

    public Graphic _graphic
    {
        get => GetField<Graphic>();
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

    public void DoAction()
    {
        CallMethod();
    }

    public void OnExit()
    {
        orig.OnExit();
    }
}