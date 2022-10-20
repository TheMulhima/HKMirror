namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CheckAlertRangeByName.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCheckAlertRangeByName
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.CheckAlertRangeByName.Reset += value;
        remove => IL.CheckAlertRangeByName.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.CheckAlertRangeByName.OnEnter += value;
        remove => IL.CheckAlertRangeByName.OnEnter -= value;
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add => IL.CheckAlertRangeByName.OnUpdate += value;
        remove => IL.CheckAlertRangeByName.OnUpdate -= value;
    }

    public static event ILContext.Manipulator Apply
    {
        add => IL.CheckAlertRangeByName.Apply += value;
        remove => IL.CheckAlertRangeByName.Apply -= value;
    }
}