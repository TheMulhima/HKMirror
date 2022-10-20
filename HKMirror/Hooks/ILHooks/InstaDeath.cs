namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for InstaDeath.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILInstaDeath
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.InstaDeath.Reset += value;
        remove => IL.InstaDeath.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.InstaDeath.OnEnter += value;
        remove => IL.InstaDeath.OnEnter -= value;
    }
}