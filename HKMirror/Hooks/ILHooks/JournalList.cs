namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for JournalList.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILJournalList
{
    public static event ILContext.Manipulator BuildEnemyList
    {
        add => IL.JournalList.BuildEnemyList += value;
        remove => IL.JournalList.BuildEnemyList -= value;
    }

    public static event ILContext.Manipulator UpdateEnemyList
    {
        add => IL.JournalList.UpdateEnemyList += value;
        remove => IL.JournalList.UpdateEnemyList -= value;
    }

    public static event ILContext.Manipulator GetItemCount
    {
        add => IL.JournalList.GetItemCount += value;
        remove => IL.JournalList.GetItemCount -= value;
    }

    public static event ILContext.Manipulator GetNameConvo
    {
        add => IL.JournalList.GetNameConvo += value;
        remove => IL.JournalList.GetNameConvo -= value;
    }

    public static event ILContext.Manipulator GetDescConvo
    {
        add => IL.JournalList.GetDescConvo += value;
        remove => IL.JournalList.GetDescConvo -= value;
    }

    public static event ILContext.Manipulator GetWarriorGhost
    {
        add => IL.JournalList.GetWarriorGhost += value;
        remove => IL.JournalList.GetWarriorGhost -= value;
    }

    public static event ILContext.Manipulator GetGrimm
    {
        add => IL.JournalList.GetGrimm += value;
        remove => IL.JournalList.GetGrimm -= value;
    }

    public static event ILContext.Manipulator GetNotesConvo
    {
        add => IL.JournalList.GetNotesConvo += value;
        remove => IL.JournalList.GetNotesConvo -= value;
    }

    public static event ILContext.Manipulator GetPlayerDataBoolName
    {
        add => IL.JournalList.GetPlayerDataBoolName += value;
        remove => IL.JournalList.GetPlayerDataBoolName -= value;
    }

    public static event ILContext.Manipulator GetPlayerDataKillsName
    {
        add => IL.JournalList.GetPlayerDataKillsName += value;
        remove => IL.JournalList.GetPlayerDataKillsName -= value;
    }

    public static event ILContext.Manipulator GetPlayerDataNewDataName
    {
        add => IL.JournalList.GetPlayerDataNewDataName += value;
        remove => IL.JournalList.GetPlayerDataNewDataName -= value;
    }

    public static event ILContext.Manipulator GetSprite
    {
        add => IL.JournalList.GetSprite += value;
        remove => IL.JournalList.GetSprite -= value;
    }

    public static event ILContext.Manipulator GetYDistance
    {
        add => IL.JournalList.GetYDistance += value;
        remove => IL.JournalList.GetYDistance -= value;
    }

    public static event ILContext.Manipulator GetFirstNewItem
    {
        add => IL.JournalList.GetFirstNewItem += value;
        remove => IL.JournalList.GetFirstNewItem -= value;
    }
}