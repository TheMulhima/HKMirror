namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for ExtraDamageable.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILExtraDamageable
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.ExtraDamageable.Awake += value;
        remove => IL.ExtraDamageable.Awake -= value;
    }

    public static event ILContext.Manipulator LateUpdate
    {
        add => IL.ExtraDamageable.LateUpdate += value;
        remove => IL.ExtraDamageable.LateUpdate -= value;
    }

    public static event ILContext.Manipulator RecieveExtraDamage
    {
        add => IL.ExtraDamageable.RecieveExtraDamage += value;
        remove => IL.ExtraDamageable.RecieveExtraDamage -= value;
    }

    public static event ILContext.Manipulator GetDamageOfType
    {
        add => IL.ExtraDamageable.GetDamageOfType += value;
        remove => IL.ExtraDamageable.GetDamageOfType -= value;
    }

    public static event ILContext.Manipulator ApplyExtraDamageToHealthManager
    {
        add => IL.ExtraDamageable.ApplyExtraDamageToHealthManager += value;
        remove => IL.ExtraDamageable.ApplyExtraDamageToHealthManager -= value;
    }
}