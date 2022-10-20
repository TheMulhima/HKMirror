namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PlayParticleOnEntry.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPlayParticleOnEntry
{
    public static event ILContext.Manipulator Start
    {
        add => IL.PlayParticleOnEntry.Start += value;
        remove => IL.PlayParticleOnEntry.Start -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.PlayParticleOnEntry.OnTriggerEnter2D += value;
        remove => IL.PlayParticleOnEntry.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerExit2D
    {
        add => IL.PlayParticleOnEntry.OnTriggerExit2D += value;
        remove => IL.PlayParticleOnEntry.OnTriggerExit2D -= value;
    }
}