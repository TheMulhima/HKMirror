namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for VideoMenuOptions.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILVideoMenuOptions
{
    public static event ILContext.Manipulator ConfigureNavigation
    {
        add => IL.VideoMenuOptions.ConfigureNavigation += value;
        remove => IL.VideoMenuOptions.ConfigureNavigation -= value;
    }
}