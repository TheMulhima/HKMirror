namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for IgnoreHeroCollision.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILIgnoreHeroCollision
{
    public static event ILContext.Manipulator Start
    {
        add => IL.IgnoreHeroCollision.Start += value;
        remove => IL.IgnoreHeroCollision.Start -= value;
    }

    public static event ILContext.Manipulator Ignore
    {
        add => IL.IgnoreHeroCollision.Ignore += value;
        remove => IL.IgnoreHeroCollision.Ignore -= value;
    }

    public static event ILContext.Manipulator OnCollisionEnter2D
    {
        add => IL.IgnoreHeroCollision.OnCollisionEnter2D += value;
        remove => IL.IgnoreHeroCollision.OnCollisionEnter2D -= value;
    }
}