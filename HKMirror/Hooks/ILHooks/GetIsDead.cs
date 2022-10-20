namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for GetIsDead.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILGetIsDead
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.GetIsDead.Reset += value;
        remove => IL.GetIsDead.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.GetIsDead.OnEnter += value;
        remove => IL.GetIsDead.OnEnter -= value;
    }
}