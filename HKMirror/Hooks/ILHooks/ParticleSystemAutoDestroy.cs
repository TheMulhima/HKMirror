namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ParticleSystemAutoDestroy.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILParticleSystemAutoDestroy
{
    public static event ILContext.Manipulator Start
    {
        add => IL.ParticleSystemAutoDestroy.Start += value;
        remove => IL.ParticleSystemAutoDestroy.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.ParticleSystemAutoDestroy.Update += value;
        remove => IL.ParticleSystemAutoDestroy.Update -= value;
    }
}