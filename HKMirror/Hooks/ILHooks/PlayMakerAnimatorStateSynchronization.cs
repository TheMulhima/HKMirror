namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PlayMakerAnimatorStateSynchronization.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPlayMakerAnimatorStateSynchronization
{
    public static event ILContext.Manipulator Start
    {
        add => IL.PlayMakerAnimatorStateSynchronization.Start += value;
        remove => IL.PlayMakerAnimatorStateSynchronization.Start -= value;
    }

    public static event ILContext.Manipulator RegisterHash
    {
        add => IL.PlayMakerAnimatorStateSynchronization.RegisterHash += value;
        remove => IL.PlayMakerAnimatorStateSynchronization.RegisterHash -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.PlayMakerAnimatorStateSynchronization.Update += value;
        remove => IL.PlayMakerAnimatorStateSynchronization.Update -= value;
    }

    public static event ILContext.Manipulator Synchronize
    {
        add => IL.PlayMakerAnimatorStateSynchronization.Synchronize += value;
        remove => IL.PlayMakerAnimatorStateSynchronization.Synchronize -= value;
    }

    public static event ILContext.Manipulator SwitchState
    {
        add => IL.PlayMakerAnimatorStateSynchronization.SwitchState += value;
        remove => IL.PlayMakerAnimatorStateSynchronization.SwitchState -= value;
    }
}