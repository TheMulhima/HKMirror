namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SetRespawningHero.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSetRespawningHero
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.SetRespawningHero.Reset += value;
        remove => IL.SetRespawningHero.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.SetRespawningHero.OnEnter += value;
        remove => IL.SetRespawningHero.OnEnter -= value;
    }
}