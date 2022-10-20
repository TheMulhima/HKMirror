namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SpawnableAudioSource.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSpawnableAudioSource
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.SpawnableAudioSource.Awake += value;
        remove => IL.SpawnableAudioSource.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.SpawnableAudioSource.OnEnable += value;
        remove => IL.SpawnableAudioSource.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.SpawnableAudioSource.Update += value;
        remove => IL.SpawnableAudioSource.Update -= value;
    }

    public static event ILContext.Manipulator Stop
    {
        add => IL.SpawnableAudioSource.Stop += value;
        remove => IL.SpawnableAudioSource.Stop -= value;
    }
}