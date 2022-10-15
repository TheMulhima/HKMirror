using UnityEngine.UI;

namespace HKMirror.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of uGuiNavigationGetMode allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class uGuiNavigationGetModeR : InstanceClassWrapper<uGuiNavigationGetMode>
{
    public uGuiNavigationGetModeR(uGuiNavigationGetMode _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmString navigationMode
    {
        get => orig.navigationMode;
        set => orig.navigationMode = value;
    }

    public FsmEvent automaticEvent
    {
        get => orig.automaticEvent;
        set => orig.automaticEvent = value;
    }

    public FsmEvent horizontalEvent
    {
        get => orig.horizontalEvent;
        set => orig.horizontalEvent = value;
    }

    public FsmEvent verticalEvent
    {
        get => orig.verticalEvent;
        set => orig.verticalEvent = value;
    }

    public FsmEvent explicitEvent
    {
        get => orig.explicitEvent;
        set => orig.explicitEvent = value;
    }

    public FsmEvent noNavigationEvent
    {
        get => orig.noNavigationEvent;
        set => orig.noNavigationEvent = value;
    }

    public Selectable _selectable
    {
        get => GetField<Selectable>();
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

    public void DoGetValue()
    {
        CallMethod();
    }
}