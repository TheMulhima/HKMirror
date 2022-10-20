namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ParticleSystemAutoRecycle.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILParticleSystemAutoRecycle
{
    public static event ILContext.Manipulator Start
    {
        add => IL.ParticleSystemAutoRecycle.Start += value;
        remove => IL.ParticleSystemAutoRecycle.Start -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.ParticleSystemAutoRecycle.Update += value;
        remove => IL.ParticleSystemAutoRecycle.Update -= value;
    }
}