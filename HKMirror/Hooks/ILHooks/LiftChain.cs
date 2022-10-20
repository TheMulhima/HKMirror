namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for LiftChain.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILLiftChain
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.LiftChain.Awake += value;
        remove => IL.LiftChain.Awake -= value;
    }

    public static event ILContext.Manipulator GoDown
    {
        add => IL.LiftChain.GoDown += value;
        remove => IL.LiftChain.GoDown -= value;
    }

    public static event ILContext.Manipulator GoUp
    {
        add => IL.LiftChain.GoUp += value;
        remove => IL.LiftChain.GoUp -= value;
    }

    public static event ILContext.Manipulator Stop
    {
        add => IL.LiftChain.Stop += value;
        remove => IL.LiftChain.Stop -= value;
    }
}