namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for DisplayCurrentLanguage.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDisplayCurrentLanguage
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.DisplayCurrentLanguage.Awake += value;
        remove => IL.DisplayCurrentLanguage.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.DisplayCurrentLanguage.OnEnable += value;
        remove => IL.DisplayCurrentLanguage.OnEnable -= value;
    }
}