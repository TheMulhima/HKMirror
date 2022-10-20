namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for Probability.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILProbability
{
    public static event ILContext.Manipulator GetRandomGameObjectByProbability
    {
        add => IL.Probability.GetRandomGameObjectByProbability += value;
        remove => IL.Probability.GetRandomGameObjectByProbability -= value;
    }
}