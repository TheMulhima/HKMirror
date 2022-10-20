namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GameMenuOptions.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGameMenuOptions
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.GameMenuOptions.OnEnable += value;
        remove => IL.GameMenuOptions.OnEnable -= value;
    }

    public static event ILContext.Manipulator ConfigureNavigation
    {
        add => IL.GameMenuOptions.ConfigureNavigation += value;
        remove => IL.GameMenuOptions.ConfigureNavigation -= value;
    }
}