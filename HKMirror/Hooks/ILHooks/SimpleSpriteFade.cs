namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SimpleSpriteFade.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSimpleSpriteFade
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.SimpleSpriteFade.Awake += value;
        remove => IL.SimpleSpriteFade.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.SimpleSpriteFade.OnEnable += value;
        remove => IL.SimpleSpriteFade.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.SimpleSpriteFade.Update += value;
        remove => IL.SimpleSpriteFade.Update -= value;
    }

    public static event ILContext.Manipulator FadeIn
    {
        add => IL.SimpleSpriteFade.FadeIn += value;
        remove => IL.SimpleSpriteFade.FadeIn -= value;
    }

    public static event ILContext.Manipulator FadeOut
    {
        add => IL.SimpleSpriteFade.FadeOut += value;
        remove => IL.SimpleSpriteFade.FadeOut -= value;
    }
}