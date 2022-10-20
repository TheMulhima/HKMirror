namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ParticleSystemAutoDisable.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILParticleSystemAutoDisable
{
    public static event ILContext.Manipulator Start
    {
        add => IL.ParticleSystemAutoDisable.Start += value;
        remove => IL.ParticleSystemAutoDisable.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.ParticleSystemAutoDisable.Update += value;
        remove => IL.ParticleSystemAutoDisable.Update -= value;
    }
}