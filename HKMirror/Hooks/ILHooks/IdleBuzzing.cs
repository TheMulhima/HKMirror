namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for IdleBuzzing.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILIdleBuzzing
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.IdleBuzzing.Reset += value;
        remove => IL.IdleBuzzing.Reset -= value;
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.IdleBuzzing.Awake += value;
        remove => IL.IdleBuzzing.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.IdleBuzzing.Start += value;
        remove => IL.IdleBuzzing.Start -= value;
    }

    public static event ILContext.Manipulator FixedUpdate
    {
        add => IL.IdleBuzzing.FixedUpdate += value;
        remove => IL.IdleBuzzing.FixedUpdate -= value;
    }

    public static event ILContext.Manipulator Buzz
    {
        add => IL.IdleBuzzing.Buzz += value;
        remove => IL.IdleBuzzing.Buzz -= value;
    }
}