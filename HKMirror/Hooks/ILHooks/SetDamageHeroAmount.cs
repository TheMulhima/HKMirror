namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SetDamageHeroAmount.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSetDamageHeroAmount
{
    public static event ILContext.Manipulator Reset
    {
        add => IL.SetDamageHeroAmount.Reset += value;
        remove => IL.SetDamageHeroAmount.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.SetDamageHeroAmount.OnEnter += value;
        remove => IL.SetDamageHeroAmount.OnEnter -= value;
    }
}