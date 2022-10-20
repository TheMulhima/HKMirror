namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for LoadingPulse.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILLoadingPulse
{
    public static event ILContext.Manipulator Start
    {
        add => IL.LoadingPulse.Start += value;
        remove => IL.LoadingPulse.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.LoadingPulse.Update += value;
        remove => IL.LoadingPulse.Update -= value;
    }
}