namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for RestBench.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILRestBench
{
    public static event ILContext.Manipulator Start
    {
        add => IL.RestBench.Start += value;
        remove => IL.RestBench.Start -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.RestBench.OnTriggerEnter2D += value;
        remove => IL.RestBench.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerExit2D
    {
        add => IL.RestBench.OnTriggerExit2D += value;
        remove => IL.RestBench.OnTriggerExit2D -= value;
    }
}