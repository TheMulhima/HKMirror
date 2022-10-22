namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for FSMUtility,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILFSMUtility
{
    public static event ILContext.Manipulator ObtainFsmList
    {
        add => IL.FSMUtility.ObtainFsmList += value;
        remove => IL.FSMUtility.ObtainFsmList -= value;
    }

    public static event ILContext.Manipulator ReleaseFsmList
    {
        add => IL.FSMUtility.ReleaseFsmList += value;
        remove => IL.FSMUtility.ReleaseFsmList -= value;
    }

    public static event ILContext.Manipulator ContainsFSM
    {
        add => IL.FSMUtility.ContainsFSM += value;
        remove => IL.FSMUtility.ContainsFSM -= value;
    }

    public static event ILContext.Manipulator LocateFSM
    {
        add => IL.FSMUtility.LocateFSM += value;
        remove => IL.FSMUtility.LocateFSM -= value;
    }

    public static event ILContext.Manipulator LocateMyFSM
    {
        add => IL.FSMUtility.LocateMyFSM += value;
        remove => IL.FSMUtility.LocateMyFSM -= value;
    }

    public static event ILContext.Manipulator GetFSM
    {
        add => IL.FSMUtility.GetFSM += value;
        remove => IL.FSMUtility.GetFSM -= value;
    }

    public static event ILContext.Manipulator SendEventToGameObject_GameObject_string_bool
    {
        add => IL.FSMUtility.SendEventToGameObject_GameObject_string_bool += value;
        remove => IL.FSMUtility.SendEventToGameObject_GameObject_string_bool -= value;
    }

    public static event ILContext.Manipulator SendEventToGameObject_GameObject_FsmEvent_bool
    {
        add => IL.FSMUtility.SendEventToGameObject_GameObject_FsmEvent_bool += value;
        remove => IL.FSMUtility.SendEventToGameObject_GameObject_FsmEvent_bool -= value;
    }

    public static event ILContext.Manipulator GetSafe
    {
        add => IL.FSMUtility.GetSafe += value;
        remove => IL.FSMUtility.GetSafe -= value;
    }

    public static event ILContext.Manipulator GetBool
    {
        add => IL.FSMUtility.GetBool += value;
        remove => IL.FSMUtility.GetBool -= value;
    }

    public static event ILContext.Manipulator GetInt
    {
        add => IL.FSMUtility.GetInt += value;
        remove => IL.FSMUtility.GetInt -= value;
    }

    public static event ILContext.Manipulator GetFloat
    {
        add => IL.FSMUtility.GetFloat += value;
        remove => IL.FSMUtility.GetFloat -= value;
    }

    public static event ILContext.Manipulator GetString
    {
        add => IL.FSMUtility.GetString += value;
        remove => IL.FSMUtility.GetString -= value;
    }

    public static event ILContext.Manipulator GetVector3
    {
        add => IL.FSMUtility.GetVector3 += value;
        remove => IL.FSMUtility.GetVector3 -= value;
    }

    public static event ILContext.Manipulator SetBool
    {
        add => IL.FSMUtility.SetBool += value;
        remove => IL.FSMUtility.SetBool -= value;
    }

    public static event ILContext.Manipulator SetInt
    {
        add => IL.FSMUtility.SetInt += value;
        remove => IL.FSMUtility.SetInt -= value;
    }

    public static event ILContext.Manipulator SetFloat
    {
        add => IL.FSMUtility.SetFloat += value;
        remove => IL.FSMUtility.SetFloat -= value;
    }

    public static event ILContext.Manipulator SetString
    {
        add => IL.FSMUtility.SetString += value;
        remove => IL.FSMUtility.SetString -= value;
    }

    public static event ILContext.Manipulator FindFSMWithPersistentBool
    {
        add => IL.FSMUtility.FindFSMWithPersistentBool += value;
        remove => IL.FSMUtility.FindFSMWithPersistentBool -= value;
    }

    public static event ILContext.Manipulator FindFSMWithPersistentInt
    {
        add => IL.FSMUtility.FindFSMWithPersistentInt += value;
        remove => IL.FSMUtility.FindFSMWithPersistentInt -= value;
    }
}