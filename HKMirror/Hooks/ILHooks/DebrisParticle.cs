namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for DebrisParticle.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDebrisParticle
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.DebrisParticle.Reset += value;
        remove => IL.DebrisParticle.Reset -= value;
    }

    public static event ILContext.Manipulator Awake
    {
        add => IL.DebrisParticle.Awake += value;
        remove => IL.DebrisParticle.Awake -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.DebrisParticle.OnEnable += value;
        remove => IL.DebrisParticle.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.DebrisParticle.Update += value;
        remove => IL.DebrisParticle.Update -= value;
    }
}