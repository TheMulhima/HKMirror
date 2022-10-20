namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for DamageHero.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDamageHero
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.DamageHero.OnEnable += value;
        remove => IL.DamageHero.OnEnable -= value;
    }
}