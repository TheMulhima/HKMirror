namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for RandomAudioStart.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILRandomAudioStart
{
    public static event ILContext.Manipulator Start
    {
        add => IL.RandomAudioStart.Start += value;
        remove => IL.RandomAudioStart.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.RandomAudioStart.Update += value;
        remove => IL.RandomAudioStart.Update -= value;
    }
}