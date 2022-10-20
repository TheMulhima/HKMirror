namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SetDamageOverride.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSetDamageOverride
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.SetDamageOverride.Reset += value;
        remove => IL.SetDamageOverride.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.SetDamageOverride.OnEnter += value;
        remove => IL.SetDamageOverride.OnEnter -= value;
    }
}