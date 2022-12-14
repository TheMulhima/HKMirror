namespace HKMirror.Reflection.InstanceClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of HashTableGetNext allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class HashTableGetNextR : InstanceClassWrapper<HashTableGetNext>
{
    public HashTableGetNextR(HashTableGetNext _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmString reference
    {
        get => orig.reference;
        set => orig.reference = value;
    }

    public FsmBool reset
    {
        get => orig.reset;
        set => orig.reset = value;
    }

    public FsmInt startIndex
    {
        get => orig.startIndex;
        set => orig.startIndex = value;
    }

    public FsmInt endIndex
    {
        get => orig.endIndex;
        set => orig.endIndex = value;
    }

    public FsmEvent loopEvent
    {
        get => orig.loopEvent;
        set => orig.loopEvent = value;
    }

    public FsmEvent finishedEvent
    {
        get => orig.finishedEvent;
        set => orig.finishedEvent = value;
    }

    public FsmEvent failureEvent
    {
        get => orig.failureEvent;
        set => orig.failureEvent = value;
    }

    public FsmString key
    {
        get => orig.key;
        set => orig.key = value;
    }

    public FsmVar result
    {
        get => orig.result;
        set => orig.result = value;
    }

    public ArrayList _keys
    {
        get => GetField<ArrayList>();
        set => SetField(value);
    }

    public int nextItemIndex
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public PlayMakerHashTableProxy proxy
    {
        get => GetField<PlayMakerHashTableProxy>();
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

    public void DoGetNextItem()
    {
        CallMethod();
    }

    public void GetItemAtIndex()
    {
        orig.GetItemAtIndex();
    }
}