namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PersistentIntItem.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPersistentIntItem
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.PersistentIntItem.Awake += value;
        remove => IL.PersistentIntItem.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.PersistentIntItem.OnEnable += value;
        remove => IL.PersistentIntItem.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.PersistentIntItem.OnDisable += value;
        remove => IL.PersistentIntItem.OnDisable -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.PersistentIntItem.Start += value;
        remove => IL.PersistentIntItem.Start -= value;
    }

    public static event ILContext.Manipulator SaveState
    {
        add => IL.PersistentIntItem.SaveState += value;
        remove => IL.PersistentIntItem.SaveState -= value;
    }

    public static event ILContext.Manipulator ResetState
    {
        add => IL.PersistentIntItem.ResetState += value;
        remove => IL.PersistentIntItem.ResetState -= value;
    }

    public static event ILContext.Manipulator SetMyID
    {
        add => IL.PersistentIntItem.SetMyID += value;
        remove => IL.PersistentIntItem.SetMyID -= value;
    }

    public static event ILContext.Manipulator UpdateValueFromFSM
    {
        add => IL.PersistentIntItem.UpdateValueFromFSM += value;
        remove => IL.PersistentIntItem.UpdateValueFromFSM -= value;
    }

    public static event ILContext.Manipulator SetValueOnFSM
    {
        add => IL.PersistentIntItem.SetValueOnFSM += value;
        remove => IL.PersistentIntItem.SetValueOnFSM -= value;
    }

    public static event ILContext.Manipulator LookForMyFSM
    {
        add => IL.PersistentIntItem.LookForMyFSM += value;
        remove => IL.PersistentIntItem.LookForMyFSM -= value;
    }
}