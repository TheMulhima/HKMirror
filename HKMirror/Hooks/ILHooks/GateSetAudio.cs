namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GateSetAudio.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGateSetAudio
{
    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.GateSetAudio.OnTriggerEnter2D += value;
        remove => IL.GateSetAudio.OnTriggerEnter2D -= value;
    }
}