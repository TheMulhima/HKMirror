namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GetCharmString.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGetCharmString
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.GetCharmString.Reset += value;
        remove => IL.GetCharmString.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.GetCharmString.OnEnter += value;
        remove => IL.GetCharmString.OnEnter -= value;
    }
}