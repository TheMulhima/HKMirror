namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for StopAnimatorsAtPoint.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILStopAnimatorsAtPoint
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.StopAnimatorsAtPoint.Awake += value;
        remove => IL.StopAnimatorsAtPoint.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.StopAnimatorsAtPoint.Start += value;
        remove => IL.StopAnimatorsAtPoint.Start -= value;
    }

    public static event ILContext.Manipulator SetCanStop
    {
        add => IL.StopAnimatorsAtPoint.SetCanStop += value;
        remove => IL.StopAnimatorsAtPoint.SetCanStop -= value;
    }

    public static event ILContext.Manipulator SetCannotStop
    {
        add => IL.StopAnimatorsAtPoint.SetCannotStop += value;
        remove => IL.StopAnimatorsAtPoint.SetCannotStop -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.StopAnimatorsAtPoint.Update += value;
        remove => IL.StopAnimatorsAtPoint.Update -= value;
    }
}