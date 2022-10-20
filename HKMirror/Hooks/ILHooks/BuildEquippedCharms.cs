namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BuildEquippedCharms.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBuildEquippedCharms
{
    public static event ILContext.Manipulator Start
    {
        add => IL.BuildEquippedCharms.Start += value;
        remove => IL.BuildEquippedCharms.Start -= value;
    }

    public static event ILContext.Manipulator BuildCharmList
    {
        add => IL.BuildEquippedCharms.BuildCharmList += value;
        remove => IL.BuildEquippedCharms.BuildCharmList -= value;
    }

    public static event ILContext.Manipulator UpdateNotches
    {
        add => IL.BuildEquippedCharms.UpdateNotches += value;
        remove => IL.BuildEquippedCharms.UpdateNotches -= value;
    }

    public static event ILContext.Manipulator GetObjectAt
    {
        add => IL.BuildEquippedCharms.GetObjectAt += value;
        remove => IL.BuildEquippedCharms.GetObjectAt -= value;
    }

    public static event ILContext.Manipulator GetUICount
    {
        add => IL.BuildEquippedCharms.GetUICount += value;
        remove => IL.BuildEquippedCharms.GetUICount -= value;
    }

    public static event ILContext.Manipulator GetItemName
    {
        add => IL.BuildEquippedCharms.GetItemName += value;
        remove => IL.BuildEquippedCharms.GetItemName -= value;
    }
}