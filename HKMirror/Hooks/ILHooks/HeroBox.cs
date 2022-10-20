namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for HeroBox.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILHeroBox
{
    public static event ILContext.Manipulator Start
    {
        add => IL.HeroBox.Start += value;
        remove => IL.HeroBox.Start -= value;
    }

    public static event ILContext.Manipulator OnTriggerEnter2D
    {
        add => IL.HeroBox.OnTriggerEnter2D += value;
        remove => IL.HeroBox.OnTriggerEnter2D -= value;
    }

    public static event ILContext.Manipulator OnTriggerStay2D
    {
        add => IL.HeroBox.OnTriggerStay2D += value;
        remove => IL.HeroBox.OnTriggerStay2D -= value;
    }

    public static event ILContext.Manipulator CheckForDamage
    {
        add => IL.HeroBox.CheckForDamage += value;
        remove => IL.HeroBox.CheckForDamage -= value;
    }

    public static event ILContext.Manipulator IsHitTypeBuffered
    {
        add => IL.HeroBox.IsHitTypeBuffered += value;
        remove => IL.HeroBox.IsHitTypeBuffered -= value;
    }

    public static event ILContext.Manipulator LateUpdate
    {
        add => IL.HeroBox.LateUpdate += value;
        remove => IL.HeroBox.LateUpdate -= value;
    }

    public static event ILContext.Manipulator ApplyBufferedHit
    {
        add => IL.HeroBox.ApplyBufferedHit += value;
        remove => IL.HeroBox.ApplyBufferedHit -= value;
    }
}