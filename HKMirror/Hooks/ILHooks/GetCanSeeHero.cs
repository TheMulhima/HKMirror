namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GetCanSeeHero.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGetCanSeeHero
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.GetCanSeeHero.Reset += value;
        remove => IL.GetCanSeeHero.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.GetCanSeeHero.OnEnter += value;
        remove => IL.GetCanSeeHero.OnEnter -= value;
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add => IL.GetCanSeeHero.OnUpdate += value;
        remove => IL.GetCanSeeHero.OnUpdate -= value;
    }

    public static event ILContext.Manipulator Apply
    {
        add => IL.GetCanSeeHero.Apply += value;
        remove => IL.GetCanSeeHero.Apply -= value;
    }
}