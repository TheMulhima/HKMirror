namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GenerateJournalNewDot.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGenerateJournalNewDot
{
    public static event ILContext.Manipulator Start
    {
        add => IL.GenerateJournalNewDot.Start += value;
        remove => IL.GenerateJournalNewDot.Start -= value;
    }
}