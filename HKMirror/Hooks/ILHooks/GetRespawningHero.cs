namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GetRespawningHero.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGetRespawningHero
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.GetRespawningHero.Reset += value;
        remove => IL.GetRespawningHero.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.GetRespawningHero.OnEnter += value;
        remove => IL.GetRespawningHero.OnEnter -= value;
    }
}