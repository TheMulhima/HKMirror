namespace HKMirror.Hooks.ILHooks;

/// <summary>
///     Contains all correct IL Hooks for PlayHitEffects.<br />
///     Gives the correct GetStateMachineTarget version of IEnumerators ILs that run after every yeild return.<br />
///     Includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
/// </summary>
public static class ILPlayHitEffects
{
    public static event ILContext.Manipulator Awake
    {
        add => IL.PlayHitEffects.Awake += value;
        remove => IL.PlayHitEffects.Awake -= value;
    }

    public static event ILContext.Manipulator Reset
    {
        add => IL.PlayHitEffects.Reset += value;
        remove => IL.PlayHitEffects.Reset -= value;
    }

    public static event ILContext.Manipulator OnEnter
    {
        add => IL.PlayHitEffects.OnEnter += value;
        remove => IL.PlayHitEffects.OnEnter -= value;
    }
}