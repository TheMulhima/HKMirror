namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for LocalizationSettings.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILLocalizationSettings
{
    public static event ILContext.Manipulator GetLanguageEnum
    {
        add => IL.LocalizationSettings.GetLanguageEnum += value;
        remove => IL.LocalizationSettings.GetLanguageEnum -= value;
    }
}