namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for DamageEffectTicker.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILDamageEffectTicker
{
    public static event ILContext.Manipulator OnEnable
    {
        add => IL.DamageEffectTicker.OnEnable += value;
        remove => IL.DamageEffectTicker.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.DamageEffectTicker.Update += value;
        remove => IL.DamageEffectTicker.Update -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.DamageEffectTicker.OnTriggerEnter2D += value;
        remove => IL.DamageEffectTicker.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerExit2D
    {
        add => IL.DamageEffectTicker.OnTriggerExit2D += value;
        remove => IL.DamageEffectTicker.OnTriggerExit2D -= value;
    }

    public static event ILContext.Manipulator EmptyDamageList
    {
        add => IL.DamageEffectTicker.EmptyDamageList += value;
        remove => IL.DamageEffectTicker.EmptyDamageList -= value;
    }

    public static event ILContext.Manipulator SetDamageEvent
    {
        add => IL.DamageEffectTicker.SetDamageEvent += value;
        remove => IL.DamageEffectTicker.SetDamageEvent -= value;
    }

    public static event ILContext.Manipulator SetDamageInterval
    {
        add => IL.DamageEffectTicker.SetDamageInterval += value;
        remove => IL.DamageEffectTicker.SetDamageInterval -= value;
    }
}