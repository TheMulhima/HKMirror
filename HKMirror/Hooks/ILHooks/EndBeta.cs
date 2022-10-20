namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for EndBeta.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILEndBeta
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.EndBeta.Awake += value;
        remove => IL.EndBeta.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.EndBeta.Start += value;
        remove => IL.EndBeta.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.EndBeta.Update += value;
        remove => IL.EndBeta.Update -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.EndBeta.OnTriggerEnter2D += value;
        remove => IL.EndBeta.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator Reactivate
    {
        add => IL.EndBeta.Reactivate += value;
        remove => IL.EndBeta.Reactivate -= value;
    }
}