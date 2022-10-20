namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for CheckCanSeeHero.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILCheckCanSeeHero
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.CheckCanSeeHero.Reset += value;
        remove => IL.CheckCanSeeHero.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.CheckCanSeeHero.OnEnter += value;
        remove => IL.CheckCanSeeHero.OnEnter -= value;
    }

    public static event ILContext.Manipulator OnUpdate
    {
        add => IL.CheckCanSeeHero.OnUpdate += value;
        remove => IL.CheckCanSeeHero.OnUpdate -= value;
    }

    public static event ILContext.Manipulator Apply
    {
        add => IL.CheckCanSeeHero.Apply += value;
        remove => IL.CheckCanSeeHero.Apply -= value;
    }
}