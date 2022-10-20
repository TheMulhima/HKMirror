namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for InfectedBurstLarge.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILInfectedBurstLarge
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.InfectedBurstLarge.Awake += value;
        remove => IL.InfectedBurstLarge.Awake -= value;
    }

    public static event ILContext.Manipulator Start
    {
        add => IL.InfectedBurstLarge.Start += value;
        remove => IL.InfectedBurstLarge.Start -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.InfectedBurstLarge.OnTriggerEnter2D += value;
        remove => IL.InfectedBurstLarge.OnTriggerEnter2D -= value;
    }
}