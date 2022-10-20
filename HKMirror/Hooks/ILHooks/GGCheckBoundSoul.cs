namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GGCheckBoundSoul.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGGCheckBoundSoul
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.GGCheckBoundSoul.Reset += value;
        remove => IL.GGCheckBoundSoul.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.GGCheckBoundSoul.OnEnter += value;
        remove => IL.GGCheckBoundSoul.OnEnter -= value;
    }
}