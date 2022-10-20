namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for FadeColorFader.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILFadeColorFader
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.FadeColorFader.Reset += value;
        remove => IL.FadeColorFader.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.FadeColorFader.OnEnter += value;
        remove => IL.FadeColorFader.OnEnter -= value;
    }
}