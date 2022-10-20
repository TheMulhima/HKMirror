namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GetLanguageStringProcessed.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGetLanguageStringProcessed
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.GetLanguageStringProcessed.Reset += value;
        remove => IL.GetLanguageStringProcessed.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.GetLanguageStringProcessed.OnEnter += value;
        remove => IL.GetLanguageStringProcessed.OnEnter -= value;
    }
}