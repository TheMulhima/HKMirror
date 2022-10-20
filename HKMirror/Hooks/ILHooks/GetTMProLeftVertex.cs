namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GetTMProLeftVertex.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGetTMProLeftVertex
{
    public static event ILContext.Manipulator Start
    {
        add => IL.GetTMProLeftVertex.Start += value;
        remove => IL.GetTMProLeftVertex.Start -= value;
    }

    public static event ILContext.Manipulator GetLeftmostVertex
    {
        add => IL.GetTMProLeftVertex.GetLeftmostVertex += value;
        remove => IL.GetTMProLeftVertex.GetLeftmostVertex -= value;
    }
}