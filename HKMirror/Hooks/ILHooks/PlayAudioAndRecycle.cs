namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PlayAudioAndRecycle.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPlayAudioAndRecycle
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.PlayAudioAndRecycle.OnEnable += value;
        remove => IL.PlayAudioAndRecycle.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.PlayAudioAndRecycle.Update += value;
        remove => IL.PlayAudioAndRecycle.Update -= value;
    }
}