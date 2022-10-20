namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for JournalListOld.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILJournalListOld
{
    public static event ILContext.Manipulator Start
    {
        add => IL.JournalListOld.Start += value;
        remove => IL.JournalListOld.Start -= value;
    }

    public static event ILContext.Manipulator BuildItemList
    {
        add => IL.JournalListOld.BuildItemList += value;
        remove => IL.JournalListOld.BuildItemList -= value;
    }

    public static event ILContext.Manipulator GetItemCount
    {
        add => IL.JournalListOld.GetItemCount += value;
        remove => IL.JournalListOld.GetItemCount -= value;
    }

    public static event ILContext.Manipulator GetNameConvo
    {
        add => IL.JournalListOld.GetNameConvo += value;
        remove => IL.JournalListOld.GetNameConvo -= value;
    }

    public static event ILContext.Manipulator GetDescConvo
    {
        add => IL.JournalListOld.GetDescConvo += value;
        remove => IL.JournalListOld.GetDescConvo -= value;
    }

    public static event ILContext.Manipulator GetWarriorGhost
    {
        add => IL.JournalListOld.GetWarriorGhost += value;
        remove => IL.JournalListOld.GetWarriorGhost -= value;
    }

    public static event ILContext.Manipulator GetNotesConvo
    {
        add => IL.JournalListOld.GetNotesConvo += value;
        remove => IL.JournalListOld.GetNotesConvo -= value;
    }

    public static event ILContext.Manipulator GetPlayerDataBoolName
    {
        add => IL.JournalListOld.GetPlayerDataBoolName += value;
        remove => IL.JournalListOld.GetPlayerDataBoolName -= value;
    }

    public static event ILContext.Manipulator GetPlayerDataKillsName
    {
        add => IL.JournalListOld.GetPlayerDataKillsName += value;
        remove => IL.JournalListOld.GetPlayerDataKillsName -= value;
    }

    public static event ILContext.Manipulator GetPlayerDataNewDataName
    {
        add => IL.JournalListOld.GetPlayerDataNewDataName += value;
        remove => IL.JournalListOld.GetPlayerDataNewDataName -= value;
    }

    public static event ILContext.Manipulator GetSprite
    {
        add => IL.JournalListOld.GetSprite += value;
        remove => IL.JournalListOld.GetSprite -= value;
    }

    public static event ILContext.Manipulator GetYDistance
    {
        add => IL.JournalListOld.GetYDistance += value;
        remove => IL.JournalListOld.GetYDistance -= value;
    }

    public static event ILContext.Manipulator GetFirstNewItem
    {
        add => IL.JournalListOld.GetFirstNewItem += value;
        remove => IL.JournalListOld.GetFirstNewItem -= value;
    }
}