namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for BreakablePoleSimple.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILBreakablePoleSimple
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.BreakablePoleSimple.Awake += value;
        remove => IL.BreakablePoleSimple.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.BreakablePoleSimple.Start += value;
        remove => IL.BreakablePoleSimple.Start -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.BreakablePoleSimple.OnTriggerEnter2D += value;
        remove => IL.BreakablePoleSimple.OnTriggerEnter2D -= value;
    }
}