namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CheckTrackTriggerCount.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCheckTrackTriggerCount
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.CheckTrackTriggerCount.Reset += value;
        remove => IL.CheckTrackTriggerCount.Reset -= value;
    }

    public static event ILContext.Manipulator OnPreprocess
    {
        add => IL.CheckTrackTriggerCount.OnPreprocess += value;
        remove => IL.CheckTrackTriggerCount.OnPreprocess -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.CheckTrackTriggerCount.OnEnter += value;
        remove => IL.CheckTrackTriggerCount.OnEnter -= value;
    }

    public static event ILContext.Manipulator OnFixedUpdate
    {
        add => IL.CheckTrackTriggerCount.OnFixedUpdate += value;
        remove => IL.CheckTrackTriggerCount.OnFixedUpdate -= value;
    }

    public static event ILContext.Manipulator CheckCount
    {
        add => IL.CheckTrackTriggerCount.CheckCount += value;
        remove => IL.CheckTrackTriggerCount.CheckCount -= value;
    }
}