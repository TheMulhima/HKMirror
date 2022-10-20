namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SetSpecialDeath.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSetSpecialDeath
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.SetSpecialDeath.Reset += value;
        remove => IL.SetSpecialDeath.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.SetSpecialDeath.OnEnter += value;
        remove => IL.SetSpecialDeath.OnEnter -= value;
    }
}