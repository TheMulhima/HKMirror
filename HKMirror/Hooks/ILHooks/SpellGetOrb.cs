namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for SpellGetOrb.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILSpellGetOrb
{
    public static event ILContext.Manipulator Start
    {
        add => IL.SpellGetOrb.Start += value;
        remove => IL.SpellGetOrb.Start -= value;
    }

    public static event ILContext.Manipulator OnEnable
    {
        add => IL.SpellGetOrb.OnEnable += value;
        remove => IL.SpellGetOrb.OnEnable -= value;
    }

    public static event ILContext.Manipulator Update
    {
        add => IL.SpellGetOrb.Update += value;
        remove => IL.SpellGetOrb.Update -= value;
    }

    public static event ILContext.Manipulator FaceAngle
    {
        add => IL.SpellGetOrb.FaceAngle += value;
        remove => IL.SpellGetOrb.FaceAngle -= value;
    }

    public static event ILContext.Manipulator ProjectileSquash
    {
        add => IL.SpellGetOrb.ProjectileSquash += value;
        remove => IL.SpellGetOrb.ProjectileSquash -= value;
    }

    public static event ILContext.Manipulator Collect
    {
        add => IL.SpellGetOrb.Collect += value;
        remove => IL.SpellGetOrb.Collect -= value;
    }
}