namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PersistentBoolItem.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPersistentBoolItem
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.PersistentBoolItem.Awake += value;
        remove => IL.PersistentBoolItem.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.PersistentBoolItem.OnEnable += value;
        remove => IL.PersistentBoolItem.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.PersistentBoolItem.OnDisable += value;
        remove => IL.PersistentBoolItem.OnDisable -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.PersistentBoolItem.Start += value;
        remove => IL.PersistentBoolItem.Start -= value;
    }

    public static event ILContext.Manipulator SaveState
    {
        add => IL.PersistentBoolItem.SaveState += value;
        remove => IL.PersistentBoolItem.SaveState -= value;
    }

    public static event ILContext.Manipulator ResetState
    {
        add => IL.PersistentBoolItem.ResetState += value;
        remove => IL.PersistentBoolItem.ResetState -= value;
    }

    public static event ILContext.Manipulator SetMyID
    {
        add => IL.PersistentBoolItem.SetMyID += value;
        remove => IL.PersistentBoolItem.SetMyID -= value;
    }

    public static event ILContext.Manipulator PreSetup
    {
        add => IL.PersistentBoolItem.PreSetup += value;
        remove => IL.PersistentBoolItem.PreSetup -= value;
    }

    public static event ILContext.Manipulator UpdateActivatedFromFSM
    {
        add => IL.PersistentBoolItem.UpdateActivatedFromFSM += value;
        remove => IL.PersistentBoolItem.UpdateActivatedFromFSM -= value;
    }

    public static event ILContext.Manipulator LookForMyFSM
    {
        add => IL.PersistentBoolItem.LookForMyFSM += value;
        remove => IL.PersistentBoolItem.LookForMyFSM -= value;
    }
}