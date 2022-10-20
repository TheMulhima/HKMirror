namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for MainMenuOptions.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILMainMenuOptions
{
    public static event ILContext.Manipulator ConfigureNavigation
    {
        add => IL.MainMenuOptions.ConfigureNavigation += value;
        remove => IL.MainMenuOptions.ConfigureNavigation -= value;
    }
}