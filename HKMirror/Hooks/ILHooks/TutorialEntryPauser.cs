namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for TutorialEntryPauser.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILTutorialEntryPauser
{
    public static event ILContext.Manipulator Start
    {
        add => IL.TutorialEntryPauser.Start += value;
        remove => IL.TutorialEntryPauser.Start -= value;
    }

    public static event ILContext.Manipulator EnableControl
    {
        add => IL.TutorialEntryPauser.EnableControl += value;
        remove => IL.TutorialEntryPauser.EnableControl -= value;
    }
}