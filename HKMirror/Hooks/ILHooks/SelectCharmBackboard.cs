namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SelectCharmBackboard.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSelectCharmBackboard
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.SelectCharmBackboard.Reset += value;
        remove => IL.SelectCharmBackboard.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.SelectCharmBackboard.OnEnter += value;
        remove => IL.SelectCharmBackboard.OnEnter -= value;
    }
}