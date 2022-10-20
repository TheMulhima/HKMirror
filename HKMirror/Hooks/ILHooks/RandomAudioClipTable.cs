namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for RandomAudioClipTable.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILRandomAudioClipTable
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.RandomAudioClipTable.Reset += value;
        remove => IL.RandomAudioClipTable.Reset -= value;
    }

    public static event ILContext.Manipulator SelectClip
    {
        add => IL.RandomAudioClipTable.SelectClip += value;
        remove => IL.RandomAudioClipTable.SelectClip -= value;
    }

    public static event ILContext.Manipulator SelectPitch
    {
        add => IL.RandomAudioClipTable.SelectPitch += value;
        remove => IL.RandomAudioClipTable.SelectPitch -= value;
    }

    public static event ILContext.Manipulator PlayOneShotUnsafe
    {
        add => IL.RandomAudioClipTable.PlayOneShotUnsafe += value;
        remove => IL.RandomAudioClipTable.PlayOneShotUnsafe -= value;
    }
}