namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ReplaceTextLineBreaks.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILReplaceTextLineBreaks
{
    public static event ILContext.Manipulator Start
    {
        add => IL.ReplaceTextLineBreaks.Start += value;
        remove => IL.ReplaceTextLineBreaks.Start -= value;
    }
}