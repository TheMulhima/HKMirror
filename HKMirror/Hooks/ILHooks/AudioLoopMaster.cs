namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for AudioLoopMaster.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILAudioLoopMaster
{
    public static event ILContext.Manipulator Start
    {
        add => IL.AudioLoopMaster.Start += value;
        remove => IL.AudioLoopMaster.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.AudioLoopMaster.Update += value;
        remove => IL.AudioLoopMaster.Update -= value;
    }

    public static event ILContext.Manipulator SetSyncAction
    {
        add => IL.AudioLoopMaster.SetSyncAction += value;
        remove => IL.AudioLoopMaster.SetSyncAction -= value;
    }

    public static event ILContext.Manipulator SetSyncSub
    {
        add => IL.AudioLoopMaster.SetSyncSub += value;
        remove => IL.AudioLoopMaster.SetSyncSub -= value;
    }

    public static event ILContext.Manipulator SetSyncMainAlt
    {
        add => IL.AudioLoopMaster.SetSyncMainAlt += value;
        remove => IL.AudioLoopMaster.SetSyncMainAlt -= value;
    }

    public static event ILContext.Manipulator SetSyncTension
    {
        add => IL.AudioLoopMaster.SetSyncTension += value;
        remove => IL.AudioLoopMaster.SetSyncTension -= value;
    }

    public static event ILContext.Manipulator SetSyncExtra
    {
        add => IL.AudioLoopMaster.SetSyncExtra += value;
        remove => IL.AudioLoopMaster.SetSyncExtra -= value;
    }
}