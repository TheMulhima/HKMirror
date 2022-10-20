namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CheckAlertRange.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCheckAlertRange
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.CheckAlertRange.Reset += value;
        remove => IL.CheckAlertRange.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.CheckAlertRange.OnEnter += value;
        remove => IL.CheckAlertRange.OnEnter -= value;
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add => IL.CheckAlertRange.OnUpdate += value;
        remove => IL.CheckAlertRange.OnUpdate -= value;
    }

    public static event ILContext.Manipulator Apply
    {
        add => IL.CheckAlertRange.Apply += value;
        remove => IL.CheckAlertRange.Apply -= value;
    }
}