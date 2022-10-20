namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for JournalEntryStats.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILJournalEntryStats
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.JournalEntryStats.Awake += value;
        remove => IL.JournalEntryStats.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.JournalEntryStats.OnEnable += value;
        remove => IL.JournalEntryStats.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.JournalEntryStats.OnDisable += value;
        remove => IL.JournalEntryStats.OnDisable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.JournalEntryStats.Update += value;
        remove => IL.JournalEntryStats.Update -= value;
    }

    public static event ILContext.Manipulator GetNameConvo
    {
        add => IL.JournalEntryStats.GetNameConvo += value;
        remove => IL.JournalEntryStats.GetNameConvo -= value;
    }

    public static event ILContext.Manipulator GetDescConvo
    {
        add => IL.JournalEntryStats.GetDescConvo += value;
        remove => IL.JournalEntryStats.GetDescConvo -= value;
    }

    public static event ILContext.Manipulator GetNotesConvo
    {
        add => IL.JournalEntryStats.GetNotesConvo += value;
        remove => IL.JournalEntryStats.GetNotesConvo -= value;
    }

    public static event ILContext.Manipulator GetPlayerDataBoolName
    {
        add => IL.JournalEntryStats.GetPlayerDataBoolName += value;
        remove => IL.JournalEntryStats.GetPlayerDataBoolName -= value;
    }

    public static event ILContext.Manipulator GetPlayerDataKillsName
    {
        add => IL.JournalEntryStats.GetPlayerDataKillsName += value;
        remove => IL.JournalEntryStats.GetPlayerDataKillsName -= value;
    }

    public static event ILContext.Manipulator GetPlayerDataNewDataName
    {
        add => IL.JournalEntryStats.GetPlayerDataNewDataName += value;
        remove => IL.JournalEntryStats.GetPlayerDataNewDataName -= value;
    }

    public static event ILContext.Manipulator GetItemNumber
    {
        add => IL.JournalEntryStats.GetItemNumber += value;
        remove => IL.JournalEntryStats.GetItemNumber -= value;
    }

    public static event ILContext.Manipulator GetSprite
    {
        add => IL.JournalEntryStats.GetSprite += value;
        remove => IL.JournalEntryStats.GetSprite -= value;
    }

    public static event ILContext.Manipulator GetWarriorGhost
    {
        add => IL.JournalEntryStats.GetWarriorGhost += value;
        remove => IL.JournalEntryStats.GetWarriorGhost -= value;
    }

    public static event ILContext.Manipulator GetGrimm
    {
        add => IL.JournalEntryStats.GetGrimm += value;
        remove => IL.JournalEntryStats.GetGrimm -= value;
    }
}