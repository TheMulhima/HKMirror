namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for HidePromptMarker.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILHidePromptMarker
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.HidePromptMarker.Reset += value;
        remove => IL.HidePromptMarker.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.HidePromptMarker.OnEnter += value;
        remove => IL.HidePromptMarker.OnEnter -= value;
    }
}