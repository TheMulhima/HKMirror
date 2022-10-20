namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ChangeFontByLanguage.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILChangeFontByLanguage
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.ChangeFontByLanguage.Awake += value;
        remove => IL.ChangeFontByLanguage.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.ChangeFontByLanguage.Start += value;
        remove => IL.ChangeFontByLanguage.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.ChangeFontByLanguage.OnEnable += value;
        remove => IL.ChangeFontByLanguage.OnEnable -= value;
    }

    public static event ILContext.Manipulator SetFont
    {
        add => IL.ChangeFontByLanguage.SetFont += value;
        remove => IL.ChangeFontByLanguage.SetFont -= value;
    }

    public static event ILContext.Manipulator GetFontScale
    {
        add => IL.ChangeFontByLanguage.GetFontScale += value;
        remove => IL.ChangeFontByLanguage.GetFontScale -= value;
    }
}