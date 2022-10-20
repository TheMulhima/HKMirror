namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PlayParticleEffects.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPlayParticleEffects
{
    public static event ILContext.Manipulator PlayParticleSystems
    {
        add => IL.PlayParticleEffects.PlayParticleSystems += value;
        remove => IL.PlayParticleEffects.PlayParticleSystems -= value;
    }
}