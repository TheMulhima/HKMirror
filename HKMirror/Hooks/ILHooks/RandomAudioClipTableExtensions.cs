namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for RandomAudioClipTableExtensions,
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILRandomAudioClipTableExtensions
{
    public static event ILContext.Manipulator PlayOneShot
    {
        add => IL.RandomAudioClipTableExtensions.PlayOneShot += value;
        remove => IL.RandomAudioClipTableExtensions.PlayOneShot -= value;
    }

    public static event ILContext.Manipulator SpawnAndPlayOneShot
    {
        add => IL.RandomAudioClipTableExtensions.SpawnAndPlayOneShot += value;
        remove => IL.RandomAudioClipTableExtensions.SpawnAndPlayOneShot -= value;
    }
}