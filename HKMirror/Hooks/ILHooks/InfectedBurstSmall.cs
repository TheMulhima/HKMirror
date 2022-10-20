namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for InfectedBurstSmall.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILInfectedBurstSmall
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.InfectedBurstSmall.Awake += value;
        remove => IL.InfectedBurstSmall.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.InfectedBurstSmall.Start += value;
        remove => IL.InfectedBurstSmall.Start -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.InfectedBurstSmall.OnTriggerEnter2D += value;
        remove => IL.InfectedBurstSmall.OnTriggerEnter2D -= value;
    }
}