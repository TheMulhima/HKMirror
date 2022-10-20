namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for StandaloneLoadingSpinner.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILStandaloneLoadingSpinner
{
    public static event ILContext.Manipulator Setup
    {
        add => IL.StandaloneLoadingSpinner.Setup += value;
        remove => IL.StandaloneLoadingSpinner.Setup -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.StandaloneLoadingSpinner.OnEnable += value;
        remove => IL.StandaloneLoadingSpinner.OnEnable -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.StandaloneLoadingSpinner.Start += value;
        remove => IL.StandaloneLoadingSpinner.Start -= value;
    }

    public static event ILContext.Manipulator LateUpdate
    {
        add => IL.StandaloneLoadingSpinner.LateUpdate += value;
        remove => IL.StandaloneLoadingSpinner.LateUpdate -= value;
    }
}