namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for RestBenchTilt.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILRestBenchTilt
{
    public static event ILContext.Manipulator GetTilt
    {
        add => IL.RestBenchTilt.GetTilt += value;
        remove => IL.RestBenchTilt.GetTilt -= value;
    }
}