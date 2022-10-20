namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GetHero.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGetHero
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.GetHero.Reset += value;
        remove => IL.GetHero.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.GetHero.OnEnter += value;
        remove => IL.GetHero.OnEnter -= value;
    }
}