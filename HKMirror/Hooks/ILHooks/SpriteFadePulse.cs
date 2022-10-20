namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SpriteFadePulse.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSpriteFadePulse
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.SpriteFadePulse.Awake += value;
        remove => IL.SpriteFadePulse.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.SpriteFadePulse.OnEnable += value;
        remove => IL.SpriteFadePulse.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.SpriteFadePulse.Update += value;
        remove => IL.SpriteFadePulse.Update -= value;
    }

    public static event ILContext.Manipulator FadeIn
    {
        add => IL.SpriteFadePulse.FadeIn += value;
        remove => IL.SpriteFadePulse.FadeIn -= value;
    }

    public static event ILContext.Manipulator FadeOut
    {
        add => IL.SpriteFadePulse.FadeOut += value;
        remove => IL.SpriteFadePulse.FadeOut -= value;
    }
}