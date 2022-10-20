namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ReduceParticleEffects.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILReduceParticleEffects
{
    public static event ILContext.Manipulator Start
    {
        add => IL.ReduceParticleEffects.Start += value;
        remove => IL.ReduceParticleEffects.Start -= value;
    }

    public static event ILContext.Manipulator SetEmission
    {
        add => IL.ReduceParticleEffects.SetEmission += value;
        remove => IL.ReduceParticleEffects.SetEmission -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.ReduceParticleEffects.OnEnable += value;
        remove => IL.ReduceParticleEffects.OnEnable -= value;
    }

    public static event ILContext.Manipulator OnDisable
    {
        add => IL.ReduceParticleEffects.OnDisable += value;
        remove => IL.ReduceParticleEffects.OnDisable -= value;
    }
}