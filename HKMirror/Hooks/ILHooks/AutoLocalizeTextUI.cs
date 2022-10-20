namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for AutoLocalizeTextUI.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILAutoLocalizeTextUI
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.AutoLocalizeTextUI.Awake += value;
        remove => IL.AutoLocalizeTextUI.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.AutoLocalizeTextUI.OnEnable += value;
        remove => IL.AutoLocalizeTextUI.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.AutoLocalizeTextUI.OnDisable += value;
        remove => IL.AutoLocalizeTextUI.OnDisable -= value;
    }

    public static event ILContext.Manipulator RefreshTextFromLocalization
    {
        add => IL.AutoLocalizeTextUI.RefreshTextFromLocalization += value;
        remove => IL.AutoLocalizeTextUI.RefreshTextFromLocalization -= value;
    }
}